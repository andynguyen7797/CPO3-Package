using Newtonsoft.Json;
using System;
using System.IO;

namespace CPO3_Remaker
{
    public class SerializerOfJson
    { 
          
        public static void SerializeToJson(string filePath, object data)
        {
            string jsonData = JsonConvert.SerializeObject(data);

            // writer to file Json.txt
            if (File.Exists(filePath))
            {

                StreamWriter writer = File.AppendText(filePath);
                writer.WriteLine(jsonData);
                writer.Close();
            }   
        }

        public static object DeserializeFromJsonFile(string jsonData, Type allType)
        {
            return JsonConvert.DeserializeObject(jsonData, allType);                 
        }
    }
}
