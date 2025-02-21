namespace PrimenumberChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num = int.Parse(Console.ReadLine());
            for(int i = 2; i < num / 2; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine($"{num} is Not prime number");
                    return;
                }
            }
            Console.WriteLine($"{num} is prime number");
        }
    }
}

