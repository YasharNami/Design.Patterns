using System;
using System.Collections.Generic;

namespace Design.Patterns.Behaviorals.Template
{
    /// <summary>
    /// Template Design Pattern
    /// </summary>

    public class Program
    {
        public static void Main(string[] args)
        {
            DataAccessor categories = new Categories();
            categories.Run(5);

            DataAccessor products = new Products();
            products.Run(3);

            // Wait for user

            Console.ReadKey();
        }
    }

    /// <summary>
    /// The 'AbstractClass' abstract class
    /// </summary>

    public abstract class DataAccessor
    {
        public abstract void Connect();
        public abstract void Select();
        public abstract void Process(int top);
        public abstract void Disconnect();

        // The 'Template Method' 

        public void Run(int top)
        {
            Connect();
            Select();
            Process(top);
            Disconnect();
        }
    }

    /// <summary>
    /// A 'ConcreteClass' class
    /// </summary>

    public class Categories : DataAccessor
    {
        private List<string> categories;

        public override void Connect()
        {
            categories = new List<string>();
        }

        public override void Select()
        {
            categories.Add("Red");
            categories.Add("Green");
            categories.Add("Blue");
            categories.Add("Yellow");
            categories.Add("Purple");
            categories.Add("White");
            categories.Add("Black");
        }

        public override void Process(int top)
        {
            Console.WriteLine("Categories ---- ");

            for (int i = 0; i < top; i++)
            {
                Console.WriteLine(categories[i]);
            }

            Console.WriteLine();
        }

        public override void Disconnect()
        {
            categories.Clear();
        }
    }

    /// <summary>
    /// A 'ConcreteClass' class
    /// </summary>

    public class Products : DataAccessor
    {
        private List<string> products;

        public override void Connect()
        {
            products = new List<string>();
        }

        public override void Select()
        {
            products.Add("Car");
            products.Add("Bike");
            products.Add("Boat");
            products.Add("Truck");
            products.Add("Moped");
            products.Add("Rollerskate");
            products.Add("Stroller");
        }

        public override void Process(int top)
        {
            Console.WriteLine("Products ---- ");

            for (int i = 0; i < top; i++)
            {
                Console.WriteLine(products[i]);
            }

            Console.WriteLine();
        }

        public override void Disconnect()
        {
            products.Clear();
        }
    }
}
