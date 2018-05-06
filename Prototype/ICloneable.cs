using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    interface ICloneable<T>
    {
        T Clone();
    }
}
