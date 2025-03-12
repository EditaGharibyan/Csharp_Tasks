
namespace Contact_List
{
    public class Person
    {
        public int ID;
        public string Name;
        public Person(string name,int id)
        {
            this.ID = id;
            this.Name = name;
        }
        public override string ToString()
        {
            //if(this==null) return "null";
            return $"{this.ID}  { this.Name} ";
        }
    }
    public class ContactList
    {
        public Person[] p;
        public ContactList(Person[] arr) {
            p = arr;
        }
        public Person this[string n]
        {
            get {
                foreach (var item in p)
                {
                    if (item.Name==n)
                    {
                        return item;
                    }
                }

                return null;
            }
        }
        public Person this[int i]
        {
            get
            {
                foreach (var item in p)
                {
                    if (item.ID == i )
                    {
                        return item;
                    }
                }

                return null;
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person a = new Person("Edita", 12563);
            Person b = new Person("Edik", 12563);
            Person c = new Person("Erika", 125);
            Person[] l = new Person[] {a, b, c};
             ContactList li= new ContactList(l);
            Person res =li["Eita"];
            Person res1 =li[125];
            if(res!=null && res1 != null)
            {
                Console.WriteLine(res.ToString() + res1.ToString());
            }
            else
            {
                Console.WriteLine("No such Contact");
            }
            

        }
    }
}
