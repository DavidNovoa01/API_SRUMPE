﻿using Contracts;

namespace Repository;

public sealed class RepositoryManager : IRepositoryManager
{
	private readonly RepositoryContext _repositoryContext;
	private readonly Lazy<ICandidatoEstudianteRepository> _candidatoEstudianteRepository;
	private readonly Lazy<IEstudianteDocumentosRepository> _estudianteDocumentosRepository;
    private readonly Lazy<IAcudienteRepository> _acudientesRepository;
    private readonly Lazy<IDireccionAcudienteRepository> _direccionAcudienteRepository;
    private readonly Lazy<ITelefonoAcudienteRepository> _telefonoAcudienteRepository;
    private readonly Lazy<ICupoRepository> _cupoRepository;

    public RepositoryManager(RepositoryContext repositoryContext)
	{
		_repositoryContext = repositoryContext;
        _candidatoEstudianteRepository = new Lazy<ICandidatoEstudianteRepository>(() => new CandidatoEstudianteRepository(repositoryContext));
        _estudianteDocumentosRepository = new Lazy<IEstudianteDocumentosRepository>(() => new EstudianteDocumentosRepository(repositoryContext));
        _acudientesRepository = new Lazy<IAcudienteRepository>(() => new AcudienteRepository(repositoryContext));
        _direccionAcudienteRepository = new Lazy<IDireccionAcudienteRepository>(() => new DireccionAcudienteRepository(repositoryContext));
        _telefonoAcudienteRepository = new Lazy<ITelefonoAcudienteRepository>(() => new TelefonoAcudienteRepository(repositoryContext));
        _cupoRepository = new Lazy<ICupoRepository>(() => new CupoRepository(repositoryContext));

    }

    public ICandidatoEstudianteRepository CandidatoEstudiante => _candidatoEstudianteRepository.Value;

    public IEstudianteDocumentosRepository EstudianteDocumentos => _estudianteDocumentosRepository.Value;

    public IAcudienteRepository Acudiente => _acudientesRepository.Value;

    public IDireccionAcudienteRepository DireccionAcudiente => _direccionAcudienteRepository.Value;

    public ITelefonoAcudienteRepository TelefonoAcudiente => _telefonoAcudienteRepository.Value;

    public ICupoRepository Cupo => _cupoRepository.Value;

    public void Save() => _repositoryContext.SaveChanges();
}