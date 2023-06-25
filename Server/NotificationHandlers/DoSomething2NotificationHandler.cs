using MediatR;
using Server.Notifications;

namespace Server.NotificationHandlers
{
    public class DoSomething2NotificationHandler:INotificationHandler<DoSomethingNotification>
    {
        public DoSomething2NotificationHandler()
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
