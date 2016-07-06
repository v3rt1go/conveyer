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
        /// <summary>
        /// Creates a new instance of ShortTextField with default values.
        /// This constructor is protected and should only be used by serializers.
        /// </summary>
        protected ShortTextField()
        {
        }

        /// <summary>
        /// Creates a new instance of ShortTextField with default values and
        /// assigns it to its creator and parent unit.
        /// </summary>
        /// <param name="callerId">The id of the user who created the ShortTextField</param>
        /// <param name="unitId">The id of the unit the field belongs to</param>
        public ShortTextField(Guid callerId, Guid unitId)
            : base(callerId, unitId)
        {
        }

        /// <summary>
        /// Creates a new instance of ShortTextField and assign it all the required values.
        /// This constructor is used by the API when deserializing unit field data.
        /// </summary>
        /// <param name="callerId">The id of the user who created the ShortTextField</param>
        /// <param name="displayValue">Value displayed for the ShortTextField in the Conveyer UI</param>
        /// <param name="displayType">Type of input template used to render the ShortTextField in the Conveyer UI</param>
        /// <param name="unitId">The id of the parent Unit</param>
        public ShortTextField(string displayValue, DisplayType displayType, Guid callerId, Guid unitId)
            : base(displayValue, displayType, callerId, unitId)
        {
        }

        public override FieldType Type { get; } = FieldType.ShortText;

        // NOTE: Investigate possibility of defining allowed validation and display types at runtime.
        // REFACTOR: Create a static class that will hold allowed validation types for each field type
        public override IReadOnlyList<ValidationType> AllowedValidations { get; }
            = new List<ValidationType>
        {
            ValidationType.Required, ValidationType.Format, ValidationType.Range, ValidationType.Custom
        };
        public override IReadOnlyList<DisplayType> AllowedDisplayTypes { get; }
            = new List<DisplayType>
        {
            DisplayType.SingleLine, DisplayType.MultiLine, DisplayType.Button
        };
    }
}
