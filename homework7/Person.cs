namespace Person
{
    public class Person
    {
        public string Name { get; set; }
        public string Lname { get; set; }
        private string ful_name;
        public Person(string n_name, string _lname)
        {
            Name = n_name;
            Lname = _lname;
        }
        public string FullName
        {

            get
            {
                if (ful_name == null)

                {
                    ful_name = $"{Name} {Lname}";

                }
                return ful_name;
            }


        }
    }
    internal class Person
    {
        static void Main(string[] args)
        {
            Person p = new Person("John", "Doe");
            string a=(p.FullName);
            p.Name = "Hello";
            p.Lname = "Yan";
            Console.WriteLine("FullName is " + p.FullName);

        }
    }
}


