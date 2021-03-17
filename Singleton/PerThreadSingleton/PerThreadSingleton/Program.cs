using System;
using System.Threading;
using System.Threading.Tasks;

namespace PerThreadSingleton
{
    public sealed class RequestHandler
    {
        private static ThreadLocal<RequestHandler> threadInstance
          = new ThreadLocal<RequestHandler>(
            () => new RequestHandler());

        public int Id;

        private RequestHandler()
        {
            Id = Thread.CurrentThread.ManagedThreadId;
        }

        public void Handle(string request)
        {
            Console.WriteLine($"Handling {request}");
        }

        public static RequestHandler Instance => threadInstance.Value;
    }

    public class Demo
    {
        public static void Main(string[] args)
        {
            var t1 = Task.Factory.StartNew(() =>
            {
                var requestHandler = RequestHandler.Instance;
                Console.WriteLine($"t1: " + requestHandler.Id);
                requestHandler.Handle("http://test.com");
            });
            var t2 = Task.Factory.StartNew(() =>
            {
                var requestHandler = RequestHandler.Instance;
                Console.WriteLine($"t2: " + requestHandler.Id);
                Console.WriteLine($"t2 again: " + requestHandler.Id);
                requestHandler.Handle("http://test2.com");
            });
            Task.WaitAll(t1, t2);
        }


    }
}