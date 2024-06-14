using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class ManejadorJson
    {
        public static void Serializacion(Object obj, string filePath)
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))    //IMPORTANTE: sino tiene propiedades get set no funciona
                {
                    string objJson = JsonSerializer.Serialize(obj, options);
                    

                    sw.WriteLine(objJson);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error inesperado . . .", ex);
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        public static object Desealizacion(string filePath, Type tipoDeObjeto)
        {
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string objJson = sr.ReadToEnd();

                    
                    return JsonSerializer.Deserialize(objJson, tipoDeObjeto);
                }
            }
            catch (FileNotFoundException)
            {
                throw new Exception("No se encontró el archivo: " + filePath);
            }
            catch (JsonException ex)
            {
                throw new Exception("Error deserializando el archivo JSON: " + ex.Message);
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        


    }
}
