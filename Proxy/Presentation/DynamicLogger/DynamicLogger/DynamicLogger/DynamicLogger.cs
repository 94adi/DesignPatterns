using ImpromptuInterface;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicLogger
{
    public class DynamicLogger<T> : DynamicObject where T : class, new()
    {
        private readonly T subject;
        private Dictionary<string, int> methodCallCount =
            new Dictionary<string, int>();

        protected DynamicLogger(T subject)
        {
            this.subject = subject ?? throw new ArgumentNullException(paramName: nameof(subject));
        }

        public static I As<I>(T subject) where I : class
        {
            if (!typeof(I).IsInterface)
                throw new ArgumentException("I must be an interface type");

            return new DynamicLogger<T>(subject).ActLike<I>();
        }

        public static I As<I>() where I : class
        {
            if (!typeof(I).IsInterface)
                throw new ArgumentException("I must be an interface type");

            return new DynamicLogger<T>(new T()).ActLike<I>();
        }

        public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
        {
            try
            {
                Console.WriteLine($"Invoking {subject.GetType().Name}.{binder.Name} with arguments [{string.Join(",", args)}]");
                
                if (methodCallCount.ContainsKey(binder.Name)) methodCallCount[binder.Name]++;
                else methodCallCount.Add(binder.Name, 1);

                result = subject.GetType().GetMethod(binder.Name).Invoke(subject, args);
                return true;
            }
            catch
            {
                result = null;
                return false;
            }
        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            try
            {
                result = subject.GetType().GetProperty(binder.Name).GetValue(subject, null);
                Console.WriteLine($"Getting value from property: {subject.GetType().Name}.{binder.Name} = {result}");
                return true;
            }
            catch
            {
                result = null;
                return false;
            }

        }

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            subject.GetType().GetProperty(binder.Name).SetValue(subject, value);
            Console.WriteLine($"Setting value for property: {subject.GetType().Name}.{binder.Name} = {value}");
            return true;
        }

        public string Info
        {
            get
            {
                var sb = new StringBuilder();
                foreach (var kv in methodCallCount)
                    sb.AppendLine($"{kv.Key} called {kv.Value} time(s)");
                return sb.ToString();
            }
        }

        public override string ToString()
        {
            return $"{Info}{subject}";
        }
    }
}
