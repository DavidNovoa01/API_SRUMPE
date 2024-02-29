﻿using Contracts;
using Entities.Models.D_Acudiente;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

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
                .Include(a => a.CandidatoEstudiantes) // Incluir la relación con CandidatoEstudiante
                .OrderBy(c => c.Nombres)
                .ToList();

        public Acudiente GetAcudiente(Guid acudienteId, bool trackChanges) =>
            FindByCondition(c => c.AcudienteId.Equals(acudienteId), trackChanges)
            .Include(a => a.CandidatoEstudiantes) // Incluir la relación con CandidatoEstudiante
            .SingleOrDefault();

        public void CreateAcudiente(Acudiente acudiente) => Create(acudiente);

        public IEnumerable<Acudiente> GetByIds(IEnumerable<Guid> ids, bool trackChanges) =>
            FindByCondition(x => ids.Contains(x.AcudienteId), trackChanges)
            .Include(a => a.CandidatoEstudiantes) // Incluir la relación con CandidatoEstudiante
            .ToList();

        public void DeleteAcudiente(Acudiente acudiente) => Delete(acudiente);
    }
}

