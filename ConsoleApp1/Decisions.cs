using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1

{
    class Decisions
    {
        static void Main(String[] args)
        {
            String userValue = "test";
            String message = "";
            if (userValue == "test")
            {
                message = "haha test correct";
            }
            else
            {
                message = "test wrong!";
            }
            Console.WriteLine(message);
            message = (userValue == "test") ? "Testing correct using True false declaration" : "wrong test for some reaswon?"; // Instant declaration based on condition
            Console.WriteLine("Message written with value replacement: {0}. \n Message with additional stupid stuff: {1}", message, message + "test"); //Value replacement test
            Console.ReadLine();
        }
    }
}
