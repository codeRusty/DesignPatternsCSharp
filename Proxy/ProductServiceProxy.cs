using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    class ProductServiceProxy : IProductService
    {
        private ProductService service = new ProductService();
        private string _username;

        public ProductServiceProxy(string userName)
        {
            Console.WriteLine("Proxy being used..");
            this._username = userName;
        }

        public void AddProduct()
        {
            if (_username != String.Empty)
                service.AddProduct();
            else
                throw new Exception("No Username found");

        }

        public void GetAll()
        {
            if (_username != String.Empty)
                service.GetAll();
            else
                throw new Exception("No Username found");
        }

        public void GetProduct()
        {
            if (_username != String.Empty)
                service.GetProduct();
            else
                throw new Exception("No Username found");
        }
    }
}
