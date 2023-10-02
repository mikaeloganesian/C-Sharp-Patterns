using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeated_Prog
{
    class Eternal_Cycle
    {
        public static void Eternal_Without_Exit()
        {
            while (true)
            {
                Console.WriteLine("This is eternal cycle. Press any button to restart.");
                Console.ReadKey();
            }
        }

        public static void Eternal_With_Exit()
        {
            while (true) {
                Console.WriteLine("\nChoose command: Exit/Continue:");
                string? command = Console.ReadLine();
                if (command == "Exit")
                {
                    return;
                }
                if (command == "Continue")
                {
                    Console.WriteLine("This is eternal cycle. Place your program here. Press any button to restart.");
                    Console.ReadKey();
                }
                else 
                {
                    Console.WriteLine("Unknown command."); 
                }
            }
        }
    }
}
