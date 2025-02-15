namespace Number_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <=n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{i}");
                }
                 Console.WriteLine();
            }
        }
    }
}
