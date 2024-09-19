using AglixBackend.Application.Interfaces;
using AglixBackend.Application.Services;
using AglixBackend.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AglixBackend.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AgileImplementationController : ControllerBase
    {
        private readonly IAgileImplementationService _service;

        public AgileImplementationController(IAgileImplementationService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AgileImplementation>>> GetAll()
        {
            var implementations = await _service.GetAllAsync();
            return Ok(implementations);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AgileImplementation>> GetById(int id)
        {
            var implementation = await _service.GetByIdAsync(id);
            if (implementation == null)
            {
                return NotFound();
            }
            return Ok(implementation);
        }

        [HttpPost]
        public async Task<ActionResult> Add(AgileImplementation agileImplementation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _service.AddAsync(agileImplementation);
            return CreatedAtAction(nameof(GetById), new { id = agileImplementation.Id }, agileImplementation);
        }


        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, AgileImplementation agileImplementation)
        {
            if (id != agileImplementation.Id)
            {
                return BadRequest();
            }
            await _service.UpdateAsync(agileImplementation);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return NoContent();
        }
    }
}
