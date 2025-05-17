using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Collections;
namespace List_Extenstions
{
    
    public static class ListExtension
    {
        public static List<T>? MySlice<T>(this List<T> myList, int start, int end)
        {
            if (start < 0 || start > myList.Count || end < 0 || end > myList.Count || start > end) return null;
            List<T> tmp = new List<T>();
            for (int i = start; i <= end; i++)
            {
                tmp.Add(myList[i]);
            }

            return tmp;
        }
        public static void MyReverse<T>(this List<T> myList)
        {
            int n = myList.Count;
            for (int i = 0; i <n/2; i++)
            {
                T tmp = myList[i];
                myList[i] = myList[n - i-1];
                myList[n - i - 1] = tmp;
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{myList[i]} ");
            }
            Console.WriteLine();
        }

        public static void MyShuffle<T>(this List<T> ts)
        {
            List<T> tmp = new List<T>();
            int n = ts.Count;
            int[] array = Enumerable.Range(0, n).ToArray(); 
            Random rnd = new Random();
            if (n == 0) return;
            for (int i = array.Length - 1; i > 0; i--)
            {
                int j = rnd.Next(0, i + 1);
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
            for (int i = 0; i < n; i++)
            {
                tmp.Add(ts[array[i]]);
            }
            ts.Clear();
            ts.AddRange(tmp);
            for (int i = 0; i < n; i++)
            {
               
                Console.Write($"{tmp[i] } ");
            }
            Console.WriteLine();

        }
        public static T MyAt<T>(this List<T> myList,int index)
        {
            if (index > 0 && index<myList.Count)
            {
                Console.WriteLine("Im here +2");
                return myList[index];
            }
            if(index<0 && (myList.Count  + index)>0)
            {
                Console.WriteLine("Im here -2");
                return myList[myList.Count  + index];
            }
            return default(T);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int> { 1, 2, 3,5,6 };
            for (int i = 0; i < arr.Count; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
            arr.MyShuffle();
            arr.MyReverse();
            List<int>? slarr= arr.MySlice(1, 3);
            for (int i = 0; i < slarr.Count; i++)
            {
                Console.Write($"{slarr[i]} ");
            }
            Console.WriteLine($"{slarr.MyAt(2)}");
            Console.WriteLine($"{slarr.MyAt(-2)}");
        }
    }
}
