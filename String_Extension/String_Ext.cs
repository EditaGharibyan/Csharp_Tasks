using System.Text;

namespace String_Extensions
{
    public static class String_Extensions
    {
        public static string? MySubString(this string s, int start, int count)
        {
            if (start > s.Length || start + count > s.Length) return null;
            StringBuilder str = new StringBuilder();
            int i = start;
            while (count != 0)
            {
                str.Append(s[i]);
                i++;
                count--;
            }
            return str.ToString();
        }
        public static int MyIndexOf(this string str, string s)
        {
            if (s.Length > str.Length) return -1;
            int i = 0;
            for (int j = 0; j < str.Length; j++)
            {
                if (i > 0 && s[i] != str[j])
                {
                    i = 0;
                }
                if ((s[i] == str[j]))
                {
                    i++;
                }
                if (i == s.Length) return j - i + 1;
            }
            return -1;
        }
        public static bool MyContains(this string str, string st)
        {
            if (st.Length > str.Length) return false;
            int i = 0;
            for (int j = 0; j < str.Length; j++)
            {
                if (i > 0 && st[i] != str[j])
                {
                    i = 0;
                }
                if (st[i] == str[j])
                {

                    i++;
                }
                if (i == st.Length) return true;
            }
            return false;
        }
        public static string[] MySplit(this string str, string st)
        {

            if (!(str.Contains(st)))
            {
                string[]? arr = { str };
                return arr;
            }
            int i = 0;
            List<string> array = new List<string>();
            StringBuilder temp = new StringBuilder();
            
            for (int j = 0; j < str.Length; j++)
            {
                if (i > 0 && st[i] != str[j])
                {
                    i = 0;
                }
                if (st[i] == str[j])
                {
                    i++;
                }
                if (i == 0)
                {
                    temp.Append(str[j]);
                    
                }
                if (i == st.Length || j+1==str.Length)
                {
                    i = 0;
                    array.Add(temp.ToString());
                    temp = new StringBuilder();
                }
            }
            i = 0;
            string[] tarr = array.ToArray();
            return tarr;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!".MySubString(1, 3));
            Console.WriteLine("Hello Friends....How are you...".MyIndexOf("Hello Friends....How are you..."));
            Console.WriteLine("abcabc".MyContains("cab"));
            string[] arr = "\"C:\\Users\\ASUS\\OneDrive - National Polyechnic University of Armenia\\Desktop\\hc".MySplit("\\");
            Console.WriteLine($"{arr.Length}");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{arr[i]}");
            }
        }
    }
}
