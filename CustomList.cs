namespace Custom_List
{
    internal class CustomList
    {
        public class MyList
        {
            private int[] arr ;
            private int size;
            private int capacity;
            public MyList( int[] m_arr)
            {
                capacity = 10;
                arr = new int[capacity];
                for(int i = 0; i < m_arr.Length; i++)
                {
                    arr[i]=m_arr[i];
                }
                size = m_arr.Length;

            }
            public int Length
            {
                get { return size; }

            }
            public int this[int ind]
            {
                set
                {
                    if (ind >= 0 && ind <= size)
                    {
                        arr[ind] = value;
                    }
                    
                }
                get
                {
                    if (ind >= 0 && ind < size)
                    {
                        return arr[ind];
                    }
                    return -1;
                }
            }
            public void addItem(int value)
            {
                if (size == capacity)
                {
                    capacity*=2;
                    int[] n_arr = new int[capacity];
                    for(int i = 0; i < size; i++)
                    {
                        n_arr[i] = arr[i];
                    }
                    arr=n_arr;
                }
                arr[size] = value;
                size++;
            }
            public void DeleteItem()
            {
                
               if(size>0)
                size--;
            }

        }
        static void Main(string[] args)
        {

            MyList M = new MyList(new int[] { 1, 2, 3, 4 } );

        }
    }
}
