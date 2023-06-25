using FluentResults;
using MediatR;
using Server.Commands;

namespace Server.CommandHandlers
{
    public class DoSomething3CommandHandler : IRequestHandler<DoSomething3Command, Result>
    {
        public DoSomething3CommandHandler()
        {

        }
        public async Task<Result> Handle(DoSomething3Command request, CancellationToken cancellationToken)
        {
            var result = new Result();
            try
            {
                await Task.Run(() =>
                {

                    result.WithError("Error 1");
                    result.WithError("Error 2");

                    // Assuming There are no Errors

                    //string value = request.SomeProperty.ToUpper();
                    //result.WithSuccess("Success 1");
                    //result.WithSuccess("Success 2");

                    //Console.WriteLine(value);


                });



            }
            catch (Exception e)
            {
                //Log Error

                result.WithError(e.Message);
            }

            return result;
        }
    }
}
