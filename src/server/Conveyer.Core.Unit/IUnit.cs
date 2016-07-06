namespace Conveyer.Core.Unit
{
	using System;

	using Conveyer.Core.State;
	using Conveyer.Core.Unit.State;

	/// <summary>
	/// Defines the common contract that all Units adhere to
	/// </summary>
	public interface IUnit
	{
		#region MetaProperties
		/// <summary>
		/// Gets the unique identifier of the unit in GUID format
		/// </summary>
		Guid Id { get; }

		/// <summary>
		/// Gets or sets the State of the unit.
		/// Possible values: Published, Changed, Draft, Archived
		/// </summary>
		UnitState State { get; set; }

		/// <summary>
		/// Gets or sets the display value of the unit. The display value
		/// is used when showing a friendly name of the unit type in the
		/// Conveyer UI
		/// </summary>
		string DisplayValue { get; set; }

		/// <summary>
		/// Gets or sets the version number of the unit. Version number
		/// always starts at 0 and auto increments with each State change
		/// </summary>
		int Version { get; set; }

		/// <summary>
		/// Gets the date when the unit has been created
		/// </summary>
		DateTime CreatedAt { get; }

		/// <summary>
		/// Gets the GUID of the user who created the unit
		/// </summary>
		Guid CreatedBy { get; }

		/// <summary>
		/// Gets or sets the date of the last time the unit has been
		/// updated
		/// </summary>
		DateTime? UpdatedAt { get; set; }

		/// <summary>
		/// Gets or sets the GUID of the user who last updated the unit
		/// </summary>
		Guid? UpdatedBy { get; set; }
		#endregion

		#region SecurityProperties
		/// <summary>
		/// Gets or sets the access level of the unit in relation to other
		/// modules. Possible values: Private, Public
		/// </summary>
		AccessModifier Access { get; set; }

		/// <summary>
		/// Gets or sets the GUID of the module that the unit belongs to
		/// </summary>
		Guid BelongsTo { get; set; }
		#endregion
	}
}
