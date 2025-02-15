namespace Multiplication_table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{num}*{i}={num*i}");
            }
        }
    }
}
