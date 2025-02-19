namespace Car_Rental_System
{
    public class CarRentalSystem {
        public string Model;
        public int Year;
        public bool IsRented;
        public CarRentalSystem() {
            Model = "BMW";
            Year = 2025;
            IsRented = true;
        }
        public void RentCar()
        {
            if (IsRented == true)
            {
                IsRented = false;
                Console.WriteLine("You Rented this Car");
            }
            else {
                Console.WriteLine("You Cant rent");
            
            }

        }
        public void ReturnCar() {
            IsRented = true;
        } 
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CarRentalSystem[] c = new CarRentalSystem[3];
            for(int i = 0; i < c.Length; i++)
            {
                c[i] = new CarRentalSystem();
                Console.WriteLine("Enter Model");
                c[i].Model = Console.ReadLine();
                Console.WriteLine("Enter year");
                c[i].Year = int.Parse(Console.ReadLine());
                
            }
            Console.WriteLine($"Anna want rent {c[2].Model}");
            c[2].RentCar();
            c[2].ReturnCar();
            Console.WriteLine($"Aram want rent {c[1].Model}");
            c[1].RentCar();
            Console.WriteLine($"Artur Want rent {c[1].Model} ");
            c[1].RentCar();
        }
    }
}
