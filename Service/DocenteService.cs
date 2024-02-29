﻿using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models.D_Docente;
using Service.Contracts;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Service;

internal sealed class DocenteService : IDocenteService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;
    private readonly IMapper _mapper;

    public DocenteService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
    {
        _repository = repository;
        _logger = logger;
        _mapper = mapper;
    }

    public DocenteDto GetDocente(Guid id, bool trackChanges)
    {
        var docente = _repository.Docente.GetDocente(id, trackChanges);
        if (docente == null)
        {
            throw new DocenteNotFoundException(id);
        }
        return _mapper.Map<DocenteDto>(docente);
    }


    public DocenteDto CreateDocente(DocenteForCreationDto docente)
    {
        var docenteEntity = _mapper.Map<Docente>(docente);

        _repository.Docente.CreateDocente(docenteEntity);
        _repository.Save();

        var docenteToReturn = _mapper.Map<DocenteDto>(docenteEntity);

        return docenteToReturn;
    }

    public IEnumerable<DocenteDto> GetByIds(IEnumerable<Guid> ids, bool trackChanges)
    {
        if (ids is null)
            throw new IdParametersBadRequestException();

        var docenteEntities = _repository.Docente.GetByIds(ids, trackChanges);
        if (ids.Count() != docenteEntities.Count())
            throw new CollectionByIdsBadRequestException();

        var docentesToReturn = _mapper.Map<IEnumerable<DocenteDto>>(docenteEntities);

        return docentesToReturn;
    }

    public void DeleteDocente(Guid docenteId, bool trackChanges)
    {
        var docente = _repository.Docente.GetDocente(docenteId, trackChanges);
        if (docente is null)
        {
            throw new DocenteNotFoundException(docenteId);
        }

        _repository.Docente.DeleteDocente(docente);
        _repository.Save();
    }

    public void UpdateDocente(Guid docenteId, DocenteForUpdateDto docenteForUpdate, bool trackChanges)
    {
        var docenteEntity = _repository.Docente.GetDocente(docenteId, trackChanges);
        if (docenteEntity is null)
            throw new DocenteNotFoundException(docenteId);
        _mapper.Map(docenteForUpdate, docenteEntity);
        _repository.Save();
    }

    public (IEnumerable<DocenteDto> docente, string ids) CreateDocenteCollection(IEnumerable<DocenteForCreationDto> docenteCollection)
    {
        if (docenteCollection is null)
            throw new DocenteCollectionBadRequest();

        var docenteEntities = _mapper.Map<IEnumerable<Docente>>(docenteCollection);
        foreach (var docente in docenteEntities)
        {
            _repository.Docente.CreateDocente(docente);
        }

        _repository.Save();

        var docenteCollectionToReturn = _mapper.Map<IEnumerable<DocenteDto>>(docenteEntities);
        var ids = string.Join(",", docenteCollectionToReturn.Select(c => c.DocenteId));

        return (docentes: docenteCollectionToReturn, ids: ids);
    }

    public void AssignHorarioToDocente(Guid docenteId, Guid horarioId)
    {
        var docente = _repository.Docente.GetDocente(docenteId, trackChanges: false);
        if (docente is null)
            throw new DocenteNotFoundException(docenteId);

        // Asignar el horario al docente
        docente.Horario = _repository.Horario.GetHorario(horarioId, trackChanges: false);

        _repository.Save();
    }

    public void AssignAulaToDocente(Guid docenteId, Guid aulaId)
    {
        var docente = _repository.Docente.GetDocente(docenteId, trackChanges: false);
        if (docente is null)
            throw new DocenteNotFoundException(docenteId);

        // Asignar el aula al docente
        docente.Aula = _repository.Aula.GetAula(aulaId, trackChanges: false);

        _repository.Save();
    }

    public void AssignCursosToDocente(Guid docenteId, IEnumerable<Guid> cursoIds)
    {
        var docente = _repository.Docente.GetDocente(docenteId, trackChanges: false);
        if (docente is null)
            throw new DocenteNotFoundException(docenteId);

        // Asignar los cursos al docente
        var cursos = _repository.Curso.GetCursos(cursoIds, trackChanges: false).ToList();
        foreach (var curso in cursos)
        {
            docente.Cursos.Add(curso);
        }

        _repository.Save();
    }

    public void AssignMateriasToDocente(Guid docenteId, IEnumerable<Guid> materiaIds)
    {
        var docente = _repository.Docente.GetDocente(docenteId, trackChanges: false);
        if (docente is null)
            throw new DocenteNotFoundException(docenteId);

        // Asignar las materias al docente
        var materias = _repository.Materia.GetMaterias(materiaIds, trackChanges: false).ToList();
        foreach (var materia in materias)
        {
            docente.Materias.Add(materia);
        }

        _repository.Save();
    }

    public IEnumerable<DocenteDto> GetAllDocente(bool trackChanges)
    {
        var docentes = _repository.Docente.GetAllDocentes(trackChanges);
        return _mapper.Map<IEnumerable<DocenteDto>>(docentes);
    }


}