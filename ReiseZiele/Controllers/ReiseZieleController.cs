using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReiseZiele;

namespace Reiseziele.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReiseZieleController : ControllerBase
    {
        //private readonly ReiseZielService reiseService;
        //private readonly DataContext context;

        //public ReiseZieleController(ReiseZielService reiseService, DataContext context)
        //{
        //    this.reiseService = reiseService;
        //    this.context = context;
        //}
        //[HttpGet]
        //public IActionResult GetAllReiseZiele()
        //{
        //    var result = reiseService.GetAllReiseZiele();
        //    return Ok(result);
        //}
        //[HttpGet("{id}")]
        //public IActionResult GetReiseZielById(int id)
        //{
        //    var result = reiseService.GetReiseZiel(id);
        //    return Ok(result);
        //}
        //[HttpPost]
        //public IActionResult PostReiseZiel(PostReiseZielDTO postReiseZielDTO)
        //{
        //    var result = reiseService.CreateReiseZiel(postReiseZielDTO);
        //    return Ok(result);
        //}
        //[HttpPut("{id}")]
        //public IActionResult UpdateReiseZiel(int id, UpdateReiseZielDTO updateReiseZielDTO)
        //{
        //    var result = reiseService.UpdateReiseZiel(id, updateReiseZielDTO);
        //    return Ok(result);
        //}
        //[HttpDelete("{id}")]
        //public IActionResult DeleteReiseZiel(int id)
        //{
        //    reiseService.DeleteReiseZiel(id);
        //    return NoContent();
        //}
    }
}
