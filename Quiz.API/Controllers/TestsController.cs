using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Quiz.Application.UseCases.Commands;
using Quiz.Application.UseCases.Queries;

namespace Quiz.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public TestsController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPost]
        public async Task<IActionResult> CreateCatalog(AddQuestionCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCatalogs()
        {
            var result = await _mediator.Send(new GetAllTestQuery());
            return Ok(result);
        }
    }
}
