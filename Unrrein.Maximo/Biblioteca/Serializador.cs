using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Serializador
    {
        public static void Serialize(object obj, string filePath)
        {
            string json = JsonSerializer.Serialize(obj);
            File.WriteAllText(filePath, json);
        }

        public static object Deserialize(string filePath, System.Type objectType)
        {
            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize(json, objectType);
        }
    }
}
