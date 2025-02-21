namespace Smart_Watch_StepCounter
{
    internal class Program
    {

        public class SmartWachtStepCounter
        {
            public string OwnerName;
            public int StepCount;
            public SmartWachtStepCounter() {
                OwnerName = "Valod";
                StepCount = 0;
            
            }
            public void AddSteps() {
                StepCount++;
            }
            public void ShowSteps() {
                Console.WriteLine($"Your cUrrently step={StepCount}");
            }
        }
        static void Main(string[] args)
        {
            SmartWachtStepCounter obj = new SmartWachtStepCounter();
            obj.AddSteps();
            obj.AddSteps();
            obj.AddSteps();
            obj.AddSteps();
            obj.AddSteps();
            obj.ShowSteps();
            obj.AddSteps();
            obj.AddSteps();
            obj.AddSteps();
            obj.AddSteps();
            obj.ShowSteps();

        }
    }
}
