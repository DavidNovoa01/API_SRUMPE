using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    internal sealed class AcudienteRepository : RepositoryBase<Acudiente>, IAcudienteRepository
    {
        public AcudienteRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public IEnumerable<Acudiente> GetAllAcudientes(bool trackChanges) =>
            FindAll(trackChanges)
                .OrderBy(c => c.Nombres)
                .ToList();

        public Acudiente GetAcudiente(Guid acudienteId, bool trackChanges) =>
            FindByCondition(c => c.AcudienteId.Equals(acudienteId), trackChanges)
            .SingleOrDefault();

        public void CreateAcudiente(Acudiente acudiente) => Create(acudiente);

        public IEnumerable<Acudiente> GetByIds(IEnumerable<Guid> ids, bool trackChanges) =>
            FindByCondition(x => ids.Contains(x.AcudienteId), trackChanges)
            .ToList();

        public void DeleteAcudiente(Acudiente acudiente) => Delete(acudiente);
    }
}

