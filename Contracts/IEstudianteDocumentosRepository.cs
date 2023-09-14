using Entities.Models;

namespace Contracts;

public interface IEstudianteDocumentosRepository
{
    IEnumerable<EstudianteDocumentos> GetAllEstudianteDocumentos(bool trackChanges);
    EstudianteDocumentos GetEstudianteDocumentos(Guid estudianteDocumentoId, bool trackChanges);
    void CreateEstudianteDocumentos(EstudianteDocumentos estudianteDocumento);
    IEnumerable<EstudianteDocumentos> GetByIds(IEnumerable<Guid> ids, bool trackChanges);
    void DeleteEstudianteDocumentos(EstudianteDocumentos estudianteDocumento);
}

