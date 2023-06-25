using MediatR;
using Server.Commands;

namespace Server.CommandHandlers
{
    public class DoSomething2CommandHandler:IRequestHandler<DoSomething2Command,string>
    {
        public DoSomething2CommandHandler()
        {
            
        }
        public async Task<string> Handle(DoSomething2Command request, CancellationToken cancellationToken)
        {
            string result = string.Empty;
            await Task.Run(() =>
            {
                 result = request.SomeProperty.ToUpper();

                Console.WriteLine(result);
            });
            return result;
        }
    }
}
