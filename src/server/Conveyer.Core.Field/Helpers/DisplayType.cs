namespace Conveyer.Core.Field.Helpers
{
	/// <summary>
	/// Display type options for the UnitField entity
	/// </summary>
	public enum DisplayType
	{
		/// <summary>
		/// Displays the field as a single line text input box.
		/// </summary>
		SingleLine,

		/// <summary>
		/// Displays the field as a text area field type
		/// </summary>
		MultiLine,

		/// <summary>
		/// Displays the field as a number input type
		/// </summary>
		Number,

		/// <summary>
		/// Displays the field using a Markdown editor with preview
		/// </summary>
		Markdown,

		/// <summary>
		/// Displays the field using a rich text type editor
		/// </summary>
		RichText,

		/// <summary>
		/// Displays the field as a drop-down input type
		/// </summary>
		Dropdown,

		/// <summary>
		/// Displays the filed as a radio group input type
		/// </summary>
		RadioList,

		/// <summary>
		/// Displays the field as a checkbox group input type
		/// </summary>
		CheckboxList,

		/// <summary>
		/// Displays the field as a date input type
		/// </summary>
		Date,

		/// <summary>
		/// Displays the field as a date time input type
		/// </summary>
		DateTime,

		/// <summary>
		/// Displays the field as a calendar picker type
		/// </summary>
		DatePicker,

		/// <summary>
		/// Displays the field as a url input type
		/// </summary>
		Url,

		/// <summary>
		/// Displays the field as an e-mail input type
		/// </summary>
		Email,

		/// <summary>
		/// Displays the field as a telephone input type
		/// </summary>
		Telephone,

		/// <summary>
		/// Displays the field as an image upload type with preview
		/// </summary>
		Image,

		/// <summary>
		/// Displays the field as a responsive image upload type with preview
		/// </summary>
		ResponsiveImage,

		/// <summary>
		/// Displays the field as a video upload type with preview
		/// </summary>
		Video,

		/// <summary>
		/// Displays the field as a list picker input type
		/// </summary>
		List,

		/// <summary>
		/// Displays the field as a select list add input type
		/// </summary>
		LinkedList,

		/// <summary>
		/// Displays the field as a drag-n-drop card selector input type
		/// </summary>
		Card,

		/// <summary>
		/// Displays the field as a on/off flag switch input type
		/// </summary>
		Flag,

		/// <summary>
		/// Displays the field as a code editor type
		/// </summary>
		CodeEditor,

		/// <summary>
		/// Displays the field as a button input type
		/// </summary>
		Button
	}
}
