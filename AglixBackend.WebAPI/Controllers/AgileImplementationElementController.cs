using AglixBackend.Application.Interfaces;
using AglixBackend.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AglixBackend.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AgileImplementationElementController : ControllerBase
    {
        private readonly IAgileImplementationElementService _service;

        public AgileImplementationElementController(IAgileImplementationElementService service)
        {
            _service = service;
        }

        // GET: api/AgileImplementationElement/implementation/{implementationId}
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AgileImplementationElement>>> GetAllByImplementationId()
        {
            var elements = await _service.GetAllAsync();
            return Ok(elements);
        }

        // GET: api/AgileImplementationElement/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<AgileImplementationElement>> GetById(int id)
        {
            var element = await _service.GetByIdAsync(id);
            if (element == null)
            {
                return NotFound();
            }
            return Ok(element);
        }

        // POST: api/AgileImplementationElement
        [HttpPost]
        public async Task<ActionResult> Add(AgileImplementationElement element)
        {
            await _service.AddAsync(element);
            return CreatedAtAction(nameof(GetById), new { id = element.Id }, element);
        }

        // PUT: api/AgileImplementationElement/{id}
        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, AgileImplementationElement element)
        {
            if (id != element.Id)
            {
                return BadRequest();
            }

            await _service.UpdateAsync(element);
            return NoContent();
        }

        // DELETE: api/AgileImplementationElement/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return NoContent();
        }
    }
}
