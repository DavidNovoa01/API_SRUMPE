using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;

namespace Service.Contracts
{
    public interface IDocenteService
    {
        IEnumerable<DocenteDto> GetAllDocente(bool trackChanges);
        DocenteDto GetDocente(Guid docenteId, bool trackChanges);
        DocenteDto CreateDocente(DocenteForCreationDto docente);
        IEnumerable<DocenteDto> GetByIds(IEnumerable<Guid> ids, bool trackChanges);
        (IEnumerable<DocenteDto> docente, string ids) CreateDocenteCollection(IEnumerable<DocenteForCreationDto> docenteCollection);
        void DeleteDocente(Guid docenteId, bool trackChanges);
        void UpdateDocente(Guid docenteId, DocenteForUpdateDto docenteForUpdate, bool trackChanges);
    }
}

