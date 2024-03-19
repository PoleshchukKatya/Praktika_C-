using System;
namespace Task4
{
    public class EventPublisher
    {
        public delegate void MyEventHandler(object sender, EventArgs e);
        public event MyEventHandler MyEvent;

        public void TriggerEvent()
        {
            MyEvent?.Invoke(this, EventArgs.Empty);
        }
    }

    public class FirstObserver
    {
        public void FirstHandler(object sender, EventArgs e)
        {
            Console.WriteLine("Первый наблюдатель, реагирующий на событие.");
        }
    }

    public class SecondObserver
    {
        public void SecondHandler(object sender, EventArgs e)
        {
            Console.WriteLine("Второй наблюдатель, реагирующий на событие.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            EventPublisher publisher = new EventPublisher();
            FirstObserver firstObserver = new FirstObserver();
            SecondObserver secondObserver = new SecondObserver();

            publisher.MyEvent += firstObserver.FirstHandler;
            publisher.MyEvent += secondObserver.SecondHandler;

            publisher.TriggerEvent();

            publisher.MyEvent -= firstObserver.FirstHandler;

            publisher.TriggerEvent();
        }
    }
}