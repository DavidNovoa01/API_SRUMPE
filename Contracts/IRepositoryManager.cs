namespace Contracts;

public interface IRepositoryManager
{
	ICandidatoEstudianteRepository CandidatoEstudiante { get; }
	IEstudianteDocumentosRepository EstudianteDocumentos { get; }
    IAcudienteRepository Acudiente { get; }
    IDireccionAcudienteRepository DireccionAcudiente { get; }
    ITelefonoAcudienteRepository TelefonoAcudiente { get; }
    ICupoRepository Cupo { get; }
    IRespuestaCupoRepository RespuestaCupo { get; }
    IPreMatriculaRepository PreMatricula { get; }
    IMatriculaRepository Matricula { get; }
    void Save();
}
