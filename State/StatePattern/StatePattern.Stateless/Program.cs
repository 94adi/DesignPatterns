using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Stateless;
using static System.Console;

namespace StatePattern.Stateless
{
    public enum Health
    {
        NonReproductive,
        Reproductive
    }

    public enum Activity
    {
        ReachPuberty,
        Historectomy
    }

    class Demo
    {
        static void Main(string[] args)
        {
            var stateMachine = new StateMachine<Health, Activity>(Health.NonReproductive);
            stateMachine.Configure(Health.NonReproductive)
              .Permit(Activity.ReachPuberty, Health.Reproductive);
            stateMachine.Configure(Health.Reproductive)
              .Permit(Activity.Historectomy, Health.NonReproductive);

            stateMachine.Activate();
            Console.WriteLine(stateMachine.State);
            Console.WriteLine("Reach puberty");
            stateMachine.Fire(Activity.ReachPuberty);
            Console.WriteLine(stateMachine.State);


        }
    }
}
