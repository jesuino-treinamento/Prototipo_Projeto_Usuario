using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProjetoUsuario.Data.Mapping;
using ProjetoUsuario.Models.Entities;

namespace ProjetoUsuario.Data
{
    public class ApplicationContext : DbContext
	{
		private readonly ILogger<ApplicationContext> _logger;


		public DbSet<Usuario> Usuarios { get; set; }

		public ApplicationContext(DbContextOptions<ApplicationContext> options, ILogger<ApplicationContext> logger)
			: base(options)
		{
			_logger = logger;
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			_logger.Log(LogLevel.Information, "OnModelCreating...");
			modelBuilder.ApplyConfiguration(new UsuarioConfig());
		}
	}
}
