using FluentResults;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using Server.Commands;
using Server.Infrastructure;
using Server.Notifications;

namespace Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller1Base
    {
        // private readonly ILogger<HomeController> _logger;
        //  private readonly IMediator _mediator;

        public HomeController(ILogger<HomeController> logger, IMediator mediator) : base(mediator, logger)
        {
            //_logger = logger;
            // _mediator = mediator;
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
            var command1 = new DoSomething1Command { SomeProperty = "Command 1" };
            _mediator.Send(command1);
            //_logger.LogInformation("");

            return Ok(value: "Ok");

        }
        [HttpGet(template: "test2")]
        public async Task<IActionResult> Test2()
        {
            var command2 = new DoSomething2Command { SomeProperty = "Command 2" };
            var res = await _mediator.Send<string>(command2);

            return Ok(value: res);

        }
        [HttpGet(template: "test3")]
        public async Task<IActionResult> Test3()
        {
            var command3 = new DoSomething3Command { SomeProperty = "Command 3" };
            var res = await _mediator.Send(command3);

            if (res.IsSuccess)
            {
                return Ok(value: res);
            }
            else
            {
                return BadRequest(error: res);
            }



        }
        [HttpGet(template: "test4")]
        public async Task<IActionResult> Test4()
        {
            var command4 = new DoSomething4Command { SomeProperty = "Command 4" };
            Result<string> res = await _mediator.Send(command4);

            if (res.IsSuccess)
            {
                return Ok(value: res);
            }
            else
            {
                // if we use generic result we have to use .ToResult() in BadRequest.otherwise we have got Exception!
                return BadRequest(error: res.ToResult());
            }



        }
        [HttpGet(template: "test5")]
        public async Task<IActionResult> Test5()
        {

            try
            {
                var notification = new DoSomethingNotification { SomeProperty = "Notification" };



                //await _mediator.Publish<DoSomethingNotification>(notification);
                await _mediator.Publish(notification);

                return Ok(value: "Done!");


            }
            catch (Exception e)
            {
                return BadRequest(error: e.Message);
            }




        }


    }
}