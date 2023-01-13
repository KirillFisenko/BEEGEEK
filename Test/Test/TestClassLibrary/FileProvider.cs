using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;



namespace TestClassLibrary
{    public class FileProvider
    {     

        public static void Save(string path, List<Triangle> value)
        {            
            var file = new StreamWriter(path, true);
            string json = JsonConvert.SerializeObject(value, Formatting.Indented);
            file.WriteLine(json);               
            file.Close();
        }

        public static List<Triangle> Read(string path)
        {
            var file = new StreamReader(path);   
            var value = file.ReadToEnd();
            var json = JsonConvert.DeserializeObject<List<Triangle>>(value);
            file.Close();
            return json;            
        }       
    }
}
