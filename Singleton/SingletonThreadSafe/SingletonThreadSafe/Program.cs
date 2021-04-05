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
            instance.Name = Task.CurrentId.ToString();
            Console.WriteLine("Running task id: " + Task.CurrentId.ToString());
        }

        static void Main(string[] args)
        {
            SafeSingleton instance1 = null;
            SafeSingleton instance2 = null;
            SafeSingleton instance3 = null;

            Task task1 = Task.Run(() => createSingleton(out instance1));

            Task task2 = Task.Run(() => createSingleton(out instance2));

            Task task3 = Task.Run(() => createSingleton(out instance3));

            task1.Wait();
            task2.Wait();
            task3.Wait();

            Console.WriteLine("Tasks run complete!");

            Console.WriteLine($"Number of created instances: {SafeSingleton.Instances}");

            instance1.DoWork();
            instance2.DoWork();
            instance3.DoWork();
        }
    }
}
