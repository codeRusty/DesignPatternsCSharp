using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    internal class ProductService : IProductService
    {
        public void AddProduct()
        {
            Console.WriteLine("Adding Product");
        }

        public void GetAll()
        {
            Console.WriteLine("Getting All Products");
        }

        public void GetProduct()
        {
            Console.WriteLine("Getting A Product");
        }
    }
}
