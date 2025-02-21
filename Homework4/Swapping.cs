namespace Swapping
{
    internal class Program
    {

        static void swap(ref int a,ref int b)
        {
            int c = a;
            a = b;
            b = c;
            Console.WriteLine($"a={a}  b={b}");
        }
        static void Main(string[] args)
        {
            int a = 5;
            int b = 7;
            Console.WriteLine($"a={a}  b={b}");
            swap(ref a, ref b);
        }
    }
}
