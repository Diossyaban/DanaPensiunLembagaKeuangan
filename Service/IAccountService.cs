using DPLK.Models.Dto;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DPLK.Service
{
    public interface IAccountService
    {

        Task<bool> LoginAsync(string email, string password);

    }
}
