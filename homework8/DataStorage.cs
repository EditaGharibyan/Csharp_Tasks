namespace MultiSecurDataStorage
{
    public enum perm {User,Admin,Guest };
    public class StorageSystem
    {
        private string message;
        public StorageSystem(string mess)
        {
            message = mess;

        }
        public string this [string m]
        {
           
            get{
                if(m.ToLower()=="admin" || m.ToLower()=="user")
                return message;
                return "You cant know about message";
            }
            set
            {
                string temp = m.ToLower();
               
                if (temp == "admin")
                {
                    message = m;
                }
                else
                {
                    Console.WriteLine("You cant set value");
                }
            }

        } 
    }
    internal class DataStorage
    {
        static void Main(string[] args)
        {
            StorageSystem m = new StorageSystem("This is message");
            m["admin"] ="Admin";
            Console.WriteLine(m["admin"]);
            StorageSystem m1 = new StorageSystem("This is user");
            m1["user"] = "User";
            Console.WriteLine(m1["User"]);
        }
    }
}
