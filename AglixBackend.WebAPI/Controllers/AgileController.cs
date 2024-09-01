using AglixBackend.Application.Interfaces;
using AglixBackend.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AglixBackend.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AgileController : ControllerBase
    {
        private readonly IAgileService _agileService;

        public AgileController(IAgileService agileService)
        {
            _agileService = agileService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Agile>> GetById(int id)
        {
            var agile = await _agileService.GetByIdAsync(id);
            if (agile == null)
            {
                return NotFound();
            }
            return Ok(agile);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Agile>>> GetAll()
        {
            var agiles = await _agileService.GetAllAsync();
            return Ok(agiles);
        }

        [HttpPost]
        public async Task<ActionResult> Add(Agile agile)
        {
            await _agileService.AddAsync(agile);
            return CreatedAtAction(nameof(GetById), new { id = agile.Id }, agile);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, Agile agile)
        {
            if (id != agile.Id)
            {
                return BadRequest();
            }
            await _agileService.UpdateAsync(agile);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _agileService.DeleteAsync(id);
            return NoContent();
        }
    }
}
