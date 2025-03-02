namespace BankAccountwithCS
{
    public class BankAccount
    {
        private string AccountNumber;
        private float Balance;
        public BankAccount(string a,float f)
        {
            AccountNumber = a;
            Balance = f;
        }

        public override string ToString()
        {
            return $"Account {AccountNumber},Balance {Balance}";
        }
        public override bool Equals(object obj)
        {
            if (obj is BankAccount other)
                return this.AccountNumber == other.AccountNumber;
            return false;
        }
        public override int GetHashCode()
        {
            int hash = 18;
            
            hash = hash * 31 + AccountNumber.GetHashCode();
            hash = hash * 31 + Balance.GetHashCode();
            return hash;
        }
        public static BankAccount operator +(BankAccount obj,float Money)
        {
            BankAccount res = new BankAccount(obj.AccountNumber,obj.Balance);
            res.Balance = obj.Balance + Money;
            return res;
        }
        public static BankAccount operator -(BankAccount obj, float Money)
        {
            BankAccount res = new BankAccount(obj.AccountNumber, obj.Balance);
           
            res.Balance = obj.Balance - Money;
            return res;
        }
        public static bool operator <(BankAccount obj, BankAccount obj1)
        {
            return obj.Balance < obj1.Balance;
            
        }
        public static bool operator >(BankAccount obj, BankAccount obj1)
        {
            return obj.Balance < obj1.Balance;

        }
        public static bool operator <=(BankAccount obj, BankAccount obj1)
        {
            return obj.Balance <= obj1.Balance;

        }
        public static bool operator >=(BankAccount obj, BankAccount obj1)
        {
            return obj.Balance <=obj1.Balance;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount myBankAccount=new BankAccount("5213635463",76.5f);
            BankAccount myBankAccount1=new BankAccount("21363546",1512.5f);
            Console.WriteLine($"{myBankAccount.ToString()}");
            myBankAccount =myBankAccount + 150.5f + 15.5f;
            Console.WriteLine($"{myBankAccount.ToString()}");
            if(myBankAccount>myBankAccount1) Console.WriteLine("mybankaccount is great than mybankaccount1");
            if(myBankAccount<myBankAccount1) Console.WriteLine("mybankaccount is lower than mybankaccount1");
            myBankAccount1 = myBankAccount1 - 512.5f;
            Console.WriteLine($"{myBankAccount1.ToString()}");


        }
    }
}
