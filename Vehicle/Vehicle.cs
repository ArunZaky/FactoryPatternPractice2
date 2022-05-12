using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public interface IVehicle
    {
        void printVehicle();
    }
    public class Bike : IVehicle
    {
        public void printVehicle()
        {
            Console.WriteLine("I am a Two Wheeler");
        }
    }
    public class Auto : IVehicle
    {
        public void printVehicle()
        {
            Console.WriteLine("I am a Three Wheeler");
        }
    }
    public class Car : IVehicle
    {
        public void printVehicle()
        {
            Console.WriteLine("I am a Three Wheeler");
        }
    }
}
