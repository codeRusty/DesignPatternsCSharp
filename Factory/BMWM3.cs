using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class BMWM3 : AbstractCar
    {
        public override void Drive()
        {
            base.Drive();
            Console.Write("BMWM3");
        }
        public override void Unlock()
        {
            IsUnlocked = true;
        }
    }
}
