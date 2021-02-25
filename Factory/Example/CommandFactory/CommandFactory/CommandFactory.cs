using CommandFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandFactory
{
    public class CommandFactory
    {
        private List<Tuple<string, ICommandFactory>> namedFactories =
         new List<Tuple<string, ICommandFactory>>();

        public CommandFactory()
        {
            foreach (var t in typeof(CommandFactory).Assembly.GetTypes())
            {
                if (typeof(ICommandFactory).IsAssignableFrom(t) && !t.IsInterface)
                {
                    namedFactories.Add(Tuple.Create(
                      t.Name.Replace("Factory", string.Empty), (ICommandFactory)Activator.CreateInstance(t)));
                }
            }
        }

        public ICommand CreateCommand()
        {
            Console.WriteLine("Available commands: ");
            for (var index = 0; index < namedFactories.Count; index++)
            {
                var tuple = namedFactories[index];
                Console.WriteLine($"{index}: {tuple.Item1}");
            }

            while (true)
            {
                string s;
                if ((s = Console.ReadLine()) != null
                    && int.TryParse(s, out int i) 
                    && i >= 0
                    && i < namedFactories.Count)
                {
                        return namedFactories[i].Item2.Create();
                }
            }
        }
    }
}
