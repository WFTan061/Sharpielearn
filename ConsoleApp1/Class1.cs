using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class1
    {
        static void Main()
        {
            int x = 5;
            String y = "5";
            var result = x + int.Parse(y);
            Console.WriteLine("Result of x + y is " + result.ToString);
            Console.ReadLine();
        }
    }
}
