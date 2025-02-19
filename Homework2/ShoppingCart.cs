using System.Numerics;
using System.Transactions;

namespace Shopping_Cart
{

    public class Product
    {
        public string Name;
        public float Price;
        public float Quantity;
        public Product()
        {
            Name = "Anna";
            Price = 15.5f;
            Quantity = 6.2f;
        }
        public double TotalPrice()
        {
            return Price * Quantity;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want add Product?(Yes or No)");
            string flag = Console.ReadLine();
            flag = flag.ToLower();
            double Price = 0;
            int count = 0;
            while (flag != "no")
            {
                Console.WriteLine("Do you want add Product?(Yes or No)");
                Product p = new Product();
                Console.WriteLine("Enter Name of Product");
                p.Name = Console.ReadLine();
                Console.WriteLine("Enter Price");
                p.Price = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter Quantity");
                p.Quantity = float.Parse(Console.ReadLine());
                if (count >= 5)
                {
                    Price += p.TotalPrice() * 90 / 100;
                }
                else
                {
                    Price += p.TotalPrice();
                }
                count++;
                flag = Console.ReadLine();
                flag = flag.ToLower();
            }
            Console.WriteLine($"Price: {Price}");
        }
    }
}
