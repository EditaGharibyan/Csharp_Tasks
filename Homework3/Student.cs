namespace StudentManagment1
{
    internal class Program
    {
        public class Student {

            public string Name;
            public string StudentId;
            public string GradeLevel;
            public Student() {
                Name = "Anun";
                StudentId = "125847";
                GradeLevel = "Middle";
            
            }
            public void ShowStudent() {
                Console.WriteLine($"Name: {Name} \n StudnetId:{StudentId}\nGradeLevel {GradeLevel}");  
            
            }
        }
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Name = "Edita";
            s.StudentId = "123456";
            s.GradeLevel = "Gerazancik";
            s.ShowStudent();
        }
    }
}
