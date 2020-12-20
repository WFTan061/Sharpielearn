using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class HelperMethods
    {
        static void Main(String[] args)
        {
            String myValue = imagineThis();//some method
            Console.WriteLine(myValue);
            myValue = imagineThisParam("Yak Chin");
            Console.WriteLine(myValue);
        }

        private static String imagineThis()
        {
            return "hello guys";
        }
        private static String imagineThisParam(String test)
        {
            return "Hello guys! I'm " + test;
        }
    }
}
