using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class AudiR8 : AbstractCar
    {
        public override void Drive()
        {
            base.Drive();
            Console.Write("AudiR8");
        }
        public override void Unlock()
        {
            IsUnlocked = true;
        }
    }
}
