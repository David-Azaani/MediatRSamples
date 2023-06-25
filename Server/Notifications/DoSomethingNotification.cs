using MediatR;

namespace Server.Notifications
{
    public class DoSomethingNotification:INotification
    {
        public DoSomethingNotification()
        {
            
        }

        public string SomeProperty { get; set; }
    }
    
}
