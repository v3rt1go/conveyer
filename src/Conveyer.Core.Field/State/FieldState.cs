namespace Conveyer.Core.Field.State
{
	/// <summary>
	/// State options for the UnitField entity
	/// </summary>
	public enum FieldState
	{
		/// <summary>
		/// The UnitField is usable online and no changes have been done to its
		/// content
		/// </summary>
		Enabled,

		/// <summary>
		/// The UnitField has had changes that need to be persisted in the data
		/// store
		/// </summary>
		Changed,

		/// <summary>
		/// The UnitField has had changes that have been persisted in the data store
		/// </summary>
		Clean,

		/// <summary>
		/// The UnitField is no longer usable online and its content has been archived.
		/// To access the content load previous versions of the Unit entity
		/// </summary>
		Archived
	}
}
