using System.Text;

namespace FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //For writing the content into file....
            FileStream fWrite = new FileStream(@"D:\C#\FileHandle.txt", FileMode.Create, FileAccess.Write, FileShare.None);
            var text = "This is my file handling poc file...";
            byte[] writeArr = Encoding.UTF8.GetBytes(text);
            fWrite.Write(writeArr, 0, text.Length);
            fWrite.Close();

            //For reading the content from the file...
            FileStream fRead = new FileStream(@"D:\C#\FileHandle.txt", FileMode.Open, FileAccess.Read, FileShare.Read);
            byte[] readArr=new byte[text.Length];
            int count;
            while ((count= fRead.Read(readArr, 0, readArr.Length)) > 0)
            {
                Console.WriteLine(Encoding.UTF8.GetString(readArr, 0, count));
            }

            fRead.Close();
            Console.ReadKey();

        }
    }
}
