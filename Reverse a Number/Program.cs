namespace Rev_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int num = int.Parse(Console.ReadLine());
            int rev_num = 0;
            while (num > 0)
            {
                rev_num=rev_num*10+num%10;
                num /= 10;
            }
            Console.WriteLine($"reverse number={rev_num}");
        }
    }
}
