using System.Data.Entity;

namespace Toodaloo.Models {
	public class TodoContext : DbContext {
		public DbSet<Todo> Todos { get; set; }
	}
}