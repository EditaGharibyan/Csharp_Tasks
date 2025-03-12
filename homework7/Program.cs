namespace Product_prop
{

    public class Product
    {
        private double price;
        public double Price
        {
            set
            {
                if (value > 0)
                {
                    price = value;
                }
                else
                {
                    price = 0;
                }
            }
            get
            {
                return price;
            }
        }
        public static int Stock { get; set; }
        public Product(double p)
        {
            price = p;
            Stock++;

        }
        public int PrintStock (){
            return  Stock;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product(520.1);
            Console.WriteLine("p=" + p.Price);
            Product e = new Product(521.1);
            Console.WriteLine("e=" + e.Price);

            Product k = new Product(522.1);
            Console.WriteLine("k=" + k.Price);

            Product o = new Product(523.1);
            Console.WriteLine("o=" + o.Price);
            Console.WriteLine(o.PrintStock());

        }
    }
}
