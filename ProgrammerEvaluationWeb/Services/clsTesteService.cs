using ProgrammerEvaluationWeb.Models;
using System.Runtime.InteropServices;

namespace ProgrammerEvaluationWeb.Services
{
    public class clsTesteService
    {
        public static List<clsTeste> CreateClsTesteList()
        {
            var list = new List<clsTeste>();

            for(int i = 1; i <= 100; i++)
            {
                list.Add(new clsTeste(i, DateTime.UtcNow));
            }
            return list;
        }
    }
}
