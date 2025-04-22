using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;
using System.ComponentModel.Composition;

namespace Highlighter
{
    // INFO: since I want to check C++ and CMakeLists.txt files as well.
    [Export(typeof(IClassifierProvider)), ContentType("CSharp"), ContentType("C/C++"), ContentType("text")]
    internal sealed class Provider : IClassifierProvider
    {
        [Import]
        private readonly IClassificationTypeRegistryService _classificationRegistry;

        [Import]
        private readonly IClassifierAggregatorService _classifierAggregatorService;

        private static bool _ignoreRequest;

        public IClassifier GetClassifier(ITextBuffer textBuffer)
        {
            if (_ignoreRequest)
                return null;

            try
            {
                _ignoreRequest = true;

                return textBuffer.Properties.GetOrCreateSingletonProperty
                (
                    () => new Classifier
                    (
                        _classificationRegistry,
                        _classifierAggregatorService.GetClassifier(textBuffer)
                    )
                );
            }
            finally
            {
                _ignoreRequest = false;
            }
        }
    }
}