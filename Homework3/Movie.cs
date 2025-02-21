namespace Movie_Rating_System
{


    public class Movie() { 
        private int Rating;
        public int Rat
        {
            set { 
                if(value>=1 && value <= 5)
                {
                    Console.WriteLine("Set is succesed");
                    Rating = value;
                  
                }
                else
                {
                    Console.WriteLine("Invalid value");
                }
                 
            
            }
        
        }
    } 
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie m = new Movie();
            Console.WriteLine("When value =5");
            m.Rat = 5;
            Movie n = new Movie();
            Console.WriteLine("When value =1");
            n.Rat = 1;
            Movie e = new Movie();
            Console.WriteLine("When value=-1");
            e.Rat = -1;                     
            Movie t = new Movie();
            Console.WriteLine("When value=10");
            n.Rat = 10;
            
        }
    }
}
