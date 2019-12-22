using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance();
            Console.WriteLine($"s1 hashcode: {s1.GetHashCode()}");
            
            Singleton s2 = Singleton.GetInstance();
            Console.WriteLine($"s2 hashcode: {s2.GetHashCode()}");

            if(s1 == s2)
            {
                Console.WriteLine("Objects are the same instance.");
            }
        }
    }

    public class Singleton
    {
        private static Singleton instance;
        private static object syncLock = new object();

        private Singleton()
        {
        }

        public static Singleton GetInstance()
        {
            if(instance == null)
            {
                lock(syncLock)
                {
                    if(instance == null)
                    {
                        instance = new Singleton();
                    }
                }
            }

            return instance;
        }
    }
}
