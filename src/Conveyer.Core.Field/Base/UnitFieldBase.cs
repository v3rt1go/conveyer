using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Conveyer.Core.Field.Interface;
using Conveyer.Core.Field.State;
using Conveyer.Core.Field.Types;
using Conveyer.Core.Field.Ui;
using Conveyer.Core.Field.Validations;
using Conveyer.Core.State;

namespace Conveyer.Core.Field.Base
{
    public abstract class UnitFieldBase : IUnitField
    {
        protected UnitFieldBase()
        {
        }

        protected UnitFieldBase(Guid callerId, Guid belongsTo)
        {
            this.CreatedBy = callerId;
            this.BelongsTo = belongsTo;
        }

        protected UnitFieldBase(Guid callerId, FieldType type, string displayValue, DisplayType displayType, Guid belongsTo)
        {
            this.CreatedBy = callerId;
            this.Type = type;
            this.DisplayType = displayType;
            this.DisplayValue = displayValue;
            this.BelongsTo = belongsTo;
        }

        public Guid Id { get; } = Guid.NewGuid();

        [DefaultValue(FieldState.Clean)]
        public FieldState State { get; set; } = FieldState.Clean;

        [Required]
        [DefaultValue(FieldType.ShortText)]
        public FieldType Type { get; } = FieldType.ShortText;

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
