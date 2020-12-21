using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class1
    {
        static void Main()
        {
            Car newCar = new Car();
            Car otherCar = newCar;
            newCar.make = "Toyota";
            newCar.model = "Vios";
            newCar.year = 2019;
            newCar.color = "white";
            Car secondCar = new Car("Nissan", "Sunny", 2009, "black");

            otherCar.writeString();//same as first new car
            Console.WriteLine("{0} - {1} - {2} - {3}", newCar.make, newCar.model, newCar.year, newCar.color);
            Console.WriteLine("Car's worth : {0:C}", newCar.determineMarketValue());
            secondCar.writeString();
            newCar = null;
            otherCar.writeString();//Should exception.
            Console.WriteLine("Break");
            Truck truck = new Truck();
            truck.make = "Toyota";
            truck.model = "Truck";
            truck.year = 2019;
            truck.color = "Blue";
            truck.towingLine = 12500;
            truck.writeString();

        }
        public static double determineMarketValue(Car car)
        {
            double carValue = 100.0;
            if (car.year > 1999)
            {
                carValue = 10000.0;
            }
            else
            {
                carValue = 2000.0;
            }
            return carValue;
        }

    }

    abstract class Vehicle{
        public string make { get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public string color { get; set; }
        public abstract void writeString();
    }

    class Car : Vehicle
    {
        public double determineMarketValue()
        {
            double carValue = 100.0;
            if (this.year > 1999)
            {
                carValue = 10000.0;
            }
            else
            {
                carValue = 2000.0;
            }
            return carValue;
        }
        public Car()//similar to java normal
        {
            this.make = "Nissan";
        }
        public Car(String make, String model, int year, String color) {//similar to java normal
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }
        public override void writeString()
        {
            Console.WriteLine("{0} - {1} - {2} - {3}", this.make, this.model, this.year, this.color);
        }
    }
    class Truck : Car //truck inherits car!
    {
        public int towingLine { get; set; }
        public override void writeString()
        {
            Console.WriteLine("{0} - {1} - {2} - {3} - {4}", this.make, this.model, this.year, this.color,this.towingLine);
        }
    }
}