namespace Conveyer.Core.Field
{
	using System;
	using System.Collections.Generic;

	using Conveyer.Core.Field.State;
	using Conveyer.Core.Field.Types;
	using Conveyer.Core.Field.Ui;
	using Conveyer.Core.Field.Validations;
	using Conveyer.Core.State;

	public abstract class UnitFieldBase : IUnitField
	{
		public Guid Id { get; }

		public FieldState State { get; set; }

		public FieldType Type { get; }

		public string DisplayValue { get; set; }

		public string HelpText { get; set; }

		public IEnumerable<ValidationType> ValidationRules { get; set; }

		public IReadOnlyList<ValidationType> AllowedValidations { get; }

		public string[] SerializationRules { get; set; }

		public string[] AllowedSerializers { get; set; }

		public DisplayType DisplayType { get; set; }

		public IReadOnlyList<DisplayType> AllowedDisplayTypes { get; }

		public int Version { get; set; }

		public DateTime CreatedAt { get; }

		public Guid CreatedBy { get; }

		public DateTime? UpdatedAt { get; set; }

		public Guid? UpdatedBy { get; set; }

		public AccessModifier Access { get; set; }

		public Guid BelongsTo { get; set; }
	}
}
