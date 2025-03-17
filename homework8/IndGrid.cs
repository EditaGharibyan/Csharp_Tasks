namespace Unknown_Grid
{
    public class Grid
    {
        private int[,] matrix;
        private int  row;
        private int col;

        public Grid(int r,int c,int[,] mat)
        {
            row = r;
            col = c;
            matrix = new int[row, col];
            matrix = mat;
            //for(int i = 0; i < mat.Length; i++)
            //{
            //    for(int j = 0; j < mat.Length; j++)
            //    {
            //        matrix[i,j] = mat[i,j];
            //    }
            //}

        }
        public int this[int r,int c]
        {
            set {
                if (r < row && r >= 0 && c < col && c >= 0)
                {
                    matrix[r, c] = value;
                }
                else
                {
                    Console.WriteLine("Invalid index");

                }
            }
            get {
                if (r < row && r >= 0 && c < col && c >= 0)
                    return matrix[r,c];
                return -1;
            }

        }
        public int[] RetRow(int r)
        {
            int[] arr = new int[col];
            if (r < row && r>=0)
            {
                for(int i = 0; i < col; i++)
                {
                    arr[i] = matrix[r,i];
                }
                return arr;
            }
            Console.WriteLine("Invalid index");
            return arr;
        }
        public int[] RetCol(int c)
        {
            int[] arr = new int[row];
            if (c < col && c >= 0)
            {
                for (int i = 0; i < row; i++)
                {
                    arr[i] = matrix[i, c];
                }
                return arr;
            }
            return null;
        }

    }
    internal class IndGrid
    {
        static void Main(string[] args)
        {

            int[,] mat =  {{ 7, 8, 9 },{ 4,5,6 },{ 1,2,3} };
        Grid g = new Grid(3, 3,mat);
            Console.WriteLine("Enter index");
            int ind=int.Parse(Console.ReadLine());
            int ind1=int.Parse(Console.ReadLine());
            g[ind, ind1] = 42;
            //Console.WriteLine(g[0,2]);
            Console.WriteLine("Enter row");
            int new_r = int.Parse(Console.ReadLine());
            int[] arr = g.RetRow(new_r);
            foreach (var item in arr)
            {
                Console.Write(item+" ");   
            }


        }
    }
}
