using API.Presentation.ModelBinders;
using Entities.Models.D_Estudiante;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repository;
using Service.Contracts;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace API.Presentation.Controllers;

[Route("api/candidatoEstudiante")]
[ApiController]
public class CandidatoEstudiantesController : ControllerBase
{
    private readonly IServiceManager _service;
    private readonly RepositoryContext _context;

    public CandidatoEstudiantesController(IServiceManager service, RepositoryContext context)
    {
        _service = service;
        _context = context;
    }

    [HttpGet]
    public IActionResult GetCandidatoEstudiantes()
    {
        try
        {
            var candidatoEstudiantes = _service.CandidatoEstudianteService.GetAllCandidatoEstudiantes(trackChanges: false);
            return Ok(candidatoEstudiantes);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Error al obtener la lista de estudiantes: {ex.Message}");
        }
    }

    [HttpGet("{id:guid}", Name = "CandidatoEstudianteById")]
    public IActionResult GetCandidatoEstudiante(Guid id)
    {
        var candidatoEstudiante = _service.CandidatoEstudianteService.GetCandidatoEstudiante(id, trackChanges: false);
        return Ok(candidatoEstudiante);
    }

    [HttpPost]
    public IActionResult CreateCandidatoEstudiante([FromBody] CandidatoEstudianteForCreationDto candidatoEstudiante)
    {
        if (candidatoEstudiante is null)
            return BadRequest("CandidatoEstudianteForCreationDto object is null");

        var createdCandidatoEstudiante = _service.CandidatoEstudianteService.CreateCandidatoEstudiante(candidatoEstudiante);

        return CreatedAtRoute("CandidatoEstudianteById", new { id = createdCandidatoEstudiante.CandidatoEstudianteId }, createdCandidatoEstudiante);
    }

    [HttpDelete("{id:guid}")]
    public IActionResult DeleteCandidatoEstudiante(Guid id)
    {
        _service.CandidatoEstudianteService.DeleteCandidatoEstudiante(id, trackChanges: false);
        return NoContent();
    }

    [HttpPut("{id:guid}")]
    public IActionResult UpdateCandidatoEstudiante(Guid id, [FromBody] CandidatoEstudianteForUpdateDto candidatoEstudiante)
    {
        if (candidatoEstudiante is null)
            return BadRequest("CandidatoEstudianteUpdateDto object is null");
        _service.CandidatoEstudianteService.UpdateCandidatoEstudiante(id, candidatoEstudiante, trackChanges: true);
        return NoContent();
    }

    [HttpPost("acudiente")]
    public async Task<ActionResult<CandidatoEstudiante>> PostCandidatoEstudiante(CandidatoEstudiante candidatoEstudiante)
    {
        var acudiente = await _context.Acudientes.FirstOrDefaultAsync(a => a.NumeroIdentificacion == candidatoEstudiante.NumeroIdentificacionAcudiente);

        if (acudiente != null)
        {
            candidatoEstudiante.Acudientes.Add(acudiente);
            _context.CandidatoEstudiantes.Add(candidatoEstudiante);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetCandidatoEstudiante", new { id = candidatoEstudiante.CandidatoEstudianteId }, candidatoEstudiante);
        }
        else
        {
            return BadRequest("No se encontró el acudiente con el número de identificación proporcionado.");
        }
    }


}
