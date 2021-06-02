using System;
using System.Collections.Generic;
using System.Timers;
using System.Reactive.Linq;
namespace ObserverExample
{

    public class Event { }

    public class OpenDoorEvent : Event
    {
        public string Temperature { get; set; }
        public DateTime Time { get; set; }
    }

    public class Fridge : IObservable<Event>
    {
        private readonly HashSet<Subscription> subscriptions = new HashSet<Subscription>();

        private Timer _fridgeTimer;
        private const int OPEN_TIME = 3000;
        public float Temperature { get; set; }

        public Fridge()
        {
            _fridgeTimer = new Timer();
            _fridgeTimer.Interval = OPEN_TIME;
            _fridgeTimer.Enabled = false;
            _fridgeTimer.Elapsed += SendNotification;
            Temperature = 14.5f;
        }

        private void SendNotification(object sender, ElapsedEventArgs e) 
        {
            //simulate temperature increase while fridge door is open
            if (this.Temperature < 30.0f)
            {
                this.Temperature++;
            }

            foreach (var sub in subscriptions)
            {
                sub.Observer.OnNext(new OpenDoorEvent { Temperature = this.Temperature + "C", Time=e.SignalTime });
            }       
        }


        public IDisposable Subscribe(IObserver<Event> observer)
        {
            var subscription = new Subscription(this, observer);
            subscriptions.Add(subscription);
            return subscription;
        }

        public void OpenDoor()
        {
            _fridgeTimer.Enabled = true;
        }

        public void CloseDoor()
        {
            _fridgeTimer.Enabled = false;
        }

        private class Subscription : IDisposable
        {
            private Fridge fridge;
            public IObserver<Event> Observer;

            public Subscription(Fridge fridge, IObserver<Event> observer)
            {
                this.fridge = fridge;
                Observer = observer;
            }
            public void Dispose()
            {
                fridge.subscriptions.Remove(this);
            }
        }
    }

    public class Person : IObserver<Event>
    {
        public string Id { get; set; }
        public string Name { get; set; }

        private Fridge myFridge;

        public Person()
        {
            myFridge = new Fridge();
            var sub = myFridge.Subscribe(this);
            myFridge.OfType<OpenDoorEvent>().Subscribe(args => Console.WriteLine($"Notification sent... Temperature: {args.Temperature} at time: {args.Time}"));

        }

        public void OpenFridge()
        {
            myFridge.OpenDoor();
            Console.WriteLine("Fridge door has been opened!");
        }

        public void CloseFridge()
        {
            myFridge.CloseDoor();
            Console.WriteLine("Fridge door has been closed!");
        }

        public void OnCompleted()
        {           
        }

        public void OnError(Exception error)
        {
        }

        public void OnNext(Event value)
        {
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.OpenFridge();
            Console.ReadLine();
            person.CloseFridge();
            Console.ReadLine();
        }
    }
}
