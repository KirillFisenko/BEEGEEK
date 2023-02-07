using System.IO;

namespace _2048ClassLibrary
{
    public class FileProvider
    {
        public static void WriteToFile(string filename, string result)
        {
            var fileWriter = new StreamWriter(filename, true);
            fileWriter.WriteLine(result);
            fileWriter.Close();
        }

        public static string ReadFile(string filename)
        {
            var fileReader = new StreamReader(filename);
            var result = fileReader.ReadToEnd();
            fileReader.Close();
            return result;
        }
    }
}