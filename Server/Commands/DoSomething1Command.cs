using MediatR;

namespace Server.Commands
{
    //... Command - Sync - WithoutResult

    public class DoSomething1Command:IRequest
    {
        public DoSomething1Command()
        {
            
        }

        public string  SomeProperty { get; set; }
    }
}
