using MyString;
using System;
using System.Threading.Tasks.Dataflow;
namespace MyString
{
    class Program
    {
        static void Main()
        {
            MyString str1 = new MyString(new char[] { 'H', 'e', 'l', 'l', 'o' });
            MyString str2 = new MyString('A', 5);
            MyString str3 = new MyString(str1, 1, 3); 

            Console.WriteLine("str1: " + new string(str1.ToLower().Str));
            Console.WriteLine("str2: " + new string(str2.Str));
            Console.WriteLine("str3: " + new string(str3.Str));

            Console.WriteLine("str1 == str3: " + (str1 == str3));
            Console.WriteLine("str1 != str2: " + (str1 != str2));

            MyString concatStr = str1 + str2;
            Console.WriteLine("Concatenation: " + new string(concatStr.Str));

            MyString joinedStr = str1.Join('-', str2, str3);
            Console.WriteLine("Joined: " + new string(joinedStr.Str));

            Console.WriteLine("Uppercase: " + new string(str1.ToUpper().Str));
            Console.WriteLine("Lowercase: " + new string(str1.ToLower().Str));

            Console.WriteLine("Starts with 'He': " + str1.StartWith(new char[] { 'H', 'e' }));
            Console.WriteLine("Ends with 'lo': " + str1.EndsWith(new char[] { 'l', 'o' }));
        }
    }
}
