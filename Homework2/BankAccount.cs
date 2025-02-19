namespace Bank_Account
{


    public class BankAccount
    {
        public string AccountNumber;
        public string HoldeName;
        public float Balance;
        public void Deposit(float amount)
        {
            Balance += amount;
            Console.WriteLine($"Your Balance now is {Balance}");
        }
        public void Withdraw(float amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Sth is wrong");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine($"Your Balance now is {Balance}");
            }

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            BankAccount account = new BankAccount();
            Console.WriteLine("Your AccountNumber");
            account.AccountNumber = Console.ReadLine();
            Console.WriteLine("Your holdName");
            account.HoldeName = Console.ReadLine();
            Console.WriteLine("Your Balance");
            account.Balance = float.Parse(Console.ReadLine());
            Console.WriteLine("Amount for deposit");
            float amount = float.Parse(Console.ReadLine());
            Console.WriteLine("amount for withdraw");
            account.Deposit(amount);
            float amount1 = float.Parse(Console.ReadLine());
            account.Withdraw(amount1);


        }
    }
}
