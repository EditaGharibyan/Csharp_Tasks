using Prod;
using ProdInt;
using Adapter;
namespace AdapterH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string csv = "Chair 129,26";
            IProductProvide p = new ProductAdapter(csv);
            Product obj = p.GetProduct();
            Console.WriteLine($"{obj.Name} {obj.Price}");
        }
    }
}
