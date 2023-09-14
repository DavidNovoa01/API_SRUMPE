using Entities.Models;

namespace Contracts
{
    public interface IMatriculaRepository
    {
        IEnumerable<Matricula> GetAllMatriculas(bool trackChanges);
        Matricula GetMatricula(Guid matriculaId, bool trackChanges);
        void CreateMatricula(Matricula matricula);
        IEnumerable<Matricula> GetByIds(IEnumerable<Guid> ids, bool trackChanges);
        void DeleteMatricula(Matricula matricula);
    }
}
