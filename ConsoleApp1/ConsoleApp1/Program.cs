using System;

namespace bossfights {
    class Program {
        static void Main(string[] args) {
            Console.Title = "贪玩蓝月";
            Console.WriteLine("来将通名");
            string name = Console.ReadLine();
            Player player = new Player(name);
            Fight fight = new Fight(1, player);
            fight.Turn();
            Console.ReadKey();
        }
    }
}
