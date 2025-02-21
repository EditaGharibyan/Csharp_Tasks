namespace C_fibonachi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int prev = 0;
            int current = 1;
            while (n != 0) {
                Console.WriteLine(prev);
                int temp = prev;
                prev = current;
                current = temp+prev;
                n--;
            }
          
        }
    }
}
