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

            IVehicle bike = client.GetVehicle("Bike");
            IVehicle auto = client.GetVehicle("Auto");
            IVehicle car = client.GetVehicle("Car");
            IVehicle newDefault = client.GetVehicle("what");


            bike.printVehicle();
            auto.printVehicle();
            car.printVehicle();
            newDefault.printVehicle();

            Console.ReadKey();
        }
    }
}
