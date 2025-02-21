namespace Simulating_Course_Enrollment
{
    public class Course {
        public string CourseName;
        public string Instructor;
        public int MaxStudents;
        public Course(string name, string instructor, int max) {
            this.CourseName = name;
            this.Instructor = instructor;
            this.MaxStudents = max;

        }
        public void ShowCourseDetails() {
            Console.WriteLine($"CourseName: {CourseName} \n Instructor: {Instructor}\nMaxStudents: {MaxStudents}");
        }

    }

    
    internal class Program
    {
        static void Main(string[] args)
        {
            Course[] c = { new Course("Python","John",41) ,new Course("C++","Artur",25),new Course("C#","Hayk Hakobyan",30) };
            foreach (Course item in c)
            {
                item.ShowCourseDetails(); 
            }

        }
    }
}
