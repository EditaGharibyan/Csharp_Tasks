namespace Basic_Calc
{

    internal class BasicCalc
    {


        public void Calc(int a,int b) {
            Console.WriteLine("Operation:");
            string oper = Console.ReadLine();
            if (oper == "X" ) return;
            switch (oper)
            {
                case "+":
                    Console.WriteLine($"{a}+{b}={a + b}");
                    break;
                case "-":
                    Console.WriteLine($"{a}-{b}={a - b}");
                    break;
                case "*":
                    Console.WriteLine($"{a}*{b}={a * b}");
                    break;
                case "/":
                    Console.WriteLine($"{a}/{b}={a / b}");
                    break;
            }
            
            Console.WriteLine("first operand");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Second Operand");
            b = int.Parse(Console.ReadLine());
            Calc(a, b);

        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            BasicCalc c=new BasicCalc();
            c.Calc(a,b);
            Console.WriteLine("Program end");
        }
    }
}
