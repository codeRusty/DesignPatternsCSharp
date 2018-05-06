using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class PrototypeExibitionWrapper
    {
        public static void Execute() {

            MachineBuilder machine = new MachineBuilder("Intel i7 7th gen","Windows");
            machine.install("Quick Heal");

            // using Prototyping here. Used when a heavy object of the same is required.

            MachineBuilder newMachine = machine.Clone();

            machine.Boot();

            newMachine.install("Visual Studio 2017");
            newMachine.Boot();


        }
    }
}
