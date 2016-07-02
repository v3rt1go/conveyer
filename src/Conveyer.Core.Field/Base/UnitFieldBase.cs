namespace Conveyer.Core.Field.Base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using Interface;
    using State;
    using Types;
    using Ui;
    using Validations;
    using Core.State;

    public abstract class UnitFieldBase : IUnitField
    {
        protected UnitFieldBase()
        {
        }

        protected UnitFieldBase(Guid callerId, Guid belongsTo)
        {
            CreatedBy = callerId;
            BelongsTo = belongsTo;
        }

        protected UnitFieldBase(Guid callerId, string displayValue, DisplayType displayType, Guid belongsTo)
        {
            CreatedBy = callerId;
            DisplayType = displayType;
            DisplayValue = displayValue;
            BelongsTo = belongsTo;
        }

        protected UnitFieldBase(Guid callerId, FieldType type, string displayValue, DisplayType displayType, Guid belongsTo)
        {
            CreatedBy = callerId;
            Type = type;
            DisplayType = displayType;
            DisplayValue = displayValue;
            BelongsTo = belongsTo;
        }

        public Guid Id { get; } = Guid.NewGuid();

        [DefaultValue(FieldState.Clean)]
        public FieldState State { get; set; } = FieldState.Clean;

        [Required]
        [DefaultValue(FieldType.ShortText)]
        public virtual FieldType Type { get; } = FieldType.ShortText;

        [Required]
        public string DisplayValue { get; set; }

        public string HelpText { get; set; }

        public IEnumerable<ValidationType> ValidationRules { get; set; }

        public abstract IReadOnlyList<ValidationType> AllowedValidations { get; }

        [DefaultValue(DisplayType.SingleLine)]
        public DisplayType DisplayType { get; set; } = DisplayType.SingleLine;

        public abstract IReadOnlyList<DisplayType> AllowedDisplayTypes { get; }

        [DefaultValue(1)]
        public int Version { get; set; } = 1;

        public DateTime CreatedAt { get; } = DateTime.Now;

        public Guid CreatedBy { get; }

        public DateTime? UpdatedAt { get; set; }

        public Guid? UpdatedBy { get; set; }

        [DefaultValue(AccessModifier.Public)]
        public AccessModifier Access { get; set; } = AccessModifier.Public;

        public Guid BelongsTo { get; set; }
    }
}
