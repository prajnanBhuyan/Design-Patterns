using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Target t1 = new Target();
            t1.ExpectedMethod();

            Adaptee adaptee = new Adaptee();
            Target t2 = new Adapter(adaptee);
            t2.ExpectedMethod();

            // Output:
            // Calls the ExpectedMethod
            // Calls the DifferentMethod
        }
    }

    public class Target
    {
        public virtual void ExpectedMethod()
        {
            Console.WriteLine($"Calls the ExpectedMethod");
        }
    }

    public class Adapter : Target
    {
        private Adaptee adaptee;

        public Adapter(Adaptee adaptee)
        {
            this.adaptee = adaptee;
        }

        public override void ExpectedMethod()
        {
            adaptee.DifferentMethod();
        }
    }

    public class Adaptee
    {
        public void DifferentMethod()
        {
            Console.WriteLine($"Calls the DifferentMethod");
        }
    }
}
