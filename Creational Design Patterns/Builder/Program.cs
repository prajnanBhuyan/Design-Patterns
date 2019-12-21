using System;
using System.Collections.Generic;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();

            Builder builderA = new ConcreteBuilderA();
            Builder builderB = new ConcreteBuilderB();

            director.Construct(builderA);
            var productA = builderA.GetProduct();
            productA.Display();

            director.Construct(builderB);
            var productB = builderB.GetProduct();
            productB.Display();

            // Output:
            // Product Type A --------
            //   PartA1
            //   PartA2
            //   PartA3
            // Product Type B --------
            //   PartB1
            //   PartB2
            //   PartB3
        }
    }

    public class Director
    {
        public void Construct(Builder builder)
        {
            builder.BuildPart1();
            builder.BuildPart2();
            builder.BuildPart3();
        }
    }

    public interface Builder
    {
        void BuildPart1();
        void BuildPart2();
        void BuildPart3();
        Product GetProduct();
    }

    public class ConcreteBuilderA: Builder
    {
        private Product product;

        public ConcreteBuilderA()
        {
            product = new Product("Type A");
        }

        public void BuildPart1()
        {
            product.AddPart("PartA1");
        }

        public void BuildPart2()
        {
            product.AddPart("PartA2");
        }

        public void BuildPart3()
        {
            product.AddPart("PartA3");
        }

        public Product GetProduct()
        {
            return product;
        }
    }

    public class ConcreteBuilderB: Builder
    {
        private Product product;

        public ConcreteBuilderB()
        {
            product = new Product("Type B");
        }

        public void BuildPart1()
        {
            product.AddPart("PartB1");
        }

        public void BuildPart2()
        {
            product.AddPart("PartB2");
        }

        public void BuildPart3()
        {
            product.AddPart("PartB3");
        }

        public Product GetProduct()
        {
            return product;
        }
    }

    public class Product
    {
        private string type;
        private List<string> parts = new List<string>();

        public Product(string type)
        {
            this.type = type;
        }

        public void AddPart(string part)
        {
            parts.Add(part);
        }

        public void Display()
        {
            Console.WriteLine($"Product {type} --------");
            foreach(var part in parts)
                Console.WriteLine($"  {part}");
        }
    }
}
