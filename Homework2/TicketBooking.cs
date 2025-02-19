namespace Ticket_Booking_System
{
    public class MovieTicket
    {
        public string MovieName;
        public int SeatNumber;
        public bool IsBooked;
        public void BookTicket()
        {
            if (IsBooked == true)
            {
                Console.WriteLine("You cant seat this place.This seats is booked");
            }
            else
            {
                IsBooked = false;
                Console.WriteLine("You booked this seat");
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MovieTicket[] m = new MovieTicket[3];
            for (int i = 0; i < m.Length; i++)
            {
                m[i] = new MovieTicket();
                Console.WriteLine("Enter name of Movie");
                m[i].MovieName = Console.ReadLine();
                Console.WriteLine("Enter  Seat ");
                m[i].SeatNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Is this seat booked(True(Yes),False(No)");
                m[i].IsBooked = bool.Parse(Console.ReadLine());

            }
            Console.WriteLine("Free Seats");

            for (int i = 0; i < m.Length; i++)
            {

                if (m[i].IsBooked == false)
                {
                    Console.WriteLine($"{m[i].SeatNumber}");
                }


            }
            Console.WriteLine("Where you want seat?");
            int choice = int.Parse(Console.ReadLine());
            for (int i=0;i<m.Length;i++)
            {
                if (m[i].SeatNumber==choice)
                {
                    m[i].BookTicket();
  
                }
            }
          
        
        }
    }
}
