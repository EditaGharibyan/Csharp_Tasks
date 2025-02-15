namespace ele
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            char[][] grid = new char[10][];  
            for (int k = 0; k < 10; k++)
            {
                grid[k] = new char[10];  
            }
            Random random = new Random();
            int i=random.Next(0,9);
            int j=random.Next(0,9);

            for (int m = 0; m < 10; m++) {
                for (int n = 0; n < 10; n++)
                {   
                    if(i==m && j == n)
                    {
                        grid[m][ n] = 'X';
                        continue;
                    }
                    
                    grid[m][n] = '0';

                }
            }
            int P= i*10+j;
            for (int m = 0; m < 10; m++)
            {
                for (int n = 0; n < 10; n++)
                {
                    
                    Console.Write(grid[m][n]+" ");

                }
                Console.WriteLine();
            }
            Console.WriteLine($"p= {P}");
        }
    }
}
