using DPLK.Models.Dto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DPLK.Service;

namespace DPLK.Controllers
{
    public class AccountService : IAccountService
    {
        private readonly HttpClient _httpClient;

        public AccountService(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
        }

        public async Task<bool> LoginAsync(string email, string password)
        {
            var apiUrl = "http://192.168.38.181:8011/api/logindetaildev";

            var content = new StringContent(
                JsonConvert.SerializeObject(new { email, password }),
                Encoding.UTF8,
                "application/json");

            var response = await _httpClient.PostAsync(apiUrl, content);

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var responseObject = JsonConvert.DeserializeObject<LoginType>(responseContent);

                return responseObject.success;
            }

            return false;
        }
    }
}
