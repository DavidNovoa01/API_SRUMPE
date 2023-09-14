using Entities.Models;

namespace Contracts;

public interface ICandidatoEstudianteRepository
{
    IEnumerable<CandidatoEstudiante> GetAllCandidatoEstudiantes(bool trackChanges);
    CandidatoEstudiante GetCandidatoEstudiante(Guid candidatoEstudianteId, bool trackChanges);
    void CreateCandidatoEstudiante(CandidatoEstudiante candidatoestudiante);
    IEnumerable<CandidatoEstudiante> GetByIds(IEnumerable<Guid> ids, bool trackChanges);
    void DeleteCandidatoEstudiante(CandidatoEstudiante candidatoEstudiante);
}

