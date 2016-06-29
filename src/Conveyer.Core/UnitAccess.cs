namespace Conveyer.Core
{
	/// <summary>
	/// Access options for the unit entity
	/// </summary>
	public enum UnitAccess
	{
		/// <summary>
		/// This unit has a private access level and cannot be
		/// accessed from outside its parent module
		/// </summary>
		Private,

		/// <summary>
		/// This unit has a public access level and can be
		/// accessed from outside its parent module.
		/// </summary>
		Public
	}
}
