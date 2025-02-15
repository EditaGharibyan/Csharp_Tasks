namespace sum__of_digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            while( number>0)
            {
                sum += number % 10;
                number /= 10;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
