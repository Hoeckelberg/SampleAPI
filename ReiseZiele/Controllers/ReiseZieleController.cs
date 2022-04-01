using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReiseZiele;
using ReiseZiele.Service;

namespace Reiseziele.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReiseZieleController : ControllerBase
    {
        private readonly ReiseZielService _reiseService;

        public ReiseZieleController(ReiseZielService reiseZielService)
        {
            _reiseService = reiseZielService;
        }
        [HttpGet]
        public IActionResult GetAllReiseZiele()
        {
            var result = _reiseService.GetAll();
            return Ok(result);
        }
        [HttpGet("{id}")]
        public IActionResult GetReiseZielById(int id)
        {
            var result = _reiseService.GetById(id);
            return Ok(result);
        }
        [HttpPost]
        public IActionResult PostReiseZiel(PostReiseZielDTO postReiseZielDTO)
        {
            var result = _reiseService.Create(postReiseZielDTO);
            return Ok(result);
        }
        [HttpPut("{id}")]
        public IActionResult UpdateReiseZiel(int id, UpdateReiseZielDTO updateReiseZielDTO)
        {
            var result = _reiseService.UpdateReiseZiel(id, updateReiseZielDTO);
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteReiseZiel(int id)
        {
            _reiseService.DeleteById(id);
            return NoContent();
        }
    }
}
