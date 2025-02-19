namespace Student_manager
{
    public class Student{
        public string name;
        public int age;
        public float grade;
        public Student()
        {
            name = "Hello";
            age = 18;
            grade = 99.9f;
        }
        public void DisplayDetails() {
            Console.WriteLine($"Name is {name},age {age} grade {grade}");
        
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Student[] student = new Student[2];
            for (int i = 0; i < student.Length; i++) {
                student[i] = new Student();
                student[i].name = Console.ReadLine();
                student[i].age =int.Parse( Console.ReadLine());
                student[i].grade = float.Parse(Console.ReadLine());
            }
            for (int i = 0; i < student.Length; i++)
            {
                student[i].DisplayDetails();
            }
            Console.WriteLine("Hello, World!");
        }
    }
}
