using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    public class ProxyExibitionWrapper
    {
        public static void Execute() {
            string username = "username@1";

            //Proxy requires the username whereas the Productservice doesn't

            ProductServiceProxy service = new ProductServiceProxy(username);
            service.AddProduct();
            service.GetAll();
            service.GetProduct();
        }
    }
}
