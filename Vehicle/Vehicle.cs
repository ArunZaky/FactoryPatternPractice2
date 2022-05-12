using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public abstract class Vehicle
    {
        public abstract void printVehicle();
    }
    public class Bike : Vehicle
    {
        public override void printVehicle()
        {
            Console.WriteLine("I am a Two Wheeler");
        }
    }
    public class Auto : Vehicle
    {
        public override void printVehicle()
        {
            Console.WriteLine("I am a Three Wheeler");
        }
    }
    public class Car : Vehicle
    {
        public override void printVehicle()
        {
            Console.WriteLine("I am a Three Wheeler");
        }
    }
}
