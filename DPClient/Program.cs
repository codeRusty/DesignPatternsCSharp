using Adapter;
using Facade;
using Factory;
using Prototype;
using Proxy;
using SingletonProj;
using System;
using System.Threading.Tasks;

namespace DPClient
{
    class Program
    {
        static void Main(string[] args)
        {
            FacadeExibitionWrapper.Execute();

            // ProxyExibitionWrapper.Execute();

            // AdapterExibitionWrapper.Execute();

            // FactoryExibitionWrapper.Execute();

            // SingletonExibitionWrapper.Execute();

            // PrototypeExibitionWrapper.Execute();


            Console.ReadLine();
        }

        // To use Async in future
        //static void Main(string[] args)
        //{
        //    MainAsync(args).GetAwaiter().GetResult();
        //}


    }
}
