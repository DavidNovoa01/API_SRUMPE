using API.Presentation.ModelBinders;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;

namespace API.Presentation.Controllers
{
    [Route("api/docente")]
    [ApiController]
    public class DocentesController : ControllerBase
    {
        private readonly IServiceManager _service;

        public DocentesController(IServiceManager service) => _service = service;

        [HttpGet]
        public IActionResult GetDocentes()
        {
            var docentes = _service.DocenteService.GetAllDocente(trackChanges: false);

            return Ok(docentes);
        }

        [HttpGet("{id:guid}", Name = "DocenteById")]
        public IActionResult GetDocente(Guid id)
        {
            var docente = _service.DocenteService.GetDocente(id, trackChanges: false);
            return Ok(docente);
        }

        [HttpGet("collection/({ids})", Name = "DocenteCollection")]
        public IActionResult GetDocenteCollection([ModelBinder(BinderType = typeof(ArrayModelBinder))] IEnumerable<Guid> ids)
        {
            var docentes = _service.DocenteService.GetByIds(ids, trackChanges: false);

            return Ok(docentes);
        }

        [HttpPost]
        public IActionResult CreateDocente([FromBody] DocenteForCreationDto docente)
        {
            if (docente is null)
                return BadRequest("DocenteForCreationDto object is null");

            var createdDocente = _service.DocenteService.CreateDocente(docente);

            return CreatedAtRoute("DocenteById", new { id = createdDocente.DocenteId }, createdDocente);
        }

        [HttpPost("collection")]
        public IActionResult CreateDocenteCollection([FromBody] IEnumerable<DocenteForCreationDto> docenteCollection)
        {
            var result = _service.DocenteService.CreateDocenteCollection(docenteCollection);

            return CreatedAtRoute("DocenteCollection", new { ids = result.ids }, result.docente);
        }

        [HttpDelete("{id:guid}")]
        public IActionResult DeleteDocente(Guid id)
        {
            _service.DocenteService.DeleteDocente(id, trackChanges: false);
            return NoContent();
        }

        [HttpPut("{id:guid}")]
        public IActionResult UpdateDocente(Guid id, [FromBody] DocenteForUpdateDto docente)
        {
            if (docente is null)
                return BadRequest("DocenteForUpdateDto object is null");
            _service.DocenteService.UpdateDocente(id, docente, trackChanges: true);
            return NoContent();
        }
    }
}

