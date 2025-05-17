using System.Runtime.CompilerServices;

namespace Group_Student
{
    public class Student
    {
        private string name;
        private int age;
        private double gpa;
        public Student(string Name, int Age, double Gpa)
        {
            name = Name;
            age = Age;
            gpa = Gpa;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Student other = (Student)obj;
            return this.Age == other.Age && this.Name == other.Name && this.gpa == other.gpa;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public int Age
        {
            get => age;
        }
        public double GPA
        {
            get => gpa;
            set => gpa = value;
        }

    }
    public class Group
    {
        private List<Student> students = new();
        public Group(List<Student> students)
        {
            this.students = students;
        }
        public int StudentsCount { get => students.Count; }

        public static Group operator +(Group obj, Group obj1)
        {
            List<Student> temp = new List<Student>();
            temp.AddRange(obj.students);
            temp.AddRange(obj1.students);
            Group tmp = new Group(temp);
            return tmp;
        }
        public static Group operator -(Group op, Group op1)
        {
            List<Student> tmp = new List<Student>();
            Console.WriteLine($"{op1.students.Count}");
            for (int i = 0; i < op.students.Count; i++)
            {
                bool flag = false;
                for (int j = 0; j < op1.students.Count; j++)
                {

                    if ((op.students[i]).Equals(op1.students[j]))
                    {
                     //   Console.WriteLine("Yes");
                        //  op.students.Remove(op1.students[i]);
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    tmp.Add(op.students[i]);

                }
            }
            Group res = new Group(tmp);
            return res;

        }
        public static bool operator true(Group st)
        {
            return st.students.Count > 1;
        }
        public static bool operator false(Group st)
        {
            return !(st.students.Count > 1);
        }
        public void Print()
        {
            for (int i = 0; i < this.students.Count; i++)
            {
                Console.Write($"{this.students[i].Name}  ");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> myst = new List<Student>()
            {   new Student ( "Valod", 15, 12.5 ),
                new Student("Mari",25,62.5),
                new Student("Anna",28,96)
            };

            Group mygroup = new Group(myst);
            if (mygroup)
            {
                Console.WriteLine($"Mygroup is not empty,there are {mygroup.StudentsCount} students");
            }
            List<Student> c = new List<Student>();
            Group g = new Group(c);
            if (g)
            {
                Console.WriteLine("g is not empty");
            }
            List<Student> myst1 = new List<Student>()
            {
                new Student ( "Vika", 15, 12.5 ),
                new Student("Mariam",25,62.5),
                new Student("Anna",28,96)
            };
            Group gr2 = new Group(myst1);
            Group addgr = mygroup + gr2;
            Group subgr = mygroup - gr2;
            addgr.Print();
            subgr.Print();

        }
    }
}
