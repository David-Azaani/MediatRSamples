using FluentResults;
using MediatR;

namespace Server.Commands
{

    // return nothing - async - with FluentResults
    public class DoSomething3Command:IRequest<Result>
    {
        public DoSomething3Command()
        {
            
        }
          public string SomeProperty { get; set; }
    }
}
