namespace Recursive_fibonacci
{
  
    internal class Program
    {
        static int RecursiveFib(int n)
        {
            if (n==0)
            {
                return 0;
            }
            if (n == 2 || n==1)
            {
                return 1;
            }
            return RecursiveFib(n - 1) + RecursiveFib(n - 2);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int res=RecursiveFib(n);
            Console.WriteLine($"{res}");
        }
    }
}
