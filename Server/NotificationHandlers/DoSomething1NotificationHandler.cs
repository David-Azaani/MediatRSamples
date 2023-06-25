using MediatR;
using Server.Notifications;

namespace Server.NotificationHandlers
{
    public class DoSomething1NotificationHandler : INotificationHandler<DoSomethingNotification>
    {
        public DoSomething1NotificationHandler()
        {

        }



        public async Task Handle(DoSomethingNotification notification, CancellationToken cancellationToken)
        {
            await Task.Run(() =>
            {
                string message = ToString() + "...." + notification.SomeProperty.ToUpper();

                Console.WriteLine(message);

            });
        }
    }
}
