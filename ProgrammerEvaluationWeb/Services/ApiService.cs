using ProgrammerEvaluationWeb.Dtos;
using System.Text.Json;

namespace ProgrammerEvaluationWeb.Services
{
    public class ApiService
    {
        public static List<BankDto> GetBankApi()
        {
            HttpClient client = new();
            var uri = "https://brasilapi.com.br/api/banks/v1";

            var response = client.GetAsync(uri).Result;
            var json = response.Content.ReadAsStringAsync().Result ;
            return JsonSerializer.Deserialize<List<BankDto>>(json) ?? new List<BankDto>();
        }
    }
}
