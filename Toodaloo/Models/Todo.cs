using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Toodaloo.Models {
	/// <summary>
	/// A Todo-list item
	/// </summary>
	public class Todo {
		/// <summary>
		/// Auto-incremented Id of the Todo
		/// </summary>
		[Key]
		public int Id { get; set; }

		/// <summary>
		/// Description of the Todo
		/// </summary>
		[Required]
		[MaxLength(250)]
		public string Description { get; set; }

		/// <summary>
		/// Completiong status of the Todo
		/// </summary>
		[DefaultValue(false)]
		public bool Complete { get; set; }

		/// <summary>
		/// Timestamp that tracks when the Todo was last modified
		/// </summary>
		public DateTime LastModified { get; set; }
	}
}