namespace Conveyer.Core.Field.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class FieldSettings
    {
        public static Dictionary<string, IEnumerable<ValidationType>> ValidationTypes =>
            new Dictionary<string, IEnumerable<ValidationType>>
            {
                {
                    "All",
                    Enum.GetValues(typeof(ValidationType)).Cast<ValidationType>()
                },
                {
                    "ShortText",
                    new []
                    {
                        ValidationType.Required,
                        ValidationType.Format,
                        ValidationType.Range,
                        ValidationType.Custom
                    }
                },
                {
                    "LongText",
                    new []
                    {
                        ValidationType.Required,
                        ValidationType.Format,
                        ValidationType.ValidHtml,
                        ValidationType.ValidMarkdown,
                        ValidationType.Range,
                        ValidationType.Custom
                    }
                }
            };


        public static Dictionary<string, IEnumerable<DisplayType>> DisplayTypes =>
            new Dictionary<string, IEnumerable<DisplayType>>
            {
                {
                    "All",
                    Enum.GetValues(typeof(DisplayType)).Cast<DisplayType>()
                },
                {
                    "ShortText",
                    new []
                    {
                        DisplayType.SingleLine,
                        DisplayType.MultiLine,
                        DisplayType.Button
                    }
                },
                {
                    "LongText",
                    new []
                    {
                        DisplayType.MultiLine,
                        DisplayType.CodeEditor,
                        DisplayType.Markdown,
                        DisplayType.RichText
                    }
                }
            };
    }
}
