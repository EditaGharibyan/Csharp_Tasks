namespace User_Notification
{
    public class UserNotification
    {
        private int userid { get; }
        private string[]? notifications;
        public UserNotification(int uid, string[] not)
        {
            userid = uid;
            notifications = not;
        }
        public int userId
        {
            get
            {
                return userid;
            }
        }
        public string[]? notification
        {
            set {
                notifications = value;
            }
            get
            {
                return notifications;
            }
        }


    }

    public class Service
    {
        private UserNotification[]? usernotifications;
        public Service(UserNotification[] u)
        {
            usernotifications = u;
        }
        public string[]? GetNotifications(int uid)
        {
            foreach (UserNotification? item in usernotifications)
            {
                if (item.userId == uid)
                {
                    return item.notification;
                }
            }
            return null;
        }
        public void PushNotification(int uid,string str)
        {
            foreach (UserNotification? item in usernotifications)
            {
                if (item.userId == uid && item.notification!=null) 
                {
                    int l = item.notification.Length;
                    string[] ss = new string[l + 1];
                    for (int i = 0; i < l; i++)
                    {
                        ss[i] = item.notification[i];
                    }
                    ss[l] = str;
                    item.notification = ss;
                    foreach (string item1 in item.notification)
                    {
                        Console.Write($"{item1}" + " ");
                    }
                }
                
            }
            

        }
        
    }
    internal class UserNotifications
    {
        static void Main(string[] args)
        {
            string[] s = { "Hello", "Dear", "Kima", "Jan!" };

            string[] s1 = { "Woxjuyn", "Sireli", "Kima", "Jan" };
            string[] s2 = { "Guten Tag", "Liebe", "Kima", "Jan" };
            UserNotification u = new UserNotification(1, s);
            UserNotification u1 = new UserNotification(3, s1);
            UserNotification u2 = new UserNotification(2, s2);
            UserNotification[] group = { u, u1, u2 };
            Service n = new Service(group);
            string[]? res = n.GetNotifications(2);
            if (res != null)
            {
                foreach (string item in res)
                {
                    Console.Write($"{item}" + " ");
                }
            }
            else
            {
                Console.WriteLine("No notifications found.");
            }
            Console.WriteLine();
            n.PushNotification(2, "!");
        }
    }
}