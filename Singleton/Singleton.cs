using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null;
        private static readonly object Instancelock = new object();

        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (Instancelock)
                    {
                        if (instance == null)
                            instance = new Singleton();
                    }
                }
                return instance;
            }
        }

        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

    }
}
