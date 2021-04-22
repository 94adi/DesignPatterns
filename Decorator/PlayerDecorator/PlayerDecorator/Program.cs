using System;

namespace PlayerDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Player newPlayer = new BasePlayer();
            Player sniperPlayer = new SniperPlayer(newPlayer);
            Player scoutPlayer = new ScoutPlayer(sniperPlayer);
            EngineerPlayer engineer = new EngineerPlayer(scoutPlayer);

            newPlayer.Attack();
            newPlayer.Run();
            newPlayer.ShowHP();
            engineer.Build();
        }
    }
}
