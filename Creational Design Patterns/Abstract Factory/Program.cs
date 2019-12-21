using System;

namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abstract Factory 1
            AbstractFactory factory1 = new ConcreteFactory1();
            Client client1 = new Client(factory1);
            client1.Run();

            // Abstract Factory 2
            AbstractFactory factory2 = new ConcreteFactory2();
            Client client2 = new Client(factory2);
            client2.Run();

            // Output:
            // ConcreteFactory1 created ProductA1
            // ConcreteFactory1 created ProductB1
            // ProductB1 interacts with ProductA1
            // ConcreteFactory2 created ProductA2
            // ConcreteFactory2 created ProductB2
            // ProductB2 interacts with ProductA2
        }
    }

    ////////////////////////////////////////////////////////////////
    // We define two interfaces for two types of products A and B //
    ////////////////////////////////////////////////////////////////
    ///<summary>
    /// Interface for Product type A
    ///</summary>
    public interface AbstractProductA
    {
    }


    ///<summary>
    /// Interface for Product type B
    ///</summary>
    ///<remarks>
    /// Contains a method that interacts with an object implementing
    /// AbstractProductA to simulate dependency/relation
    ///</remarks>
    public interface AbstractProductB
    {
        void Interact(AbstractProductA a);
    }

    ////////////////////////////////////////////
    // We define two sets of products A and B //
    ////////////////////////////////////////////
    // SET 1 //
    ///////////
    ///<summary>
    /// Concrete Product of type A
    ///</summary>
    public class ProductA1 : AbstractProductA
    {
    }

    ///<summary>
    /// Concrete Product of type B
    ///</summary>
    ///<remarks>
    /// Contains a method that interacts with an object implementing
    /// AbstractProductA to simulate dependency/relation
    ///</remarks>
    public class ProductB1 : AbstractProductB
    {
        public void Interact(AbstractProductA a)
        {
            Console.WriteLine($"{this.GetType().Name} interacts with {a.GetType().Name}");
        }
    }

    ///////////
    // SET 2 //
    ///////////
    ///<summary>
    /// Concrete Product of type A
    ///</summary>
    public class ProductA2 : AbstractProductA
    {
    }

    ///<summary>
    /// Concrete Product of type B
    ///</summary>
    ///<remarks>
    /// Contains a method that interacts with an object implementing
    /// AbstractProductA to simulate dependency/relation
    ///</remarks>
    public class ProductB2 : AbstractProductB
    {
        public void Interact(AbstractProductA a)
        {
            Console.WriteLine($"{this.GetType().Name} interacts with {a.GetType().Name}");
        }
    }

    
    ///<summary>
    /// An interface for operations that create abstract products
    ///</summary>
    public interface AbstractFactory
    {
        AbstractProductA CreateProductA();
        AbstractProductB CreateProductB();
    }

    /////////////////////////////////////////////////////////////////////
    // We define two factories that each generate two products A and B //
    /////////////////////////////////////////////////////////////////////
    ///<summary>
    /// Concrete Factory 1
    ///</summary>
    public class ConcreteFactory1 : AbstractFactory
    {
        public AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }

    ///<summary>
    /// Concrete Factory 2
    ///</summary>
    public class ConcreteFactory2 : AbstractFactory
    {
        public AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        public AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }

    ///<summary>
    /// The concrete implementation independent interaction environment that can 
    /// perform the Run function without worrying which objects it is operation on
    ///</summary>
    public class Client
    {
        private AbstractProductA abstractProductA;
        private AbstractProductB abstractProductB;

        public Client(AbstractFactory abstractFactory)
        {
            abstractProductA = abstractFactory.CreateProductA();
            Console.WriteLine($"{abstractFactory.GetType().Name} created {abstractProductA.GetType().Name}");
            abstractProductB = abstractFactory.CreateProductB();
            Console.WriteLine($"{abstractFactory.GetType().Name} created {abstractProductB.GetType().Name}");
        }

        public void Run()
        {
            abstractProductB.Interact(abstractProductA);
        }
    }
}
