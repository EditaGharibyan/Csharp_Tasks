namespace E_Commerce_Product_System
{

    public class ProductSystem {
        public string Name;
        public float Price;
        public int StackQuantity;
      
        public ProductSystem()
        {
            this.Name = "Unknown";
            this.Price = 0.0f;
            this.StackQuantity = 0;
        }

        public ProductSystem(string name,float price,int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.StackQuantity = quantity;

        }
        public ProductSystem(string name, int quantity)
        {
            this.Name = name;
            this.StackQuantity = quantity;

        }
        public void ShowDetails() {
            Console.WriteLine($"{this.Name} {this.Price}  {this.StackQuantity}");
        
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductSystem[] p = {
              new  ProductSystem(),
              new  ProductSystem("Notebook",1500.2f,45),
              new  ProductSystem("Phone",5),
              new  ProductSystem("Macbook",2000.500f,15)

            };
            foreach (ProductSystem item in p)
            {
                item.ShowDetails();
            }
        }
    }
}
