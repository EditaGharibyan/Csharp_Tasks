namespace Maxfromnumbers
{
    internal class FindMax
    {
        static void FindMax(ref int max,params int[] arr) {

            foreach(int item in arr)
            {
                if (item>max) {
                    max = item;
                }

            }
            
        }



        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int max = int.MinValue;
            Console.WriteLine("Enter numbers");
            for (int i = 0; i < 5; i++) {
                arr[i]=int.Parse(Console.ReadLine());
            }
            FindMax(ref max,arr);
            Console.WriteLine($"Max is {max}");
        }
    }
}
