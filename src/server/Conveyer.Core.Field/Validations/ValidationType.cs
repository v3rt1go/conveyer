namespace Conveyer.Core.Field.Validations
{
	/// <summary>
	/// Validation type options for the UnitField entity
	/// </summary>
	public enum ValidationType
	{
		/// <summary>
		/// Applies required validations on the unit field
		/// </summary>
		Required,

		/// <summary>
		/// Applies min - max range validations on the unit field
		/// </summary>
		Range,

		/// <summary>
		/// Applies custom regex validations on the unit field
		/// </summary>
		Format,

		/// <summary>
		/// Applies valid e-mail format validations on the unit field
		/// </summary>
		Email,

		/// <summary>
		/// Applies valid url format validations on the unit field
		/// </summary>
		Url,

		/// <summary>
		/// Applies valid telephone type validations on the unit field.
		/// Validation is based on the country specific (by area code) format.
		/// </summary>
		Telephone,

		/// <summary>
		/// Applies valid date format validations on the unit field.
		/// Date format is validated based on the field format type.
		/// </summary>
		Date,

		/// <summary>
		/// Applies valid date time format validations on the unit field.
		/// DateTime format is validated based on the field format type.
		/// </summary>
		DateTime,

		/// <summary>
		/// Applies min - max date range validations on the unit field
		/// </summary>
		DateRange,

		/// <summary>
		/// Applies min - max time range validations on the unit field
		/// </summary>
		DateTimeRange,

		/// <summary>
		/// Applies attachment mime type validations on the unit field
		/// </summary>
		AttachmentType,

		/// <summary>
		/// Applies attachment size validations on the unit field
		/// </summary>
		AttachmentSize,

		/// <summary>
		/// Applies referenced entity validation on the unit field.
		/// The allowed entity type is defined on the field format type.
		/// </summary>
		EntityType,

		/// <summary>
		/// Applies referenced entity list validation on the unit field.
		/// The list of allowed entity types is defined on the field format type.
		/// </summary>
		EntityList,

		/// <summary>
		/// Applies a custom validator on the unit field.
		/// </summary>
		Custom
	}
}
