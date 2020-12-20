using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class DateTimePlay
    {
        static void Main(String[] args){
            DateTime myValue = DateTime.Now;
            Console.WriteLine(myValue.ToString()); //Read full?
            Console.WriteLine(myValue.ToShortDateString()); //Read date.
            Console.WriteLine(myValue.ToLongTimeString()); //Read time
            Console.WriteLine(myValue.AddDays(3)); //add 3 days
            Console.WriteLine(myValue.AddDays(-3));//Testing minus 3 days.
            Console.WriteLine(myValue.AddMonths(3));//add 3 months
            Console.WriteLine(myValue.AddHours(5).ToLongTimeString()); //add 5 hours showing time.
            DateTime myBirthday = new DateTime(1992, 1, 15);//init my birthday.
            Console.WriteLine("My Birthday is: ", myBirthday);
            TimeSpan theAge = DateTime.Now.Subtract(myBirthday);//init the amount of miliseconds(?) for my age.
            Console.WriteLine(theAge.TotalDays);//number of days old i am.
     }
    }
}
