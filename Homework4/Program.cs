namespace SumOfNumbers
{
    internal class Program
    {
        static void SumOfNumbers(ref int sum,params int[] arr) {
            foreach (int item in arr)
            {
                sum += item;
            }

        }
        static void Main(string[] args)
        {
            int sum = 0;
            int[] arr = new int[5];
            Console.WriteLine("Enter numbers");
            for(int i=0;i<arr.Length;i++ )
            {
                arr[i]= int.Parse(Console.ReadLine());   
            }
            SumOfNumbers(ref sum,arr);
            Console.WriteLine($"Sum of Numbers is {sum}");
        }
    }
}
