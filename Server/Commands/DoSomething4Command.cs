using FluentResults;
using MediatR;

namespace Server.Commands
{
    public class DoSomething4Command:IRequest<Result<string>>
    {
        public DoSomething4Command()
        {
            
        }
        public string SomeProperty { get; set; }
    }
}
