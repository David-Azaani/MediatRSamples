using FluentResults;
using MediatR;
using Server.Commands;

namespace Server.CommandHandlers
{
    public class DoSomething4CommandHandler : IRequestHandler<DoSomething4Command, Result<string>>
    {
        public DoSomething4CommandHandler()
        {

        }
        public async Task<Result<string>> Handle(DoSomething4Command request, CancellationToken cancellationToken)
        {
            string resValue = String.Empty;
            try
            {
                await Task.Run(() =>
                {


                    //Assuming There are no Errors

                    resValue = request.SomeProperty.ToUpper();
                    Console.WriteLine(resValue);


                });

                return Result.Ok(resValue)
                          .WithSuccess("Success 1")
                          .WithSuccess("Success 2")
                          ;

                //return Result.Fail(new Error("Error"));

                //return Result.Fail("error message 1")
                //    .WithError("error message 2")
                //    .WithError("error message 3")
                //    .WithSuccess("success message 1");




            }
            catch (Exception e)
            {
                //Log Error

                return Result.Fail(new Error("Exception").CausedBy(e.Message));

            }


        }
    }
}
