namespace Conveyer.Core.Field.Helpers
{
	/// <summary>
	/// Field type options for the UnitField entity.
	/// </summary>
	public enum FieldType
	{
		/// <summary>
		/// Represents a string of less than 255 characters
		/// </summary>
		ShortText,

		/// <summary>
		/// Represents a long string of indefinite size
		/// </summary>
		LongText,

		/// <summary>
		/// Represents any type of positive or negative number followed
		/// by any number of decimals
		/// </summary>
		Number,

		/// <summary>
		/// Represents a True/False flag
		/// </summary>
		Boolean,

		/// <summary>
		/// Represents a DateTime string of any de-serializable format
		/// </summary>
		DateTime,

		/// <summary>
		/// Represents a list of values of the same type
		/// </summary>
		List,

		/// <summary>
		/// Represents a list of referenced entities
		/// </summary>
		ReferenceMany,

		/// <summary>
		/// Represents one referenced entity
		/// </summary>
		ReferenceOne,

		/// <summary>
		/// Represents a base64 string that is decoded into a media asset
		/// </summary>
		Media,

		/// <summary>
		/// Represents a string that should have a valid URL format
		/// </summary>
		Url,

		/// <summary>
		/// Represents a string that should have a valid e-mail format
		/// </summary>
		Email,

		/// <summary>
		/// Represents a string that should have a valid telephone format
		/// </summary>
		Telephone
	}
}
