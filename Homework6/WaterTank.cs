using System.Text;


namespace WaterTank
{
    public class WaterTank
    {
        private double Capacity;
        private double CurrentLevel;
        public WaterTank(double cap, double cur)
        {
            Capacity = cap;
            CurrentLevel = cur;
        }
        public static WaterTank operator +(WaterTank a, WaterTank b)

        {
            double c = a.CurrentLevel + b.CurrentLevel;
            if (c > a.Capacity)
            {
                c = a.Capacity;
            }
            return new WaterTank(a.Capacity, c);
        }
        public static WaterTank operator -(WaterTank a, WaterTank b)

        {

            double e = a.CurrentLevel - b.CurrentLevel;
            if (e < 0)
            {
                e = 0.0;
            }
            return new WaterTank(a.Capacity, e);
        }
        public override string ToString()
        {
            return $"Capacity:{Capacity}\n CurrentLevel: {CurrentLevel}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            WaterTank w1 = new WaterTank(1000, 250.25);
            Console.WriteLine($"Tis is w1 {w1.ToString()}");

            WaterTank v1 = new WaterTank(1000, 550.25);
            Console.WriteLine($"This is v1{v1.ToString()}");

            //w=v+w;

            WaterTank Tank = w1 + v1;
            Console.WriteLine($"Tis is Tank {Tank.ToString()}");
            w1 = Tank + v1;
            Console.WriteLine($"This is new w1 {w1.ToString()}");
            w1 = Tank - v1;
            Console.WriteLine($"This is new w1 {w1.ToString()}");



        }
    }
}
