using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conveyer.Core.Field.Base;
using Conveyer.Core.Field.Types;
using Conveyer.Core.Field.Ui;
using Conveyer.Core.Field.Validations;

namespace Conveyer.Core.Field
{
    public class ShortTextField : UnitFieldBase
    {

        public ShortTextField()
        {
        }

        public ShortTextField(Guid callerId, Guid belongsTo)
            : base(callerId, belongsTo)
        {
        }

        public ShortTextField(Guid callerId, string displayValue, DisplayType displayType, Guid belongsTo)
            : base(callerId, displayValue, displayType, belongsTo)
        {
        }

        public override FieldType Type { get; } = FieldType.ShortText;

        // NOTE: Investigate possibility of defining allowed validation and display types at runtime.
        public override IReadOnlyList<ValidationType> AllowedValidations { get; }
            = new List<ValidationType> { ValidationType.Required, ValidationType.Format, ValidationType.Range, ValidationType.Custom };
        public override IReadOnlyList<DisplayType> AllowedDisplayTypes { get; }
            = new List<DisplayType> { DisplayType.SingleLine, DisplayType.MultiLine, DisplayType.Button };
    }
}
