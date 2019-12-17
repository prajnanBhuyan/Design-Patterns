using System;

namespace Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator[] creators = new Creator[2];

            creators[0] = new ConcreteCreatorA();
            creators[1] = new ConcreteCreatorB();

            foreach (var creator in creators)
            {
                var product = creator.FactoryMethod();
                Console.WriteLine($"{creator.GetType().Name} created {product.GetType().Name}");
            }
            
            // Output:
            // ConcreteCreatorA created ConcreteProductA
            // ConcreteCreatorB created ConcreteProductB
        }
    }

    public interface Product
    {
    }

    public class ConcreteProductA : Product
    {
    }

    public class ConcreteProductB : Product
    {
    }

    // We can use an abstract class instead, if we wish to
    // implement a default definition for the factory method
    public interface Creator
    {
        Product FactoryMethod();
    }

    public class ConcreteCreatorA : Creator
    {
        public Product FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }

    public class ConcreteCreatorB : Creator
    {
        public Product FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }
}
