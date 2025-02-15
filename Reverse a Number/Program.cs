namespace Collatz_Conjecture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int N = int.Parse(Console.ReadLine());
            int count = 0;
            while(N != 1){
                if (N % 2 == 0)
                {
                    count++;
                    N /= 2;
                }
                else
                {
                    N = 3 * N + 1;
                    count++;
                }
            }
            Console.WriteLine($"Count of step until 1 is {count++}");
        }
    }
}
