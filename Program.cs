using System.Linq;
using System.Collections;
using System.Security.Cryptography;
namespace LINQ
{
    public class Student
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public int DepartmentId { get; set; }
        public List<int> EnrolledCourseIds { get; set; } = new();
        public Student(int id, string? name, int depid, List<int> a)
        {
            Id = id;
            FullName = name;
            DepartmentId = depid;
            EnrolledCourseIds = a;
        }
    }
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
    public class Course
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int Credits { get; set; }
        public int DepartmentId { get; set; }
        public Course(int id, string? title, int credits, int departmentId)
        {
            Id = id;
            Title = title;
            Credits = credits;
            DepartmentId = departmentId;
        }
    }
    class Subject
    {
        public string? Name { get; set; }
        public int DepartmentId { get; set; }
        public Subject(string? name, int departmentId)
        {
            Name = name;
            DepartmentId = departmentId;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> enrol = new() { 5, 2, 3, 1 };
            List<int> enrol1 = new() { 1, 2, 3 };
            List<int> enrol2 = new() { 1, 3, 5 };
            var st = new List<Student>
{
new Student(1, "Edita Gharibyan", 1, new List<int> { 1, 2 }),
new Student(2, "Anna Harutyunyan", 2, new List<int> { 3, 4 }),
new Student(3, "John Smith", 1, new List<int> { 1 }),
new Student(4, "Aram Petrosyan", 3, new List<int> { 5 }),
new Student(5, "Lilit Sargsyan", 1, new List<int> { 3 }),
new Student(6, "Karen Sargsyan", 4, new List<int> { 7 }),
new Student(7, "Narek Hakobyan", 5, new List<int> { 6 }),
new Student(8, "Sona Davtyan", 1, new List<int> { 8 }),
new Student(9, "Harutyun Melkonyan", 7, new List<int> { 9 }),
new Student(10, "Marianna Avetisyan", 8, new List<int> { 10 }),
new Student(11, "Tigran Khachatryan", 1, new List<int> { 11 }),
new Student(12, "Tatevik Hovhannisyan", 10, new List<int> { 12 }),
new Student(13, "Hayk Ghazaryan", 1, new List<int> { 13 }),
new Student(14, "Arpine Grigoryan", 14, new List<int> { 14 }),
new Student(15, "Levon Manukyan", 15, new List<int> { 15 })
};


        var dep = new List<Department>
        {
            new Department(1, "Computer Science"),
            new Department(2, "Mathematics"),
            new Department(3, "Physics"),
            new Department(4, "Biology"),
            new Department(5, "Chemistry"),
            new Department(6, "Economics"),
            new Department(7, "Philosophy"),
            new Department(8, "Literature"),
            new Department(9, "History"),
            new Department(10, "Geography"),
            new Department(11, "Psychology"),
            new Department(12, "Sociology"),
            new Department(13, "Art"),
            new Department(14, "Law"),
            new Department(15, "Engineering")
        };

            var courses = new List<Course>
            {
                new Course(1, "Data Structures", 4, 1),
                new Course(2, "Algorithms", 3, 2),
                new Course(3, "Calculus", 4, 2),
                new Course(4, "Linear Algebra", 3, 2),
                new Course(5, "Quantum Mechanics", 5, 3),
                new Course(6, "Organic Chemistry", 4, 5),
                new Course(7, "Microbiology", 3, 4),
                new Course(8, "Macro Economics", 3, 6),
                new Course(9, "Ethics", 2, 7),
                new Course(10, "World Literature", 3, 8),
                new Course(11, "World History", 3, 9),
                new Course(12, "Geospatial Analysis", 3, 10),
                new Course(13, "Social Psychology", 3, 11),
                new Course(14, "Human Rights Law", 3, 14),
                new Course(15, "Electrical Circuits", 4, 15)
            };

            //Select Computer Scinece Students
            var cs = from item1 in st
                     where item1.DepartmentId == (
                        from item in dep
                        where item.Name == "Computer Science"
                        select item.Id).First()
                     select item1.FullName;

            foreach (var item5 in cs)
            {
                Console.WriteLine("Hello" + item5);
            }

            //TASK 2 Empty courses

            var cids = st.SelectMany(s => s.EnrolledCourseIds)
                    .Distinct();
            var emptyCourse = courses.Where(c => !cids.Contains(c.Id)).Select(c => c.Title);
            foreach (var item in emptyCourse)
            {

                Console.WriteLine($"{item.ToString()}");


            }
            //2rd tarberak
            var ids = from cour in courses
                      where !(
                      from stud in st
                      from i in stud.EnrolledCourseIds
                      select i).Distinct().Contains(cour.Id)
                      select cour.Title;
            var couseCS = from cours in courses
                          where cours.DepartmentId == (from d in dep
                                                       where d.Name == "Computer Science"
                                                       select d.Id).First()
                          select cours.Title;

            foreach (var item in couseCS)
            {
                Console.WriteLine($"{item.ToString()}");
            }
            var five = from depart in dep
                       where (
                       from s in st
                       group s by s.DepartmentId into g
                       where g.Count() > 5
                       select g.Key
                       ).Contains(depart.Id)
                       select depart.Name;
            Console.WriteLine("More than 5");
            foreach (var item in five)
            {
                Console.WriteLine($"{item.ToString()}");
            }
            var maxdep = from d in dep
                         where (from course in courses
                                group course by course.DepartmentId into g1
                                orderby g1.Count() descending
                                select g1.Key

                       ).First() == d.Id
                         select d.Name;
            Console.WriteLine("Department of max Count courses is ");
            foreach (var item in maxdep)
            {
                Console.Write($"{item.ToString()}");
            }


        }
    }


}
