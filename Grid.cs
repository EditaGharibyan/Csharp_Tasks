namespace ele
{
    internal class Grid
    {
        static void Main(string[] args)
        {

            char[][] grid = new char[10][];
            for (int k = 0; k < 10; k++)
            {
                grid[k] = new char[10];
            }
            for (int m = 0; m < 10; m++)
            {
                for (int n = 0; n < 10; n++)
                {
                    grid[m][n] = '0';
                }
                Console.WriteLine();
            }
            Random random = new Random();
            int i = random.Next(0, 9);
            int j = random.Next(0, 9);

            grid[i][j] = 'X';


            int b = -1;
            int c = -1;

            while (b != i && c != j)
            {



                for (int m = 0; m < 10; m++)
                {
                    for (int n = 0; n < 10; n++)
                    {
                     
                            Console.Write($"0 ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("You cant find X ,try again");
                Console.WriteLine("Enter number of row");
                b = int.Parse(Console.ReadLine())-1;
                Console.WriteLine("Enter Number of Column");
                c = int.Parse(Console.ReadLine())-1;

            }
            Console.WriteLine("You are winner");
            for (int m = 0; m < 10; m++)
            {
                for (int n = 0; n < 10; n++)
                {
                    
                    Console.Write(grid[m][n] + " ");

                }
                Console.WriteLine();
            }

        }
    }
}
