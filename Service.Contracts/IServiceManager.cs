namespace Service.Contracts;

public interface IServiceManager
{
	ICandidatoEstudianteService CandidatoEstudianteService { get; }
    IEstudianteDocumentosService EstudianteDocumentosService { get; }
    IAcudienteService AcudienteService { get; }
    IDireccionAcudienteService DireccionAcudienteService { get; }
    ITelefonoAcudienteService TelefonoAcudienteService { get; }
    ICupoService CupoService { get; }
}

