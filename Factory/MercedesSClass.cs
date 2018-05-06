using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class MercedesSClass : AbstractCar
    {
        public override void Drive()
        {
            base.Drive();
            Console.Write("MercedesSClass");
        }
        public override void Unlock()
        {
            IsUnlocked = true;
        }
    }
}
