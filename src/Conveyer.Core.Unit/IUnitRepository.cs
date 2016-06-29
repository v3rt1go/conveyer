namespace Conveyer.Core.Unit
{
	using System;
	using System.Collections.Generic;

	public interface IUnitRepository
	{
		/// <summary>
		/// Saves the new unit in the module data store
		/// </summary>
		/// <param name="newUnit">The new unit entity</param>
		void AddUnit(IUnit newUnit);

		/// <summary>
		/// Gets all units from the data store
		/// </summary>
		/// <returns>An enumerable of unit entities</returns>
		IEnumerable<IUnit> GetUnits();

		/// <summary>
		/// Gets all units that belong to the module
		/// </summary>
		/// <param name="id">The module id</param>
		/// <returns>An enumerable of unit entities that belong to the module</returns>
		IEnumerable<IUnit> GetUnitsForModule(Guid id);

		/// <summary>
		/// Gets the unit from the data store
		/// </summary>
		/// <param name="id">The unit id</param>
		/// <returns>The unit entity</returns>
		IUnit GetUnit(Guid id);

		/// <summary>
		/// Updates the unit and persists the changes in the data store
		/// </summary>
		/// <param name="id">The id of the unit</param>
		/// <param name="unit">The updated unit entity</param>
		void UpdateUnit(Guid id, IUnit unit);

		/// <summary>
		/// Updates all units and persists changes in the data store
		/// </summary>
		/// <param name="units">The list of units to be updated</param>
		void UpdateUnits(IEnumerable<IUnit> units);

		/// <summary>
		/// Update all units that belong to a module and persists
		/// the changes in the data store
		/// </summary>
		/// <param name="id">The module id</param>
		/// <param name="units">The list of units to be updated</param>
		void UpdateUnitsForModule(Guid id, IEnumerable<IUnit> units);

		/// <summary>
		/// Deletes a unit from the data store
		/// </summary>
		/// <param name="id">The id of the unit</param>
		void DeleteUnit(Guid id);
	}
}
