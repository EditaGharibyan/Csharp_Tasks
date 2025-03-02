namespace InkReservior
{
    public class InkReservior
    {
        public  string color;
        public  double InkAmount;
        public InkReservior(string c,double i)
        {
            color = c;
            InkAmount = i;
        }
        public override string ToString()
        {
            return $"Color {color}, InkAmount {InkAmount}";
        }
        public static InkReservior operator +(InkReservior a,InkReservior b)
        {
            if (a.color == b.color)
            {
                double c = a.InkAmount + b.InkAmount;
                return new InkReservior(a.color,c);
            }
            else
            {
                Console.WriteLine("You cant margeing");
                return a;
            }
        }
        public static InkReservior operator -(InkReservior a, double b)
        {
            if (a.InkAmount>b)
            {
                double c = a.InkAmount - b;
                return new InkReservior(a.color, c);
            }
            else
            {
                Console.WriteLine("You cant margeing");
                return a;
            }
        }
    }
    
    
    internal class Program
    {
        static void Main(string[] args)
        {
            InkReservior i = new InkReservior("Blue",15.2);
            Console.WriteLine($"i {i.ToString()}");
            InkReservior i1 = new InkReservior("Red",10.2);
            Console.WriteLine($"i {i1.ToString()}");

            i = i + i1;
            Console.WriteLine($"i {i.ToString()}");

            InkReservior i2 = i-10.0;
            Console.WriteLine($"i {i2.ToString()}");

        }
    }
}
