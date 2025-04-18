namespace Stack
{
    public class Stack<T>
    {
        private int top=-1;
        private T[] arr;
        public int Capacity { private set; get; } = 5;

        public Stack()
        {
         arr=new T[Capacity];
        }
        public T? Peek()
        {
            if (top > -1) return arr[top];
            return default(T);
        }
        public void Push(T item)
        {

            if ((top + 1) < Capacity)
            {
                top++;
                arr[top] = item;
            }
            else
            {
                Console.WriteLine("Stack is Full");
            }
        }
        public void Pop()
        {
            if (top > -1)
            {
                arr[top] = default(T);
                top--;
            }
        }
        public void Print()
        {
            for(int i = 0; i <= top; i++)
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
            Stack<int> mys = new Stack<int>();
            mys.Push(5);
            mys.Push(2);
            mys.Push(1);
            mys.Push(8);
            mys.Print();
            mys.Pop();
            mys.Print();
            Console.WriteLine($"{mys.Peek()}");
            
        }
    }
}
