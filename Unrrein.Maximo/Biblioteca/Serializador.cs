using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class JsonFileHandler
    {
        public static void Serialize(object obj, string filePath)
        {
            try
            {
                string json = JsonSerializer.Serialize(obj);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            finally
            {
                
            }
        }

        public static object Deserialize(string filePath, Type objectType)
        {
            try
            {
                string json = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize(json, objectType);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
                
                return null; // VER
            }
            finally
            {
                
            }
        }
    }
}
