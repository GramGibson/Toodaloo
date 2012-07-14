using System;

namespace Toodaloo.Models {
	/// <summary>
	/// A Todo-list item
	/// </summary>
	public class Todo {
		/// <summary>
		/// Auto-incremented Id of the Todo
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Description of the Todo
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// Timestamp that tracks when the Todo was last modified
		/// </summary>
		public DateTime LastModified { get; set; }
	}
}