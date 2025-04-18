using System.Collections;
namespace MyArrayList
{
    public class MyArrayList : ICloneable, IEnumerable
    {

        private int count = 0;
        private int capacity = 2;
        private object[] arr;
        public int Count { get => count; }

        public MyArrayList()
        {
            arr = new object[capacity];
        }

        public object? this[int index]
        {
            get
            {
                if (index >= 0 && index < count) return arr[index];
                return null;
            }
            set
            {
                if (index >= 0 && index < count)
                {
                    Insert(index, value);
                }
            }

        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return arr[i];
            }

        }
        public object Clone()
        {
            MyArrayList temp = new MyArrayList();
            foreach (object item in this)
            {
                temp.Add(item);
            }
            return temp;
        }
        public void Clear()
        {
            count = 0;
        }
        public void Resize()
        {
            capacity *= 2;
            object[] tarr = arr;
            arr = new Object[capacity];
            for (int i = 0; i < capacity / 2; i++)
            {
                arr[i] = tarr[i];
            }
        }
        public void Add(object item)
        {
            if (count == capacity)
            {
                Resize();
            }
            arr[count] = item;
            count++;
        }
        public void RemoveAt(int index)
        {
            if (index < 0 || index >= count) return;
            for (int i = index; i < count - 1; i++)
            {
                arr[i] = arr[i + 1];

            }
            arr[count - 1] = null;
            count--;

        }
        public void Remove(object ob)
        {
            int index = 0;
            for (int i = 0; i < count; i++)
            {
                if (arr[i]?.Equals(ob) == true)
                {
                    index = i;
                    RemoveAt(index);
                    break;
                }
            }

        }
        public bool Contains(object obj)
        {
            foreach (object item in this)
            {
                if (item?.Equals(obj) == true)
                {
                    return true;
                }
            }
            return false;
        }

        public void Insert(int index, object item)
        {
            if (index == count)
            {
                Add(item);
                return;
            }

            if (count == capacity)
            {
                Resize();
            }
            if (index >= 0 && index < count)
            {

                for (int i = count; i > index; i--)
                {
                    arr[i] = arr[i - 1];
                }
                arr[index] = item;
                count++;
            }
        }

    }



        internal class Program
        {
        public static void Main(string[] args)
            {
                MyArrayList myarr = new MyArrayList();
                myarr.Add(1);
                myarr.Add(3);
                myarr.Add(8);
                myarr.Add(6);

                foreach (object item in myarr)
                {
                    Console.WriteLine(item);
                }
                myarr.Insert(1, 2);
                foreach (object item in myarr)
                {
                    Console.WriteLine(item);
                }
                myarr.RemoveAt(3);
                foreach (object item in myarr)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine(myarr.Contains(6));
                myarr.Remove(1);
                foreach (object item in myarr)
                {
                    Console.WriteLine(item);
                }
                myarr.Clear();
                Console.WriteLine("Count after Clear() function is" + myarr.Count);

            }
        }

    
}
