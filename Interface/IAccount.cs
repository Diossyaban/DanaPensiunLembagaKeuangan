using DPLK.Models.Dto;
using DPLK.Service;
using Microsoft.Graph.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DPLK.Interface
{
    public class AccountService : IAccountService
    {
        private readonly HttpClient _httpClient;

        public AccountService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> LoginAsync(string email, string password)
        {
            var apiUrl = "http://192.168.38.181:8011/api/logindetaildev";
            var requestBody = new
            {
                email,
                password
            };
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

        public async Task<User> GetUserByEmailAsync(string email)
        {
            var apiUrl = $"http://192.168.38.181:8011/api/users?email={email}";

            var response = await _httpClient.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var user = JsonConvert.DeserializeObject<User>(responseContent);

                return user;
            }

            return null;
        }
    }
}
