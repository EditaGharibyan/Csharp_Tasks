namespace TimeConverter
{
    internal class Program
    {
        static void Converter(ref int Time,out int Hours,out int Second,out int Minutes){
            Hours = Time / 3600;
            Minutes = Time % 3600 / 60;
            Second = Time % 3600 - Minutes * 60;
            Console.WriteLine($"Hour={Hours}\nminutes={Minutes}\nSecond={Second}");
            
        }
        static void Main(string[] args)
        {
            int Time = int.Parse(Console.ReadLine());
            int Hours, Minutes, Second;
            Converter(ref Time,out Hours,out Second,out Minutes);
        }
    }
}
