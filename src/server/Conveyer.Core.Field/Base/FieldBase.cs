using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Conveyer.Core.Field.Helpers;
using Conveyer.Core.Field.Interfaces;
using Conveyer.Core.State;

namespace Conveyer.Core.Field.Base
{
    public abstract class FieldBase : IField
    {
        protected FieldBase()
        {
        }

        protected FieldBase(Guid callerId, Guid unitId)
        {
            // TODO: Write a Guard utility class to check if Guid is valid
            if (callerId == Guid.Empty)
                throw new ArgumentException("Please provide a valid Caller Id", nameof(callerId));
            if (unitId == Guid.Empty)
                throw new ArgumentException("Please provide a valid Unit Id", nameof(unitId));

            CreatedBy = callerId;
            UnitId = unitId;
        }

        protected FieldBase(string displayValue, DisplayType displayType, Guid callerId, Guid unitId)
            : this(callerId, unitId)
        {
            DisplayType = displayType;
            DisplayValue = displayValue;
        }

        protected FieldBase(FieldType type, string displayValue, DisplayType displayType, Guid callerId, Guid unitId)
            : this(callerId, unitId)
        {
            Type = type;
            DisplayType = displayType;
            DisplayValue = displayValue;
        }

        public Guid Id { get; } = Guid.NewGuid();

        [DefaultValue(FieldState.Clean)]
        public FieldState State { get; set; } = FieldState.Clean;

        [Required]
        [DefaultValue(FieldType.ShortText)]
        public virtual FieldType Type { get; } = FieldType.ShortText;

        // TODO: Should throw if setting DisplayValue to string null/empty
        [Required]
        public string DisplayValue { get; set; }

        public string HelpText { get; set; }

        // TODO: Should throw if setting ValidationRules is not in AllowedValidations
        public IEnumerable<ValidationType> ValidationRules { get; set; }

        public abstract IReadOnlyList<ValidationType> AllowedValidations { get; }

        // TODO: Should throw if setting DisplayType is not in AllowedDisplayTypes
        [DefaultValue(DisplayType.SingleLine)]
        public DisplayType DisplayType { get; set; } = DisplayType.SingleLine;

        public abstract IReadOnlyList<DisplayType> AllowedDisplayTypes { get; }

        // TODO: Should throw if setting Version <= 0
        [DefaultValue(1)]
        public int Version { get; set; } = 1;

        public DateTime CreatedAt { get; } = DateTime.Now;

        public Guid CreatedBy { get; }

        // TODO: Should throw if setting UpdatedAt < DateTime.Now
        public DateTime? UpdatedAt { get; set; }

        public Guid? UpdatedBy { get; set; }

        [DefaultValue(AccessModifier.Public)]
        public AccessModifier Access { get; set; } = AccessModifier.Public;

        public Guid UnitId { get; set; }
    }
}
