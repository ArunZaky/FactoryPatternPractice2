using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public abstract class Client
    {
        public abstract Vehicle GetVehicle(string VehicleType);
    }
    public class ConcreteCreatorClient : Client
    {
        public override Vehicle GetVehicle(string VehicleType)
        {
            switch (VehicleType.ToLower())
            {
                case ("bike"):
                    return new Bike();
                    
                case "auto":
                    return new Auto();
                    
                case "car":
                    return new Car();
                    
                default:
                    throw new ApplicationException(string.Format("Unable to create the object for {0}", VehicleType));
            }

        }

    }
}
