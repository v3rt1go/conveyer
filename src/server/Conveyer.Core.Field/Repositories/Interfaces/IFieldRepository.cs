using System;
using System.Collections.Generic;
using Conveyer.Core.Field.Interfaces;

namespace Conveyer.Core.Field.Repositories.Interfaces
{
	// HACK: For in-memory store repository implement the IDisposable interface
	public interface IFieldRepository
	{
		/// <summary>
		/// Adds a new unit field to the data store
		/// </summary>
		/// <param name="newField">The unit field entity</param>
		void AddUnitField(IField newField);

		/// <summary>
		/// Gets an existing unit field from the data store
		/// </summary>
		/// <param name="id">The id of the unit field</param>
		/// <returns>The unit field or null if it was not found</returns>
		IField GetUnitField(Guid id);

		/// <summary>
		/// Gets all unit fields from the data store
		/// </summary>
		/// <returns>An enumerable of unit field entities</returns>
		IEnumerable<IField> GetUnitFields();

		/// <summary>
		/// Gets all the unit fields from the data store that belong
		/// to a certain unit
		/// </summary>
		/// <param name="unitId">The id of the unit</param>
		/// <returns>An enumerable of unit field entities</returns>
		IEnumerable<IField> GetUnitFieldsForUnit(Guid unitId);

		/// <summary>
		/// Updates the unit field and persists changes in the data store
		/// </summary>
		/// <param name="id">The id of the unit field</param>
		/// <param name="field">The updated unit field entity</param>
		void UpdateUnitField(Guid id, IField field);

		/// <summary>
		/// Updates all the unit fields and persists the changes in the
		/// data store
		/// </summary>
		/// <param name="unitFields">The list of updated unit field</param>
		void UpdateUnitFields(IEnumerable<IField> unitFields);

		/// <summary>
		/// Updates all the unit fields that belong to a unit and persists
		/// the changes in the data store
		/// </summary>
		/// <param name="unitId">The id of the unit</param>
		/// <param name="unitFields">The list of updated unit fields</param>
		void UpdateUnitFieldsForUnit(Guid unitId, IEnumerable<IField> unitFields);

		/// <summary>
		/// Deletes the unit field from the data store
		/// </summary>
		/// <param name="id">The id of the unit field</param>
		void DeleteUnitField(Guid id);
	}
}
