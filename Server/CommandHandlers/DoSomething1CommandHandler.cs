using System.Diagnostics;
using MediatR;
using Server.Commands;

namespace Server.CommandHandlers
{
    public class DoSomething1CommandHandler:IRequestHandler<DoSomething1Command>
    {
        public DoSomething1CommandHandler()
        {
            
        }

        public async Task Handle(DoSomething1Command request, CancellationToken cancellationToken)
        {
            string message = request.SomeProperty.ToUpper();

            Console.WriteLine(message);
           
            
        }
    }
}
