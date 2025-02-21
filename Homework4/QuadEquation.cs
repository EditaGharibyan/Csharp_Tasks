using System.Reflection.Metadata;

namespace Quadratic_Equation
{
    internal class Program
    {
        static void FindRoots(ref int a,ref int b,ref int c,out int d) {
            d = b * b - 4 * a * c;
            if (d > 0)
            {
                double x1 = (-b + Math.Sqrt(d)) / 2 * a;
                double x2 = (-b - Math.Sqrt(d)) / 2 * a;
                Console.WriteLine($"x1={x1} x2={x2}");
            }
            else if (d==0) {
                double x1 = (-b + Math.Sqrt(d)) / 2 * a;
                Console.WriteLine($"x1={x1}");

            }
            else
            {
                Console.WriteLine($"Noo roots");

            }
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d;
            FindRoots(ref a,ref b,ref c,out d);
        }
    }
}
