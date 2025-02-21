namespace File_Download_Simulation
{
    public class FileDownload {
        public FileDownload() {

            Console.WriteLine("Download started");
        }
       ~FileDownload() {
            Console.WriteLine("Download completed");
        }
    
    }
   
    internal class Program
    {
        public static void CreateObj()
        {
            FileDownload f = new FileDownload(); ;
        }
        static void Main(string[] args)
        {
            CreateObj();
            
        }
    }
}
