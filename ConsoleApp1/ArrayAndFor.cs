using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ArrayAndFor
    {
        static void Main(String[] args){
            String[] messages = new String[5]; //Declaration of String array.
            messages[0] = "test1";
            messages[1] = "test2";
            messages[2] = "test3";
            messages[3] = "test4";
            messages[4] = "test5";

            int[] testArray = new int[] { 1, 2, 54, 7, 8 }; //instant declaration of array, like javascript like that?
            int finalNumber = 0;
            for (int i = 0; i < testArray.Length; i++)//iteration through the 2nd array.
            {
                finalNumber = finalNumber + testArray[i]; // add 3gether
                if (i == 3)
                {
                    break; // test break.
                }
            }
            Console.WriteLine(finalNumber); //should give 64 or smth liddat.
            foreach (string s in messages)
            {
                Console.WriteLine(s);
            }
            //reverse test 1/2/3/4/5, dont care about char.
            Array.Reverse(messages);
            foreach (string s in messages)
            {
                Console.WriteLine(s);
            }
        }
    }
}
