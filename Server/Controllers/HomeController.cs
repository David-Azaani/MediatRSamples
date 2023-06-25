using Microsoft.AspNetCore.Mvc;
using Server.Models;
using System.Diagnostics;
using MediatR;
using Server.Commands;

namespace Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMediator _mediator;

        public HomeController(ILogger<HomeController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet]
        public IActionResult Get()
        {
            string message = "Hello World !";

            return Ok(message);
        }

        [HttpGet(template: "test1")]
        public IActionResult Test1()
        {
            var command1 = new DoSomething1Command() { SomeProperty = "Command 1" };
            _mediator.Send(command1);

            return Ok(value: "Ok");

        }
        [HttpGet(template: "test2")]
        public async Task<IActionResult> Test2()
        {
            var command2 = new DoSomething2Command() { SomeProperty = "Command 2" };
            var res = await _mediator.Send<string>(command2);

            return Ok(value: res);

        }


    }
}