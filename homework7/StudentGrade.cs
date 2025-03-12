namespace StudentGrades
{
    public class Students
    {
        private string[] subjects ;

        private int[] grades;
        public Students(string[] subj, int[] arr){
            grades = arr;
            subjects = subj;
        }
        public int this[string subName]
        {
            get {
                for(int i = 0; i < subjects.Length; i++)
                {
                    if (subjects[i].ToLower() == subName.ToLower())
                    {
                        return grades[i];
                    }
                }
                return -1;
            }
          
        }


    }
    internal class StudentGrade
    {
        static void Main(string[] args)
        {
            int[] g = new int[]{15, 20, 30, 50};
            string[] subject = new string[] { "Math", "Chimie", "English", "Rusian" };
            Students s = new Students(subject,g);

            int grade =s["math"];
            Console.WriteLine(grade);
    
        }
    }
}
