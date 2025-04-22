using Color = System.Windows.Media.Color;

namespace Highlighter
{
    internal static class Consts
    {
        internal const string _classificationTypeNameToDo = "Comment.Todo";
        internal const string _classificationTypeNameBug = "Comment.Bug";
        internal const string _classificationTypeNameFix = "Comment.FixMe";
        internal const string _classificationTypeNameNote = "Comment.Note";
        internal const string _classificationTypeNameOptimize = "Comment.Optimize";
        internal const string _classificationTypeNameDiscuss = "Comment.Discuss";
        internal const string _classificationTypeNameStep = "Comment.Step";
        internal const string _classificationTypeNameImportant = "Comment.Important";
        internal const string _classificationTypeNameInfo = "Comment.Info";
        internal const string _classificationTypeNameExperimental = "Comment.Experimental";
        internal const string _classificationTypeNameHack = "Comment.Hack";
        internal const string _classificationTypeNameFixNew = "Comment.FixNew";

        internal static class Colors
        {
            internal static readonly Color _todo = Color.FromRgb(46, 204, 113);
            internal static readonly Color _bug = Color.FromRgb(231, 76, 60);
            internal static readonly Color _fix = Color.FromRgb(230, 126, 34);
            internal static readonly Color _note = Color.FromRgb(52, 152, 219);
            internal static readonly Color _optimize = Color.FromRgb(26, 188, 156);
            internal static readonly Color _system = Color.FromRgb(51, 51, 3);
            internal static readonly Color _discuss = Color.FromRgb(241, 196, 15);
            internal static readonly Color _step = Color.FromRgb(241, 126, 23);
            internal static readonly Color _important = Color.FromRgb(235, 217, 180);
            internal static readonly Color _info = Color.FromRgb(100, 200, 255);
            internal static readonly Color _experimental = Color.FromRgb(255, 255, 10);
            internal static readonly Color _hack = Color.FromRgb(255, 20, 20);
            internal static readonly Color _fixnew = Color.FromRgb(255, 116, 146);
        }
    }
}