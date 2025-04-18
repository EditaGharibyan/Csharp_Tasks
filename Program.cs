namespace Queue
{
    public class Queue<T>
    {
        private int top = -1;
        private T[] arr;
        public int Capacity { private set; get; } = 5;
        public Queue()
        {
            arr = new T[Capacity];
        }
        public void Deque()
        {
            if (top == -1) return;
            if(top==0)
            {
                arr[top] = default(T);
                top--;
            }
            if (top > 0)
            {
                for(int i = 1; i <= top; i++)
                {
                    arr[i - 1] = arr[i];
                }
                top--;
            }

        }
        public void Enque(T item)
        {

            if ((top + 1) < Capacity)
            {
                top++;
                arr[top] = item;
            }
            else
            {
                Console.WriteLine("Queue is Fully");
            }
        }

        public T Peek()
        {
            if (top > -1) return arr[top];
            return default(T);
        }
        public void Print()
        {
            for (int i = 0; i <= top; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }

    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Queue<int> que = new Queue<int>();
            que.Enque(5);
            que.Enque(2);
            que.Enque(3);
            que.Enque(1);
            que.Enque(6);
            que.Enque(9);
            que.Print();
            Console.WriteLine($"{que.Peek()}");
            que.Deque();
            Console.WriteLine($"{que.Peek()}");
            que.Print();

        }
    }
}
