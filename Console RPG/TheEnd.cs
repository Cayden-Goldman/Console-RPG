using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Console_RPG
{
    class TheEnd : Event
    {
        public TheEnd(bool isResolved) : base(isResolved)
        {

        }

        public override void Resolve(List<Player> players)
        {
            Program.PrintLineSlow("You have made it...");
            Thread.Sleep(50);
            Program.PrintLineFast("Enter to continue.");
            Console.ReadLine();
            Console.Clear();
            Program.PrintLineSlow("You have killed the thing trapping us all here...");
            Thread.Sleep(50);
            Program.PrintLineFast("Enter to continue.");
            Console.ReadLine();
            Console.Clear();
            Program.PrintLineSlow("You are know freed from our burden...");
            Thread.Sleep(50);
            Program.PrintLineFast("Enter to continue.");
            Console.ReadLine();
            Console.Clear();
            Program.PrintLineSlow("Goodbye...");
            Thread.Sleep(50);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Program.PrintLineSlow("Sophie...");
            Thread.Sleep(50);
            Console.ForegroundColor = ConsoleColor.White;
            Program.PrintLineFast("Enter to continue.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Thank you for playing my short scuffed console RPG, Goobye!");
            System.Environment.Exit(0);
        }
    }
}
