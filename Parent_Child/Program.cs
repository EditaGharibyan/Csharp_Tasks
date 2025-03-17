namespace ParentChild
{
    public class Child
    {
        private string _name;
        private int _age;
        private Parent _father;
        private Parent _mather;
        public Child(string Name, int Age, Parent m, Parent f)
        {
            _name = Name;
            _age = Age;
            _mather = m;
            _father = f;
        }
        public Parent Mother
        {
            get { return _mather; }
        }

        public Parent Father
        {
            get { return _father; }
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public static double FindMaxAge(Child[] arr)
        {
            int max = int.MinValue;
            int maxInd = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]._age > max)
                {
                    max = arr[i]._age;
                    maxInd = i;
                }
            }
            return arr[maxInd]._father._salary;
        }
        public static string FindMaxBudje(Child[] arr)
        {
            int max = int.MinValue;
            int maxInd = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Father._salary + arr[i].Mother._salary > max)
                {
                    max = arr[i]._age;
                    maxInd = i;
                }
            }
            return arr[maxInd].Name;
        }
        public static void Swap(Child[] arr)
        {
            int max = int.MinValue;
            int maxInd = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]._age > max)
                {
                    max = arr[i]._age;
                    maxInd = i;
                }
            }
            int min = int.MaxValue;
            int minInd = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]._age < min)
                {
                    min = arr[i]._age;
                    minInd = i;
                }
            }
            Child temp = new Child(arr[maxInd].Name, arr[maxInd]._age, arr[maxInd].Mother, arr[maxInd].Father);
            arr[maxInd] = arr[minInd];
            arr[minInd] = temp;
        }
        public static void f(Child[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Mother.Age + arr[i].Father.Age <= 70)
                {
                    Console.WriteLine($"{arr[i].Name}");
                }
            }
        }
    }
    public class Parent
    {
        private string _name;
        private int _age;
        public double _salary;

        public Parent(string name, int age, double salary)
        {
            _name = name;
            _age = age;
            _salary = salary;
        }
        public int Age
        {
            get => _age;
        }

    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Parent m0 = new Parent("Mara", 35, 2500);
            Parent m1 = new Parent("Mariam", 30, 1500);
            Parent m2 = new Parent("Marina", 40, 1000);
            Parent f0 = new Parent("Gor", 35, 1000);
            Parent f1 = new Parent("John", 28, 1100);
            Parent f2 = new Parent("Ashot", 35, 1500);
            Child c = new Child("Anna", 3, m0, f0);
            Child c1 = new Child("Qnarik", 1, m1, f1);
            Child c2 = new Child("Rob", 4, m2, f2);
            Child c3 = new Child("Johny", 2, m0, f1);
            Child[] arr = { c, c1, c2, c3 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].Name);
            }
            Console.WriteLine("Hor u mor tariqy poqr e 70ic");
            Child.f(arr);
            Console.WriteLine(Child.FindMaxAge(arr));
            Console.WriteLine();
            Console.WriteLine(Child.FindMaxBudje(arr));
            Child.Swap(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].Name);
            }
        }
    }
}
