namespace Fitness_Tracker_System
{
    public class WorkOutSession{
        public string ExerciseType;
        public int durationInMinutes;

        public WorkOutSession() {
            ExerciseType = "Run";
            durationInMinutes = 5;
        
        }
        public void ShowWorkoutDetails()
        {   
            Console.WriteLine($"Type of excercize is {ExerciseType}\nduration {durationInMinutes} Minutes");

        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            WorkOutSession w = new WorkOutSession();
            w.ExerciseType = "Weightlifting";
            w.durationInMinutes = 15;
            WorkOutSession e = new WorkOutSession();
            e.ExerciseType="Swimming";
            e.durationInMinutes = 60;
            w.ShowWorkoutDetails();
            e.ShowWorkoutDetails();

        }
    }
}
