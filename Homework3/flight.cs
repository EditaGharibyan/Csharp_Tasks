namespace Flight_Reservation_System
{
    internal class Program
    {
        public class FlightReservationSystem{
            public string passengerName ;
            public int flightNumber;
            public int seatNumber;
            public FlightReservationSystem() {
                passengerName ="Unknown";
                flightNumber = 155;
                seatNumber = 142;
            

            }
            public void ShowDatails() {
                Console.WriteLine($"{passengerName}\n{flightNumber}\n{seatNumber}");
            }
         }
        static void Main(string[] args)
        {
            FlightReservationSystem f = new FlightReservationSystem();
            FlightReservationSystem e = new FlightReservationSystem();
            f.passengerName ="Anahit";
            f.flightNumber = 125;
            f.seatNumber = 14;
            e.flightNumber = 102;
            e.seatNumber = 145;
            e.passengerName = "Hayk";
            e.ShowDatails();
            f.ShowDatails();

        }
    }
}
