using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonProj
{
    public class SingletonExibitionWrapper
    {
        public static void Execute() {

            Console.WriteLine("Without using singleton pattern");

            // Any one can create an instance of the class and reduce the amount anytime.
            NotSingleton notSingleton = new NotSingleton();
            Console.WriteLine("After Reducing first 50 from Amount: " + notSingleton.ReduceAmount(50));

            // Any one can create an instance and that too on another Thread. 
            // So we might also need to take care that two thread simultaneously cannot perform a important action
            NotSingleton anotherNotSingleton = new NotSingleton();
            Console.WriteLine("After Reducing second 50 from Amount: " + anotherNotSingleton.ReduceAmount(50));

            Console.WriteLine("----------------------------------");

            Console.WriteLine("Using thread safe Singleton pattern");

            // Instance connot be created as 'singleton.Singleton' is in accessable due to its protection level
            // Singleton singleton = new Singleton();
            Singleton singleton = Singleton.GetInstance;
            Console.WriteLine("After Reducing first 50 from Amount: " + singleton.ReduceAmount(50));

            // Any one can create an instance and that too on another Thread. No Problem !!
            Singleton anotherSingletonInstance = Singleton.GetInstance;
            Console.WriteLine("After Reducing second 50 from Amount: " + singleton.ReduceAmount(50));
        }
    }
}
