namespace EventsApp
{
    public delegate void Notify(string message);

    public class EventPublisher
    {
        public event Notify OnNotify; // "On" makes clear that the method is associated with an event. Its a special method that is called when a especific event occurs

        public void RaiseEvent(string message)
        {
            OnNotify?.Invoke(message); //Invokes the event if there are subscrivers to the event
        }

    }

    public class EventSubscriber
    {
        public void OnEventRaised(string message)
        {
            Console.WriteLine("Event received: "+ message);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            EventPublisher publisher = new EventPublisher();
            EventSubscriber subscriber = new EventSubscriber();
            publisher.OnNotify += subscriber.OnEventRaised; //we can subscrive those events and be notified when that happens

            publisher.RaiseEvent("Test");
        }
    }
}
