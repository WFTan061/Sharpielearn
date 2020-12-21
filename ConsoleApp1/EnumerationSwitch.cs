using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class EnumerationSwitch
    {
        static void Main(string[] args) {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            String userValue = Console.ReadLine();
            LeegrChamps userChamp;
            if(Enum.TryParse<LeegrChamps>(userValue,true,out userChamp))
            {
                switch (userChamp)
                {
                    case LeegrChamps.Garen:
                        Console.WriteLine("Garen!");
                        break;
                    case LeegrChamps.Jax:
                        Console.WriteLine("Jax!");
                        break;
                    case LeegrChamps.Orianna:
                        Console.WriteLine("Orianna!");
                        break;
                    default:
                        Console.WriteLine("BLANK!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Does Not COmpute!");
            }

        }

    }
    enum LeegrChamps
    {
        Garen,
        Jax,
        Orianna
    }
}
