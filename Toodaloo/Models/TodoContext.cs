using System.Data.Entity;

namespace Toodaloo.Models {
	public class TodoContext : DbContext {
		public DbSet<Todo> Todos { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder) {
			modelBuilder.Entity<Todo>().ToTable("Todo");
			base.OnModelCreating(modelBuilder);
		}
	}
}