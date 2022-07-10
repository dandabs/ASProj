using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ASProj
{
    public class FileHandler {

        // DA 9/7/22 Needs to be readonly, as const keyword runs at compile-time, and folder path will change at runtime
        // DA 9/7/22 TODO Change directory name once a name is decided for the project
        // DA 9/7/22 TODO Check for permissions to write in ProgramFiles (to share results); if not, write in %APPDATA%
        public static readonly string dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @".\ASProj");

        public static string Select(string file) // DA 9/7/22 Similar to SQL's `SELECT *`
        {
            string path = Path.Combine(dir, file);
            string cont = File.ReadAllText(path);
            return IsFileValid(cont) ? cont : "";
        }
        public static void Insert<T>(string file, string SerializedObject)
        {
            string path = Path.Combine(dir, file);
            string cont = File.ReadAllText(path);
            if (IsFileValid(cont))
            {
                List<T> array = JsonConvert.DeserializeObject<List<T>>(cont);
                if (array == null) array = new List<T>();
                array.Add(JsonConvert.DeserializeObject<T>(SerializedObject));
                File.WriteAllText(path, JsonConvert.SerializeObject(array));
            }
            else throw new Exception("The file specified is not a valid JSON file.");
        }
        public static void Update<T>(string file, string Id, string SerializedObject) // DA 9/7/22 Will perform an `INSERT` if Id doesn't exist in file
        {
            FileHandler.Delete<T>(file, Id);
            FileHandler.Insert<T>(file, SerializedObject);
        }
        public static void Delete<T>(string file, string Id) // DA 9/7/22 TODO test
        {
            string path = Path.Combine(dir, file);
            string cont = File.ReadAllText(path);
            if (IsFileValid(cont))
            {
                List<T>? array = JsonConvert.DeserializeObject<List<T>>(cont);
                List<T> arrayCopy = new List<T>();
                if (array != null)
                {
                    foreach (T obj in array)
                    {
                        PropertyInfo IdProperty = obj.GetType().GetProperty("Id");
                        Guid Id2 = (Guid)IdProperty.GetValue(obj);
                        if (Id2.ToString() != Id)
                        {
                            arrayCopy.Add(obj);
                        }
                    }
                    File.WriteAllText(path, JsonConvert.SerializeObject(arrayCopy));
                }
            }
            else throw new Exception("The file specified is not a valid JSON file.");

        }
        private static bool IsFileValid(string json)
        {
            if (string.IsNullOrWhiteSpace(json)) return false;
            if (!json.StartsWith("[")/* || !json.StartsWith("{")*/) return false;
            if (!json.EndsWith("]")/* || !json.EndsWith("}")*/) return false;

            try
            {
                var _ = JToken.Parse(json);
                return true;
            } catch (Exception)
            {
                return false;
            }
        }
    }
}
