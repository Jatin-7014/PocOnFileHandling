namespace PocFileHandlingHtml
{
    internal class Program
    {
        static string filePath = @"D:\C#\PocFileHandlingHtml\output.html";
        static void Main(string[] args)
        {


            // Example HTML content to write
            writeHtml();
            readHtml();


        }

        static void writeHtml()
        {
            string htmlContent = "<html><body><h1>Hello, World!</h1></body></html>";
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.Write(htmlContent);
            }

            Console.WriteLine("HTML content has been written to " + filePath);
        }

        static void readHtml ()
        {
            if (File.Exists(filePath))
            {
                // Read the entire file content
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string htmlContent = sr.ReadToEnd();
                    Console.WriteLine("HTML Content:");
                    Console.WriteLine(htmlContent);
                }
            }
            else
            {
                Console.WriteLine("File does not exist: " + filePath);
            }
        }
    }
}
