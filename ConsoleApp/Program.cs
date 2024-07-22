using System.Text;

namespace UsernamesToFileApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using (StreamWriter sw = File.AppendText(@"D:\C#\textFiles.txt")){
                Console.WriteLine("Enter the username");
                string data = Console.ReadLine();
                sw.WriteLine(data);
          
            }
            
        }
    }
}