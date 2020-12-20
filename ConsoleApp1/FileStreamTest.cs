using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class FileStreamTest
    {
        static void Main(String[] args)
        {
            StreamReader newReader = new StreamReader("Values.txt");
            String line = "";
            while (line != null)
            {
                line = newReader.ReadLine();
                if (line != null)
                {
                    Console.WriteLine(line);
                }
            }
            newReader.Close();
            Console.ReadLine();
        }
    }
}
