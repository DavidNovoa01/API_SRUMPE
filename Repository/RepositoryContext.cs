using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Configuration;

namespace Repository;

public class RepositoryContext : DbContext
{
	public RepositoryContext(DbContextOptions options)
		: base(options)
	{
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.ApplyConfiguration(new CandidatoEstudianteConfiguration());
		modelBuilder.ApplyConfiguration(new EstudianteDocumentosConfiguration());
        modelBuilder.ApplyConfiguration(new AcudienteConfiguration());
        modelBuilder.ApplyConfiguration(new DireccionAcudienteConfiguration());
        modelBuilder.ApplyConfiguration(new TelefonoAcudienteConfiguration());
        modelBuilder.ApplyConfiguration(new CupoConfiguration());
        modelBuilder.ApplyConfiguration(new RespuestaCupoConfiguration());
        modelBuilder.ApplyConfiguration(new PreMatriculaConfiguration());
        modelBuilder.ApplyConfiguration(new MatriculaConfiguration());
    }

	public DbSet<CandidatoEstudiante>? CandidatoEstudiantes { get; set; }
	public DbSet<EstudianteDocumentos>? EstudianteDocumentos { get; set; }
    public DbSet<Acudiente>? Acudiente { get; set; }
}
