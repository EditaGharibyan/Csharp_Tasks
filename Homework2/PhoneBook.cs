using System.Xml.Linq;

namespace PhoneBook
{
    public class PhoneBook
    {

        public string Name;
        public string PhoneNumber;
        public string Email;
        public PhoneBook()
        {
            Name = "Edita";
            PhoneNumber ="02563456";
            Email = "edita.a.gharibyan@gmail.com";
        }
        public static int i = 0;
        public void DisplayInfo()
        {
            Console.WriteLine("Name: {0}\n PhoneNumber: {1}\nEmail: {2}", Name, PhoneNumber, Email);
        }

        public  void Search(string name) {
            name = name.ToLower();
            Name = Name.ToLower();
                if (Name == name)
                {
                    Console.WriteLine(PhoneNumber);

                }
           
            
        }



    }

    internal class Program
    {


        static void Main(string[] args)
        {
            PhoneBook[] c = new PhoneBook[3];           
           
           c[0] =new PhoneBook {Name="Bob", PhoneNumber = "05234555", Email = "BOb1040@gmail.com" };
           c[1] =new PhoneBook {Name="Alina", PhoneNumber = "03334556", Email = "Alina1040@gmail.com" };
           c[2] =new PhoneBook {Name="John", PhoneNumber = "052568901", Email = "John1040@gmail.com" };
          foreach(PhoneBook item in c)
          {
                item.DisplayInfo();


          }
            string? o=Console.ReadLine();
            
            foreach (PhoneBook item in c)
            {
               item.Search(o);
            }
           
           
        }
    }
}
