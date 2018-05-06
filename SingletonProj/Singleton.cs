using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonProj
{
    public sealed class Singleton
    {
        private static Singleton instance = null;
        private static readonly object padlock = new object();
        private int AccountValue = 500;

        Singleton()
        {
        }

        public static Singleton GetInstance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                    return instance;
                }
            }
        }

        public int ReduceAmount(int amount) {
            return AccountValue -= amount;
            // AccountValue - amount;
        }
    }
}
