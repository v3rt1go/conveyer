using System;
using System.Collections.Generic;

namespace Conveyer.Core.Field.Interface
{
    public interface IUnitFieldRepository
	{
		/// <summary>
		/// Adds a new unit field to the data store
		/// </summary>
		/// <param name="newUnitField">The unit field entity</param>
		void AddUnitField(IUnitField newUnitField);

		/// <summary>
		/// Gets an existing unit field from the data store
		/// </summary>
		/// <param name="id">The id of the unit field</param>
		/// <returns>The unit field or null if it was not found</returns>
		IUnitField GetUnitField(Guid id);

		/// <summary>
		/// Gets all unit fields from the data store
		/// </summary>
		/// <returns>An enumerable of unit field entities</returns>
		IEnumerable<IUnitField> GetUnitFields();

		/// <summary>
		/// Gets all the unit fields from the data store that belong
		/// to a certain unit
		/// </summary>
		/// <param name="unitId">The id of the unit</param>
		/// <returns>An enumerable of unit field entities</returns>
		IEnumerable<IUnitField> GetUnitFieldsForUnit(Guid unitId);

		/// <summary>
		/// Updates the unit field and persists changes in the data store
		/// </summary>
		/// <param name="id">The id of the unit field</param>
		/// <param name="unitField">The updated unit field entity</param>
		void UpdateUnitField(Guid id, IUnitField unitField);

		/// <summary>
		/// Updates all the unit fields and persists the changes in the
		/// data store
		/// </summary>
		/// <param name="unitFields">The list of updated unit field</param>
		void UpdateUnitFields(IEnumerable<IUnitField> unitFields);

		/// <summary>
		/// Updates all the unit fields that belong to a unit and persists
		/// the changes in the data store
		/// </summary>
		/// <param name="unitId">The id of the unit</param>
		/// <param name="unitFields">The list of updated unit fields</param>
		void UpdateUnitFieldsForUnit(Guid unitId, IEnumerable<IUnitField> unitFields);

		/// <summary>
		/// Deletes the unit field from the data store
		/// </summary>
		/// <param name="id">The id of the unit field</param>
		void DeleteUnitField(Guid id);
	}
}
