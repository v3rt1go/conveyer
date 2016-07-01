namespace Conveyer.Core.Field
{
    using System;
    using System.Collections.Generic;
    using Conveyer.Core.Field.Types;
    using Conveyer.Core.Field.Ui;
    using Conveyer.Core.Field.Base;
    using Conveyer.Core.Field.Validations;

    public class GenericField : UnitFieldBase
    {
        /// <summary>
        /// Creates a new instance of GenericField with default values
        /// </summary>
        public GenericField()
        {
        }

        /// <summary>
        /// Creates a new instance of GenericField with default values and
        /// assigns it to its creator and parent unit.
        /// </summary>
        /// <param name="callerId">The id of the user who created the GenericField</param>
        /// <param name="belongsTo">The id of the unit the field belongs to</param>
        public GenericField(Guid callerId, Guid belongsTo)
            : base(callerId, belongsTo)
        {
        }

        /// <summary>
        /// Creates a new instance of GenericField and assign it all the required values.
        /// This constructor is used by the API when deserializing unit field data.
        /// </summary>
        /// <param name="callerId">The id of the user who created the GenericField</param>
        /// <param name="type">FieldType of the GenericField</param>
        /// <param name="displayValue">Value displayed for the GenericField in the Conveyer UI</param>
        /// <param name="displayType">Type of input template used to render the GenericField in the Conveyer UI</param>
        /// <param name="belongsTo">The id of the parent Unit</param>
        public GenericField(Guid callerId, FieldType type, string displayValue, DisplayType displayType, Guid belongsTo)
            : base(callerId, type, displayValue, displayType, belongsTo)
        {
        }

        // TODO: Initialize with list of allowed validation types and display types for GenericField
        public override IReadOnlyList<ValidationType> AllowedValidations { get; }
        public override IReadOnlyList<DisplayType> AllowedDisplayTypes { get; }
    }
}
