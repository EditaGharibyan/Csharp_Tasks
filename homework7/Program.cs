namespace Time_Period
{
    public class Time_Period
    {
        private  int TotalSeconds;
        public Time_Period(int sec)
        {
            TotalSeconds = sec;
        }
        public string FormattedTime
        {
            get
            {
                return $"{TotalSeconds / 3600} : {TotalSeconds%3600/60} : {TotalSeconds % 3600 % 60}";
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Time_Period t = new Time_Period(3808);
            Console.WriteLine("Time is "+t.FormattedTime);
            

        }
    }
}
