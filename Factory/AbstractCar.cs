using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class AbstractCar : ICar
    {
        protected bool IsUnlocked = false;
        public virtual void Drive()
        {
            if (IsUnlocked == true) Console.Write("Driving "); else Console.Write("Please unlock the car First : ");
        }

        public virtual void Unlock()
        {
            IsUnlocked = true;
        }
    }
}
