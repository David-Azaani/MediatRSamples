using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Server.Infrastructure
{
    public class Controller1Base : ControllerBase
    {
        protected readonly IMediator _mediator;
        protected readonly ILogger _logger;

        public Controller1Base(IMediator mediator , ILogger logger)
        {
            _mediator = mediator;
            _logger = logger;
        }
    }
}
