using System.Threading.Tasks.Dataflow;

namespace MyString{
    public class MyString
    {
        private char[]? _str;
        public int Length
        {
            get { return _str.Length; }
        }
    
        public char[]  Str
        {
            get
            {
                return _str;
            }
        }
        public char this[int ind]
        {
            get
            {
                if (ind >= 0 && ind < Length)
                {
                    return _str[ind];
                }
                return '0';
            }
        }

        public MyString()
        {
            _str = null;
        }
        public MyString(char[] str)
        {
            _str = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                _str[i] = str[i];
            }
        }
        public MyString(char a, int count)
        {
            _str = new char[count];
            for (int k = 0; k < count; k++)
            {
                _str[k] = a;
            }
        }

        public MyString(MyString s, int start, int len)
        {
            _str = new char[len];
            for (int i = 0; i < len; i++)
            {
                _str[i] = s[start];
                start++;
            }
        }

        public bool Empty()
        {
            return _str?.Length == 0;
        }
        public static int cmp(MyString s, MyString _m)
        {
            if (s.Length > _m.Length)
            {
                return 1;
            }
            else if (s.Length < _m.Length)
            {
                return -1;
            }
            int i = 0;
            foreach (char c in s._str)
            {

                if (_m[i] >c)
                {
                    return -1;
                }
                else if (_m[i]<c)
                {
                    return 1;
                }
                i++;
            }

            return 0;
        }
        public override bool Equals(object? obj)
        {
            if(obj is MyString other )
            {

                return obj==other;
            }
            return false;
        }
        public static  bool Equals(MyString m,MyString m1)
        {
            return m.Equals(m1);
        }
        public static bool operator ==(MyString m,MyString m1)
        {
            return cmp(m, m1) == 0;
        }
        public static bool operator !=(MyString m, MyString m1)
        {
            return cmp(m, m1) != 0;
        }
        public MyString Join(char c,params MyString[] m){

            int l = m.Length;
            int count = 0;
            Console.WriteLine(c);
            foreach (var item in m)
            {
                count += item.Length;
            }
            count += l - 1;
            char[] temp = new char[count];
            int k = 0;
            for (int i = 0; i < l; i++)
            {
                for(int j = 0; j < m[i].Length; j++)
                {
                    temp[k] = m[i]._str[j];
                    k++;
                }
                if (k != count)
                {
                    temp[k] = c;
                    k++;
                }
                
            }
            MyString res = new MyString(temp); 
            return res;
        }
        public static MyString operator +(MyString a,MyString b)
        {
            int l = a.Length + b.Length;
            char[] temp = new char[l];
            for (int i = 0; i < a.Length; i++)
            {
                temp[i] = a._str[i];
            }
            for (int i = 0; i < b.Length; i++)
            {
                temp[a.Length+i] = b._str[i];

            }
            MyString res = new MyString(temp);
            return res;
        }
        public bool StartWith(char[] c)
        {
            if (this.Length < c.Length) return false;
            int k = c.Length;
            for(int i = 0; i < this.Length; i++)
            {

                if (this._str[i] != c[i]) return false;
                k--;
                if (k == 0) return true;
            }
            return true;

        }
        public bool EndsWith(char[] c)
        {
            if (this.Length < c.Length) return false;
            int k = c.Length-1;
            for (int i = this.Length-1; i >=0; i--)
            {

                if (this._str[i] != c[k]) return false;
                k--;
                if (k == 0) return true;
            }
            return true;

        }
        public MyString ToLower()
        {
            char[] temp = new char[this.Length];
            int i = 0;
            foreach (char item in this._str)
            {
                if(item>='A' && item <= 'Z')
                {
                    temp[i] = (char)(item + 32);
                }
                else
                {
                    temp[i] = item;
                    
                }
                    i++;
            }
            return new MyString(temp);
        }
        public MyString ToUpper()
        {
            char[] temp = new char[this.Length];
            int i = 0;
            foreach (char item in this._str)
            {
                if (item >= 'a' && item <= 'z')
                {
                    temp[i] = (char)(item - 32);
                }
                else
                {
                    temp[i] = item;

                }
                i++;
            }
            return new MyString(temp);
        }
    }
}
   


