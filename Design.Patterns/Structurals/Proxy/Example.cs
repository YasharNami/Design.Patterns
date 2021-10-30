using System;

namespace Design.Patterns.Structurals.Proxy
{
    /// <summary>
    /// Proxy Design Pattern
    /// </summary>

    public class Program
    {
        public static void Main(string[] args)
        {
            // Create math proxy

            MathProxy proxy = new MathProxy();

            // Do the math

            Console.WriteLine("4 + 2 = " + proxy.Add(4, 2));
            Console.WriteLine("4 - 2 = " + proxy.Sub(4, 2));
            Console.WriteLine("4 * 2 = " + proxy.Mul(4, 2));
            Console.WriteLine("4 / 2 = " + proxy.Div(4, 2));

            // Wait for user

            Console.ReadKey();
        }
    }

    /// <summary>
    /// The 'Subject interface
    /// </summary>

    public interface IMath
    {
        double Add(double x, double y);
        double Sub(double x, double y);
        double Mul(double x, double y);
        double Div(double x, double y);
    }

    /// <summary>
    /// The 'RealSubject' class
    /// </summary>

    public class Math : IMath
    {
        public double Add(double x, double y) { return x + y; }
        public double Sub(double x, double y) { return x - y; }
        public double Mul(double x, double y) { return x * y; }
        public double Div(double x, double y) { return x / y; }
    }

    /// <summary>
    /// The 'Proxy Object' class
    /// </summary>

    public class MathProxy : IMath
    {
        private Math math = new Math();

        public double Add(double x, double y)
        {
            return math.Add(x, y);
        }
        public double Sub(double x, double y)
        {
            return math.Sub(x, y);
        }
        public double Mul(double x, double y)
        {
            return math.Mul(x, y);
        }
        public double Div(double x, double y)
        {
            return math.Div(x, y);
        }
    }
}
