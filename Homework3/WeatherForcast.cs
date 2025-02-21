namespace Weather_Forecast_System
{
    internal class Program
    {

        public class WeatherReport {
            public float temp;
            public float humidity;
            public string WeatherCond;
            public WeatherReport() {
                temp = 18.4f;
                humidity = 9.5f;
                WeatherCond = "Now is raining";
            }
            public void Display() {
                Console.WriteLine($"Temperature: {temp}");
                Console.WriteLine($"Humidity: {humidity}");
                Console.WriteLine($"WeatherCond: {WeatherCond}");
            
            }
        }
        static void Main(string[] args)
        {
            WeatherReport[] obj = new WeatherReport[3];
            for (int i=0;i<3;i++)
            {
                obj[i] = new WeatherReport();
                Console.WriteLine("temp= ");
                obj[i].temp = float.Parse(Console.ReadLine());
                Console.WriteLine("humidity=");
                obj[i].humidity = float.Parse(Console.ReadLine());
                Console.WriteLine("Report");
                obj[i].WeatherCond = Console.ReadLine();
            }
            foreach (WeatherReport item in obj)
            {
                item.Display();
            }
        }
    }
}
