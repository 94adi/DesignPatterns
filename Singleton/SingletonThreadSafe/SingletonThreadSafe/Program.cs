using System;
using System.Threading;
using System.Threading.Tasks;

namespace SingletonThreadSafe
{

    public sealed class SafeSingleton
    {
        private SafeSingleton() { _id = Guid.NewGuid(); }
        public string Name { get; set; }
        public Guid Id { get { return _id; } }
        private static readonly object _padlock = new object();
        private static SafeSingleton _instance = null;
        private static int _instances;
        private Guid _id;
        public static int Instances { get { return _instances; } }
        public static SafeSingleton Instance
        {
            get
            {
                if(_instance == null)
                {
                    lock (_padlock)
                    {
                        if(_instance == null)
                        {
                            _instance = new SafeSingleton();
                            _instances++;
                        }
                    }
                }
                return _instance;
            }
        }
        public void DoWork()
        {
            Console.WriteLine($"Running singleton with id {Id}");
        }
    }


    class Program
    {

        static void createSingleton(out SafeSingleton instance)
        {
            instance = SafeSingleton.Instance;
            instance.Name = Thread.CurrentThread.ManagedThreadId.ToString();
            Console.WriteLine("Running thread id: " + Thread.CurrentThread.ManagedThreadId);
        }

        static void Main(string[] args)
        {
            SafeSingleton instance1 = null;
            SafeSingleton instance2 = null;
            SafeSingleton instance3 = null;

            Thread thread1 = new Thread(new ThreadStart(() => createSingleton(out instance1)));
            thread1.Start();

            Thread thread2 = new Thread(new ThreadStart(() => createSingleton(out instance2)));
            thread2.Start();

            Thread thread3 = new Thread(new ThreadStart(() => createSingleton(out instance3)));
            thread3.Start();


            thread1.Join();
            thread2.Join();
            thread3.Join();

            Console.WriteLine("Threads run complete!");

            Console.WriteLine($"Number of created instances: {SafeSingleton.Instances}");

            instance1.DoWork();
            instance2.DoWork();
            instance3.DoWork();
        }
    }
}
