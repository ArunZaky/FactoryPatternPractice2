using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new ConcreteCreatorClient();

            Vehicle bike = client.GetVehicle("Bike");
            Vehicle auto = client.GetVehicle("Auto");
            Vehicle car = client.GetVehicle("Car");
            //Vehicle newDefault = client.GetVehicle("what");


            bike.printVehicle();
            auto.printVehicle();
            car.printVehicle();
            //newDefault.printVehicle();

            Console.WriteLine("Code ran successfully");
            Console.ReadKey();
        }
    }
}
