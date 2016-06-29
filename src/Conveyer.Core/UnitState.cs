namespace Conveyer.Core
{
	/// <summary>
	///	State options for the unit entity
	/// </summary>
	public enum UnitState
	{
		/// <summary>
		/// This unit has been published and is viewable online
		/// </summary>
		Published,

		/// <summary>
		/// This unit has had its structure modified and changes haven't been saved
		/// </summary>
		Changed,

		/// <summary>
		/// This unit is newly created and is not visible online yet
		/// </summary>
		Draft,

		/// <summary>
		/// This unit has been archived and is no longer visible online
		/// </summary>
		Archived
	}
}
