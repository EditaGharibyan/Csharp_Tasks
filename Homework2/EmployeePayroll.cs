namespace Employee_Payroll_System
{
    public class Employee
    {
        public string Name;
        public string Position;
        public float SalaryPerHour;
        public float HoursWorked;
        public Employee() {
            Name = "Aram";
            Position = "Middle";
            SalaryPerHour=55.55f;
            HoursWorked = 125f;
            
        }
        public double CalcualateSalary()
        {
            if (HoursWorked >= 40)
            {
                return SalaryPerHour * HoursWorked*1.5;
            }
            return SalaryPerHour * HoursWorked;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] emp = new Employee[3];
            for(int i = 0; i < emp.Length; i++)
            {
                emp[i] = new Employee();
                Console.WriteLine($"Enter name of employe{i}");
                emp[i].Name = Console.ReadLine();
                Console.WriteLine("Enter position of this Employee");
                emp[i].Position = Console.ReadLine();
                Console.WriteLine("Enter SalayPerHour");
                emp[i].SalaryPerHour=float.Parse(Console.ReadLine());
                Console.WriteLine("Enter Hoursworked");
                emp[i].HoursWorked = float.Parse(Console.ReadLine());
            }
            for (int i = 0; i < emp.Length; i++)
            {
                double salary= emp[i].CalcualateSalary();
                Console.WriteLine($"sazlari {i}-th Empolee is {salary}");
            }
        }
    }
}
