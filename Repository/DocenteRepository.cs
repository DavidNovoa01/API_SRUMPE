using Contracts;
using Entities.Models.D_Docente;

namespace Repository
{
    internal sealed class DocenteRepository : RepositoryBase<Docente>, IDocenteRepository
    {
        public DocenteRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public IEnumerable<Docente> GetAllDocentes(bool trackChanges) =>
            FindAll(trackChanges)
                .OrderBy(c => c.Nombre)
                .ToList();

        public Docente GetDocente(Guid docenteId, bool trackChanges) =>
            FindByCondition(c => c.DocenteId.Equals(docenteId), trackChanges)
                .SingleOrDefault();

        public void CreateDocente(Docente docente) => Create(docente);

        public IEnumerable<Docente> GetByIds(IEnumerable<Guid> ids, bool trackChanges) =>
            FindByCondition(x => ids.Contains(x.DocenteId), trackChanges)
                .ToList();

        public void DeleteDocente(Docente docente) => Delete(docente);
    }
}
