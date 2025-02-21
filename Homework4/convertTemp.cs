namespace Converttemp
{
    internal class Program
    {
        static void ConvertTemp(ref float Celisus,out float Farenhait,out float Kelvin) {
            Farenhait = Celisus * 9 / 5 + 32;
            Kelvin = Celisus + 273.15f;
        
        }
        static void Main(string[] args)
        {
            float Farenhait;
            float Kelvin;
            float Celsius=float.Parse(Console.ReadLine());
            ConvertTemp(ref Celsius,out Farenhait,out Kelvin);
            Console.WriteLine($"Celsius {Celsius}\nFarenhait={Farenhait}\nKelvin={Kelvin}");
        }
    }
}
