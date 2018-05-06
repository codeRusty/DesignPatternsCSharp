using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class FactoryExibitionWrapper
    {
        public static void Execute()
        {
            // Using the feature of Factory 
            // To just get instance of any car to drive.
            ICar car = new Garage().GetCar(CarType.AudiR8);
            car.Drive();

            Console.WriteLine("");
            Console.WriteLine("Oops I forget to get keys of " + CarType.AudiR8);
            Console.WriteLine("Lets Drive "+ CarType.BMWM3);
            Console.WriteLine("");

            ICar newCar = new Garage().GetCar(CarType.BMWM3);
            newCar.Unlock();
            newCar.Drive();
        }

    }
}
