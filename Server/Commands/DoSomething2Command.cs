using MediatR;

namespace Server.Commands
{

    // with response
    public class DoSomething2Command : IRequest<string>
    {


        public DoSomething2Command()
        {

        }
        public string SomeProperty { get; set; }

    }
}
