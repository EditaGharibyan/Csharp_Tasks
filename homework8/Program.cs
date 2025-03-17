using System.Security.Claims;

namespace Dynamic_Cache
{
    public class Data
    {
        public DateTime Date { get; set; }
        private string? _info;
       
        public string Info
        {
            set
            {
                Date = DateTime.Now;
                _info = value;
                //flag = true;
            }
            get
            {
                Date = DateTime.Now;
                return _info;
            }
        }
    }
    public class Cache
    {
        public Data[] arr;
        private readonly int capacity = 5;
        private int size;
        public Cache()
        {
            arr = new Data[capacity];
        }
        private int NextFreeIndex()
        {
            DateTime min = DateTime.MaxValue;
            int minIndex = 0;
            for (int i = 0; i < capacity; i++)
            {
                if (arr[i] == null)
                {
                    return i;
                }
                if (min > arr[i].Date) {
                    min = arr[i].Date;
                    minIndex = i;
                }
                
            }
            return minIndex;
        }
        public Data? this[int ind]
        {
            set
            {
                if (arr[ind] != null)
                    ind = NextFreeIndex();
                    arr[ind] = value;
            }
            get
            {
                if (arr[ind] != null)
                    return arr[ind];
                return null;            
            }
        }
        public void Print()
        {
            foreach (var item in arr)
            {
                if(item != null)
                Console.WriteLine(item.Info + " ");   
            }
        }
    

    } 
    internal class Program
    {
        static void Main(string[] args)
        {
            Data a = new Data();
            a.Info = "File1";
            Data b = new Data();
            b.Info = "File2";
            Data c = new Data();
            c.Info = "File3";
            
            Cache cache =new Cache();
            cache[0] = a;
            cache[0] = b;
            cache[2] = c;
            cache.Print();

        }
    }
}


//public class usernotification
//{
//    private int userid;
//    private string[]? notifications;
//}

//public class service
//{
//    private usernotification[]? usernotifications;

//    public string[]? getnotifications(int iserid)
//    {
//        fore
//    }
//}