
namespace Calc_area_and_perimetr
{

    internal class Program
    {
        static void CalcAreaPerimeter(ref float Radius,out double Perimeter,out double Area){

            Perimeter = 2 * Radius * Math.PI;
            Area = Math.PI  *  Radius*Radius;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Enter radius of Cycle");
            float Radius = float.Parse(Console.ReadLine());
            double Area,Perimeter;
            CalcAreaPerimeter(ref Radius,out Perimeter,out Area);
            Console.WriteLine($"Radius={Radius}\nPerimeter={Perimeter}\nArea={Area}");
        }
    }
}
