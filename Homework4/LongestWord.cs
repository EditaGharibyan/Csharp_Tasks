namespace LongWord5
{
    internal class Program
    {
        static void LongWord(params string[] arr) {
            int l = int.MinValue;
            string b = "";
            for(int i = 0; i < arr.Length; i++)
            {
                if (l < arr[i].Length)
                {
                    l = arr[i].Length;
                    b = arr[i];
                }
            }
         
            Console.WriteLine($"Longest word is {b}");

        }
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");
            string s = Console.ReadLine();
            string[] str = s.Split();
            LongWord(str);
        }
    }
}
