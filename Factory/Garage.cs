using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class Garage
    {
        //This represents the factory which desides which instance is to be created
        public ICar GetCar(CarType carType)
        {
            switch (carType)
            {
                case CarType.BMWM3:
                    return new BMWM3();
                case CarType.MercedesSClass:
                    return new MercedesSClass();
                case CarType.AudiR8:
                    return new AudiR8();
                default:
                    Console.WriteLine("Purchase the Car First");
                    return null;
            }
        }
    }
}
