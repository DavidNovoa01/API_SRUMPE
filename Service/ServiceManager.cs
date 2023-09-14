using AutoMapper;
using Contracts;
using Entities.Models;
using Service.Contracts;

namespace Service;

public sealed class ServiceManager : IServiceManager
{
    private readonly Lazy<ICandidatoEstudianteService> _candidatoEstudianteService;
    private readonly Lazy<IEstudianteDocumentosService> _estudianteDocumentosService;
    private readonly Lazy<IAcudienteService> _acudienteService;
    private readonly Lazy<IDireccionAcudienteService> _direccionAcudienteService;
    private readonly Lazy<ITelefonoAcudienteService> _telefonoAcudienteService;
    private readonly Lazy<ICupoService> _cupoService;

    public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
    {
        _candidatoEstudianteService = new Lazy<ICandidatoEstudianteService>(() =>
            new CandidatoEstudianteService(repositoryManager, logger, mapper));

        _estudianteDocumentosService = new Lazy<IEstudianteDocumentosService>(() =>
            new EstudianteDocumentosService(repositoryManager, logger, mapper));

        _acudienteService = new Lazy<IAcudienteService>(() =>
            new AcudienteService(repositoryManager, logger, mapper));

        _direccionAcudienteService = new Lazy<IDireccionAcudienteService>(() =>
            new DireccionAcudienteService(repositoryManager, logger, mapper));

        _telefonoAcudienteService = new Lazy<ITelefonoAcudienteService>(() =>
            new TelefonoAcudienteService(repositoryManager, logger, mapper));

        _cupoService = new Lazy<ICupoService>(() =>
            new CupoService(repositoryManager, logger, mapper));

    }

    public ICandidatoEstudianteService CandidatoEstudianteService => _candidatoEstudianteService.Value;
    public IEstudianteDocumentosService EstudianteDocumentosService => _estudianteDocumentosService.Value;
    public IAcudienteService AcudienteService => _acudienteService.Value;
    public IDireccionAcudienteService DireccionAcudienteService => _direccionAcudienteService.Value;
    public ITelefonoAcudienteService TelefonoAcudienteService => _telefonoAcudienteService.Value;
    public ICupoService CupoService => _cupoService.Value;
}


