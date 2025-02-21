namespace Longest_word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter sentence");
            string str=Console.ReadLine();
            string[] word = str.Split(" ");
            int len = int.MinValue;
            int index = 0;
            for (int i=0;i<word.Length;i++)
            {
                if (len < word[i].Length)
                {
                    len = word[i].Length;
                    index=i;
                }
            }
            Console.WriteLine($"size of Longest word is {len},Longeast word is {word[index]}");
        }
    }
}
