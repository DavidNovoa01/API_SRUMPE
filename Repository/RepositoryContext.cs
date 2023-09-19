using Entities.Models;
using Entities.Models.D_Acudiente;
using Entities.Models.D_Estudiante;
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
    public DbSet<DireccionAcudiente>? DireccionAcudiente { get; set; }
    public DbSet<TelefonoAcudiente>? TelefonoAcudiente { get; set; }
    public DbSet<Cupo>? Cupo { get; set; }
    public DbSet<RespuestaCupo>? RespuestaCupo { get; set; }
    public DbSet<PreMatricula>? PreMatricula { get; set; }
    public DbSet<Matricula>? Matricula { get; set; }

}
