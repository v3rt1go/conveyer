namespace Conveyer.Core.Field.Interface
{
	using System;
	using System.Collections.Generic;
	using Core.State;
	using State;
	using Types;
	using Ui;
	using Validations;

	/// <summary>
	/// Defines the common contract that all UnitFields must adhere to
	/// </summary>
	public interface IUnitField
	{
		#region MetaProperties
		/// <summary>
		/// Gets the unique identifier of the unit in GUID format
		/// </summary>
		Guid Id { get; }

		/// <summary>
		/// Gets or sets the State of the field.
		/// Possible values: Enabled, Changed, Clean, Archived
		/// Default value: Clean
		/// </summary>
		FieldState State { get; set; }

		/// <summary>
		/// Gets the Type of the field.
		/// Once set, the field type cannot be changed else it will break
		/// versioning and history.
		/// Default value: ShortText
		/// </summary>
		FieldType Type { get; }

		/// <summary>
		/// Gets or sets the display value of the field. The display value
		/// is used when showing a friendly name for the field in the
		/// Conveyer UI
		/// </summary>
		string DisplayValue { get; set; }

		/// <summary>
		/// Gets or sets the help text presented on the Conveyer UI for a
		/// specific UnitField
		/// </summary>
		string HelpText { get; set; }

		/// <summary>
		///	Gets or sets the validation rules for the UnitField
		/// </summary>
		IEnumerable<ValidationType> ValidationRules { get; set; }

		/// <summary>
		/// Gets the list of allowed validations based on the FieldType
		/// </summary>
		IReadOnlyList<ValidationType> AllowedValidations { get; }

		/// <summary>
		/// Gets or sets the appearance details for the UnitField
		/// </summary>
		DisplayType DisplayType { get; set; }

		/// <summary>
		/// Gets the list of allowed display types based on the FieldType
		/// </summary>
		IReadOnlyList<DisplayType> AllowedDisplayTypes { get; }

		/// <summary>
		/// Gets or sets the version number of the field. Version number
		/// always starts at 1 and auto increments with each State change
		/// </summary>
		int Version { get; set; }

		/// <summary>
		/// Gets the date when the field has been created
		/// </summary>
		DateTime CreatedAt { get; }

		/// <summary>
		/// Gets the GUID of the user who created the field
		/// </summary>
		Guid CreatedBy { get; }

		/// <summary>
		/// Gets or sets the date of the last time the field has been
		/// updated
		/// </summary>
		DateTime? UpdatedAt { get; set; }

		/// <summary>
		/// Gets or sets the GUID of the user who last updated the field
		/// </summary>
		Guid? UpdatedBy { get; set; }
		#endregion

		#region SecurityProperties
		/// <summary>
		/// Gets or sets the access level of the field in relation to other
		/// units. Possible values: Private, Public
		/// </summary>
		AccessModifier Access { get; set; }

		/// <summary>
		/// Gets or sets the GUID of the unit that the field belongs to
		/// </summary>
		Guid UnitId { get; set; }
		#endregion
	}
}
