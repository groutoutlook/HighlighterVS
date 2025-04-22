﻿using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;
using System.ComponentModel.Composition;

namespace Highlighter
{
    internal static class Definitions
    {
        [Export(typeof(ClassificationTypeDefinition))]
        [Name(Consts._classificationTypeNameToDo)]
        private static readonly ClassificationTypeDefinition Definition_Comment_Todo;

        [Export(typeof(ClassificationTypeDefinition))]
        [Name(Consts._classificationTypeNameBug)]
        private static readonly ClassificationTypeDefinition Definition_Comment_Bug;

        [Export(typeof(ClassificationTypeDefinition))]
        [Name(Consts._classificationTypeNameFix)]
        private static readonly ClassificationTypeDefinition Definition_Comment_FixMe;

        [Export(typeof(ClassificationTypeDefinition))]
        [Name(Consts._classificationTypeNameNote)]
        private static readonly ClassificationTypeDefinition Definition_Comment_Note;

        [Export(typeof(ClassificationTypeDefinition))]
        [Name(Consts._classificationTypeNameOptimize)]
        private static readonly ClassificationTypeDefinition Definition_Comment_Optimize;

        [Export(typeof(ClassificationTypeDefinition))]
        [Name(Consts._classificationTypeNameDiscuss)]
        private static readonly ClassificationTypeDefinition Definition_Comment_Discuss;

        [Export(typeof(ClassificationTypeDefinition))]
        [Name(Consts._classificationTypeNameStep)]
        private static readonly ClassificationTypeDefinition Definition_Comment_Step;

        [Export(typeof(ClassificationTypeDefinition))]
        [Name(Consts._classificationTypeNameImportant)]
        private static readonly ClassificationTypeDefinition Definition_Comment_Important;

        [Export(typeof(ClassificationTypeDefinition))]
        [Name(Consts._classificationTypeNameInfo)]
        private static readonly ClassificationTypeDefinition Definition_Comment_Info;

        [Export(typeof(ClassificationTypeDefinition))]
        [Name(Consts._classificationTypeNameExperimental)]
        private static readonly ClassificationTypeDefinition Definition_Comment_Experimental;

        [Export(typeof(ClassificationTypeDefinition))]
        [Name(Consts._classificationTypeNameHack)]
        private static readonly ClassificationTypeDefinition Definition_Comment_Hack;

        [Export(typeof(ClassificationTypeDefinition))]
        [Name(Consts._classificationTypeNameFixNew)]
        private static readonly ClassificationTypeDefinition Definition_Comment_FixNew;
    }
}