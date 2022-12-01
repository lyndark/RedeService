using ProgrammerEvaluationWeb.Models;
using System.Text.Json;

namespace ProgrammerEvaluationWeb.Services
{
    public class FileService
    {
        public static void CreateTxtFile(int[] vector)
        {
            try
            {
                var rootPath = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.FullName;
                StreamWriter sw = new StreamWriter(rootPath + "/numeros_ordenar.txt");
                sw.WriteLine(String.Join("\n", vector));
                sw.Close();
                
            }
            catch
            {

            }
        }
        public static void CreateJsonFile(List<clsTeste> list, string path = "")
        {
            try
            {
                var rootPath = path == string.Empty ? Environment.CurrentDirectory : path;
                StreamWriter sw = new StreamWriter(rootPath + "/data.json");
                sw.WriteLine(JsonSerializer.Serialize(list));
                sw.Close();
            }
            catch
            {

            }
        }

        public static List<clsTeste> ReadJsonFile(string path = "")
        {
            try
            {
                var rootPath = path == string.Empty ? Environment.CurrentDirectory : path;
                StreamReader sr = new StreamReader(rootPath + "/data.json");
                var list = JsonSerializer.Deserialize<List<clsTeste>>(sr.ReadToEnd());
                sr.Close();

                return list ?? new List<clsTeste> { };
            }
            catch
            {
                return new List<clsTeste> { };
            }
        }
    }
}
