using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcretePrototype1 p1 = new ConcretePrototype1("Prototype I");
            ConcretePrototype1 c1 = (ConcretePrototype1)p1.Clone();
            Console.WriteLine($"Cloned c1\n{GetDetails(c1)}");
            Console.WriteLine($"From p1\n{GetDetails(p1)}");

            ConcretePrototype2 p2 = new ConcretePrototype2("Prototype II");
            ConcretePrototype2 c2 = (ConcretePrototype2)p2.Clone();
            Console.WriteLine($"Cloned c2\n{GetDetails(c2)}");
            Console.WriteLine($"From p2\n{GetDetails(p2)}");

            // Output:
            // Cloned c1
            // ID: Prototype I  hashcode: 58225482
            // From p1
            // ID: Prototype I  hashcode: 54267293
            // Cloned c2
            // ID: Prototype II  hashcode: 18643596
            // From p2
            // ID: Prototype II  hashcode: 33574638
        }

        static string GetDetails(Prototype p)
        {
            return $"ID: {p.ID}  hashcode: {p.GetHashCode()}";
        }
    }

    public interface Prototype
    {
        string ID {get; }
        Prototype Clone();
    }

    public class ConcretePrototype1 : Prototype
    {
        public string ID {get; private set;}

        public ConcretePrototype1(string id)
        {
            ID = id;
        }
        
        public Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }

    public class ConcretePrototype2 : Prototype
    {
        public string ID {get; private set;}

        public ConcretePrototype2(string id)
        {
            ID = id;            
        }

        public Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();            
        }
    }
}
