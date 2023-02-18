using Microsoft.EntityFrameworkCore;

namespace web_backend.Models
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			string connectionString = "Server=DESKTOP-4I4ITV7;Database=web_backend;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True";
			optionsBuilder.UseSqlServer(connectionString);
		}
		public DbSet<Veiculo> Veiculos { get; set; }
	}
}
