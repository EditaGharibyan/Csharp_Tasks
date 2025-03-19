using System.Security.Cryptography.X509Certificates;

namespace Academia2._0
{
    public class Course
    {
        private string name;
        protected double payment;
        private Module[] moduls;
        public Course(string Name, double pay, Module[] module)
        {
            name = Name;
            payment = pay;
            moduls = new Module[module.Length];
            for (int i = 0; i < module.Length; i++)
            {
                moduls[i] = module[i];
            }

        }
        public double Pay => payment;

    }
    public class Module
    {
        private string name;
        private int duration;
        public Module(string Name, int Dur)
        {
            name = Name;
            duration = Dur;
        }
    }
    public class Group
    {
        private string name;
        private int countOfStudents;
        private Course course;
        public Group(string name, int countOfStudents, Course course)
        {
            this.name = name;
            this.countOfStudents = countOfStudents;
            this.course = course;
        }
        public static int CountofWebStudents(Group[] arr)
        {
            int i = 0;
            foreach (Group item in arr)
            {
                if (item.course is Web)
                {
                    i++;
                }
            }
            return i;
        }
        public static double GeneralPayment(Group[] arr)
        {
            double money = 0;
            foreach (Group item in arr)
            {
                if (item.course is Game gameCourse)

                {
                    if (gameCourse.Engine != null && gameCourse.Engine.ToLower() == "unreal")
                        money += gameCourse.Pay;
                }
            }
            return money;
        }
        public static void DemandingCourse(Group[] arr)
        {
            int gameCount = 0;
            int webCount = 0;
            int aiCount = 0;
            foreach (Group item in arr)
            {
                if (item.course is Game)
                {
                    gameCount += item.countOfStudents;
                }
                else if (item.course is Web)
                {
                    webCount += item.countOfStudents;
                }
                else
                {
                    aiCount += item.countOfStudents;
                }
            }
            if (gameCount > webCount && gameCount > aiCount) Console.WriteLine("Game is most demanding");
            else if (gameCount < webCount && webCount > aiCount) Console.WriteLine("Game is most demanding");
            else
            {
                Console.WriteLine("ai is most demanding");

            }

        }
    }
    public class Web : Course
    {
        private string type;
        public Web(string type, double pay, string Name, Module[] module) : base(Name, pay, module)
        {

            this.type = type;
        }
    }
    public class Game : Course
    {
        private string engine;
        public Game(string name, double pay, string eng, Module[] module) : base(name, pay, module)
        {
            engine = eng;
        }
        public string Engine => engine;
        public double Pay
        {
            get { return payment; }
        }
    }
    public class AI : Course
    {
        public AI(string Name, double pay, Module[] module) : base(Name, pay, module)
        {
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {

            Course[] courses = new Course[]
     {
    new Web("Frontend Development", 500, "frontend", new Module[]{ new Module("HTML & CSS", 2), new Module("JavaScript", 3)}),
    new Web("Fullstack Development", 60000, "fullstack", new Module[] { new Module("Node.js", 4), new Module("React", 5)}),
    new AI("Machine Learning", 80000, new Module[]
    {
        new Module("Python for AI", 6), new Module("Deep Learning", 8)
    }),
    new Game("Game Development", 72000, "Unity", new Module[]
    {
        new Module("C# for Unity", 5), new Module("Physics in Games", 4)
    }),
    new Game("Game Dev Advanced", 42000, "Unreal", new Module[]
    {
        new Module("Blueprints", 6), new Module("C++ for Unreal", 7)
    })
  };
            Group[] groups = new Group[]
            {
                 new Group("Frontend Group 1", 15, courses[0]),
                 new Group("Fullstack Group 1", 12, courses[1]),
                 new Group("AI Group 1", 10, courses[2]),
                 new Group("Game Dev Group 1", 20, courses[3]),
                 new Group("Game Dev Group 2", 18, courses[4])
             };
            int res = Group.CountofWebStudents(groups);
            Console.WriteLine($"Count of web students: {res}");
            double genc = Group.GeneralPayment(groups);
            Console.WriteLine($"result2: {genc}");
            Group.DemandingCourse(groups);

        }
    }
}
