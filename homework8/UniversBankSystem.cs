namespace UniversBankAccount
{
    internal class UniversBankSystem
    {
        public class BankSytstem
        {
            private string Id;
            public string Name;
            private double Balance;

            public BankSytstem(string id, string name, double balance)
            {
                this.Id = id;
                this.Name = name;
                this.Balance = balance;
            }

            public void WithDraw(double amount)
            {
                if (amount <= Balance)
                {
                    Balance -= amount;
                }
                else
                {
                    Console.WriteLine("You have not such money");
                }
            }

            public void Deposit(double amount)
            {
                if (amount < 0)
                {
                    Console.WriteLine("Amount cant be negative");
                }
                else
                {
                    Balance += amount;
                }
            }

            public void BalanceTraverser(ref BankSytstem b, double amount)
            {
                if (Balance >= amount)
                {
                    Balance -= amount;
                    b.Balance += amount;
                }
                else
                {
                    Console.WriteLine("Traversal failed");
                }
            }

            public void PrintInfo()
            {
                Console.WriteLine($"Id: {Id}  Name: {Name} Balance: {Balance}");
            }

            public  static void CastDollar(ref BankSytstem a)
            {
                double d = a.Balance * 450;
                Console.WriteLine($"Balance in dollars: {d}");
            }
        }

        static void Main(string[] args)
        {
            BankSytstem acc = new BankSytstem("125546", "Harry", 12);
            Console.WriteLine("Print before deposit");
            acc.PrintInfo();
            acc.Deposit(10.0);
            Console.WriteLine("After deposit 10");
            acc.PrintInfo();
            acc.WithDraw(15.0);
            Console.WriteLine("Withdraw 15");
            acc.PrintInfo();

            BankSytstem acc1 = new BankSytstem("123456", "Arkadik", 12);
            Console.WriteLine("Second account");
            acc1.PrintInfo();
            acc.BalanceTraverser(ref acc1, 5);
            Console.WriteLine("Traverse acc1 from acc2, 5");
            acc.PrintInfo();
            acc1.PrintInfo();

            BankSytstem.CastDollar(ref acc);
        }
    }
}
