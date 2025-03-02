using System.Text;

namespace BigInt
{

    public class BigInt
    {
        private string lnum;
        private bool sign;
        private bool IsValid(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if ((s[i] >= '0' && s[i] <= '9') || s[0] == '-')
                {
                    continue;
                }

                else
                {
                    return false;
                }
            }

            return true;
        }
        public BigInt(string s)
        {
            if (IsValid(s))
            {
                if (s[0] == '-')
                {
                    sign = false;
                    lnum = s.Substring(1);

                }
                else
                {
                    lnum = s;
                    sign = true;
                }
            }

            else
            {
                Console.WriteLine("Baxtd chberec aziz");
            }
        }
        public BigInt(int num)
        {
            if (num < 0)
            {
                num *= -1;
                sign = false;
            }
            lnum = num.ToString();
        }
        public int Length
        {
            get { return lnum.Length; }
        }
        public override string ToString()
        {
            if (sign)
                return $"{lnum}";
            return $"-{lnum}";
        }
        public static BigInt operator +(BigInt obj, BigInt obj1)
        {
            if (obj.lnum==obj1.lnum && obj.sign!=obj1.sign)
            {
                return new BigInt("0");
            }
            int objl = obj.Length;
            int obj1l = obj1.Length;
            int sum = 0;
            int carry = 0;
            int max;
            if (objl > obj1l)
            {
                max = objl;

            }
            else
            {
                max = obj1l;

            }
            StringBuilder s = new StringBuilder();

            if ((obj.sign == obj1.sign))
            {

                while (objl > 0 || obj1l > 0 || carry > 0)
                {
                    int abit = 0, bbit = 0;
                    if (objl > 0)
                    {
                        abit = obj.lnum[--objl] - '0';
                    }
                    else
                    {
                        abit = 0;
                    }
                    if (obj1l > 0)
                    {
                        bbit = obj1.lnum[--obj1l] - '0';

                    }
                    else
                    {
                        bbit = 0;
                    }
                    sum = (abit + bbit + carry) % 10;
                    carry = (abit + bbit + carry) / 10;
                    max--;

                    s.Insert(0, sum.ToString());
                }




            }
            else
            {
               // Console.WriteLine("babam");
                BigInt a = new BigInt(obj.lnum);
                BigInt b = new BigInt(obj1.lnum);
                bool resSign = true;
                if (string.Compare(obj.lnum, obj1.lnum, StringComparison.Ordinal) < 0)
                {
                   // Console.WriteLine("Im here");
                    resSign = a.sign = b.sign = obj1.sign;
                }
                else
                {
                    resSign = a.sign = b.sign = obj.sign;
                }
                BigInt res1 = a - b;
                res1.sign = resSign;
                return res1;
            }
            BigInt res = new BigInt(s.ToString());
            if (obj.sign == false && obj1.sign == false)
            {
                res.sign = false;
            }

            return res;
        }
        public static BigInt operator *(BigInt a, BigInt b)
        {
            if (a.lnum == "0" || b.lnum == "0") return new BigInt("0");
            int c = 0;
            int product = 1;
            StringBuilder s = new StringBuilder();
            int alen = a.Length;
            int blen = b.Length;
            int max = 0;
            int min = 0;
            StringBuilder smax = new StringBuilder();
            StringBuilder smin = new StringBuilder();
            StringBuilder res = new StringBuilder();
            if (alen > blen)
            {
                smax = new StringBuilder(a.lnum);
                max = alen;
                smin = new StringBuilder(b.lnum);
                min = blen;
            }
            else
            {
                smax = new StringBuilder(b.lnum);
                max = blen;

                smin = new StringBuilder(a.lnum);
                min = alen - 1;
            }
            BigInt result = new BigInt("0");
            int k = 0;
            while (min >= 0)
            {
                res.Clear();
                c = 0;
                for (int i = max - 1; i >= 0; i--)
                {

                    product = ((smax[i] - '0') * (smin[min] - '0')) % 10 + c;
                    c = (smax[i] - '0') * (smin[min] - '0') / 10;
                    res.Insert(0, product);
                }
                if (c != 0)
                {
                    res.Insert(0, c);
                }
                int q = k;
                while (q > 0)
                {
                    res.Append(0);
                    q--;
                }
                k++;
                result = result + new BigInt(res.ToString());
                min--;
            }

            result.sign = (a.sign == b.sign) ? true : false;
            return result;
        }
        public static BigInt operator -(BigInt obj, BigInt obj1)
        {
            if (obj == obj1) return new BigInt("0");
            if (obj.sign != obj1.sign)
            {

                BigInt b = (obj.sign == false) ? new BigInt(obj1.lnum) : new BigInt(obj.lnum);
                b.sign = false;
                b = (obj.sign == false) ? (b + obj) : (b + obj1);
                b.sign = obj.sign;
                return b;

            }
            StringBuilder smax = new StringBuilder();
            StringBuilder smin = new StringBuilder();
            bool resultSign = true;

            if (obj.Length == obj1.Length)
            {
                int result1 = string.Compare(obj.lnum, obj1.lnum, StringComparison.Ordinal);
                if (result1 > 0)
                {
                    smax.Append(obj.lnum);
                    smin.Append(obj1.lnum);
                    resultSign = obj.sign;
                }
                else if (result1 < 0)
                {
                    smax.Append(obj1.lnum);
                    smin.Append(obj.lnum);
                    resultSign = !obj.sign;
                }
                else
                {
                    return new BigInt("0");
                }
            }
            else if (obj.Length > obj1.Length)
            {
                smax.Append(obj.lnum);
                smin.Append(obj1.lnum);
                resultSign = obj.sign;
            }
            else
            {
                smax.Append(obj1.lnum);
                smin.Append(obj.lnum);
                resultSign = !obj.sign;
            }

            StringBuilder s = new StringBuilder();
            int max = smax.Length - 1;
            int min = smin.Length - 1;
            int borrow = 0;

            while (max >= 0)
            {
                int digit1 = smax[max] - '0';
                int digit2 = (min >= 0) ? smin[min] - '0' : 0;

                digit1 -= borrow;

                if (digit1 < digit2)
                {
                    digit1 += 10;
                    borrow = 1;
                }
                else
                {
                    borrow = 0;
                }

                s.Insert(0, (digit1 - digit2).ToString());

                max--;
                min--;
            }

            while (s.Length > 1 && s[0] == '0')
            {
                s.Remove(0, 1);
            }

            BigInt res = new BigInt(s.ToString());
            res.sign = resultSign;
            return res;
        }


    
    public static bool operator ==(BigInt a, BigInt b) {
            if (a.Length != b.Length || a.sign != b.sign)
            {
                return false;
            }
            else
            {
                int res = string.Compare(a.lnum, b.lnum, StringComparison.Ordinal);
                if (res == 0)
                {
                    return true;
                }

            }
            return false;
        }
        public static bool operator !=(BigInt a, BigInt b) {
            if (a.Length != b.Length || a.sign != b.sign)
            {
                return true;
            }
            else
            {
                int res = string.Compare(a.lnum, b.lnum, StringComparison.Ordinal);
                if (res == 0)
                {
                    return false;
                }

            }
            return true;

        }
        public static BigInt  Abs(BigInt a)
        {

            BigInt res = new BigInt(a.lnum);
            res.sign = !a.sign;
            return res;
        
        }
        public static bool operator <(BigInt a,BigInt b)
        {
            if(a.sign==false && b.sign == true)
            {
                return true;
            }
            
            if((a.sign==b.sign==false && string.Compare(a.lnum, b.lnum, StringComparison.Ordinal)>0 || a.sign == b.sign == true && string.Compare(a.lnum, b.lnum, StringComparison.Ordinal) < 0))
            {
                return true;
            }

            return false;
        }
        public static bool operator >(BigInt a, BigInt b)
        {
            if (a.sign == false && b.sign == true) return false;
            if ((a.sign == b.sign == true && a.Length > b.Length )||(a.sign == b.sign == false && a.Length < b.Length)) return true;
            if ((a.sign == b.sign == false && string.Compare(a.lnum, b.lnum, StringComparison.Ordinal) <0) || (a.sign == b.sign == true && string.Compare(a.lnum, b.lnum, StringComparison.Ordinal) > 0))
            {
                return true;
            }

            return false;
        }
        public static bool operator >=(BigInt a,BigInt b)
        {
            if (a>b || a==b)
            {
                return true;
            }
            return false;
        }
        public static bool operator <=(BigInt a, BigInt b)
        {
            if (a < b || a == b)
            {
                return true;
            }
            return false;
        }
        public  bool CompareTo(BigInt other)
        {
            if (this==other)
            {
                return true;
            }
            return false;
        }
    }
    internal class Program
{
        static void Main(string[] args)
        {
            BigInt b = new BigInt("20");

            Console.WriteLine($"b= {b.ToString()}");

            BigInt c = new BigInt("-20");
            Console.WriteLine($"c = {c.ToString()}");
            BigInt e = b + c;
            Console.WriteLine($"{b.ToString()} + {c.ToString()} = {e.ToString()}");
            BigInt s = b - c;
            Console.WriteLine($"{b.ToString()} -{c.ToString()} = {s.ToString()}");
            BigInt pr = b * c;
            Console.WriteLine($"{b.ToString()} * {c.ToString()} = {pr.ToString()}");
            Console.WriteLine("b=<c?");
            if (b < c)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            Console.WriteLine("b>=c?");
            if (b > c)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            Console.WriteLine("is b equal c(b=c)");
            Console.WriteLine(b.CompareTo(c) ? "Yes" : "No");
        }
    }
}