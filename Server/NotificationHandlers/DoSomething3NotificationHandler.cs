using MediatR;
using Server.Notifications;

namespace Server.NotificationHandlers
{
    public class DoSomething3NotificationHandler:INotificationHandler<DoSomethingNotification>
    {
        public DoSomething3NotificationHandler()
        {
            
        }
        public async Task Handle(DoSomethingNotification notification, CancellationToken cancellationToken)
        {
            await Task.Run(() =>
             {
                 string message = ToString() + "...." + notification.SomeProperty.ToUpper();

                 Console.WriteLine(message);

             });




            

            //throw new Exception("Some Error Message!");
        }
    }
}
