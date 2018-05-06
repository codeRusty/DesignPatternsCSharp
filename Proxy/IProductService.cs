using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    interface IProductService
    {
        void GetProduct();
        void AddProduct();
        void GetAll();
    }
}
