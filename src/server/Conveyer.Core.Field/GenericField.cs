using System.Linq;
using Conveyer.Core.Field.Helpers;

namespace Conveyer.Core.Field
{
    using System;
    using System.Collections.Generic;
    using Types;
    using Ui;
    using Base;
    using Validations;

    public class GenericField : UnitFieldBase
    {
        /// <summary>
        /// Creates a new instance of GenericField with default values.
        /// This constructor is protected and should be only used by serializer
        /// </summary>
        protected GenericField()
        {
        }

        /// <summary>
        /// Creates a new instance of GenericField with default values and
        /// assigns it to its creator and parent unit.
        /// </summary>
        /// <param name="callerId">The id of the user who created the GenericField</param>
        /// <param name="unitId">The id of the unit the field belongs to</param>
        public GenericField(Guid callerId, Guid unitId)
            : base(callerId, unitId)
        {
        }

        /// <summary>
        /// Creates a new instance of GenericField and assign it all the required values.
        /// This constructor is used by the API when deserializing unit field data.
        /// </summary>
        /// <param name="callerId">The id of the user who created the GenericField</param>
        /// <param name="displayValue">Value displayed for the GenericField in the Conveyer UI</param>
        /// <param name="displayType">Type of input template used to render the GenericField in the Conveyer UI</param>
        /// <param name="unitId">The id of the parent Unit</param>
        public GenericField(string displayValue, DisplayType displayType, Guid callerId, Guid unitId)
            : base(displayValue, displayType, callerId, unitId)
        {
        }

        /// <summary>
        /// Creates a new instance of GenericField and assign it all the required values.
        /// This constructor is specific to the generic field because it allows setting of FieldType.
        /// </summary>
        /// <param name="callerId">The id of the user who created the GenericField</param>
        /// <param name="type">FieldType of the GenericField</param>
        /// <param name="displayValue">Value displayed for the GenericField in the Conveyer UI</param>
        /// <param name="displayType">Type of input template used to render the GenericField in the Conveyer UI</param>
        /// <param name="unitId">The id of the parent Unit</param>
        public GenericField(FieldType type, string displayValue, DisplayType displayType, Guid callerId, Guid unitId)
            : base(type, displayValue, displayType, callerId, unitId)
        {
        }

        public override IReadOnlyList<ValidationType> AllowedValidations { get; } =
            FieldSettings.ValidationTypes["All"].ToList();

        public override IReadOnlyList<DisplayType> AllowedDisplayTypes { get; } =
            FieldSettings.DisplayTypes["All"].ToList();
    }
}
