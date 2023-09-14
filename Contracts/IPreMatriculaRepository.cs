using Entities.Models;

namespace Contracts
{
    public interface IPreMatriculaRepository
    {
        IEnumerable<PreMatricula> GetAllPreMatriculas(bool trackChanges);
        PreMatricula GetPreMatricula(Guid preMatriculaId, bool trackChanges);
        void CreatePreMatricula(PreMatricula preMatricula);
        IEnumerable<PreMatricula> GetByIds(IEnumerable<Guid> ids, bool trackChanges);
        void DeletePreMatricula(PreMatricula preMatricula);
    }
}
