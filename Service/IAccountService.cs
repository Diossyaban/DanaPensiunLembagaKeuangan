using DPLK.Models.Dto;
using Microsoft.Graph.Models;
using System.Threading.Tasks;

namespace DPLK.Service
{
    public interface IAccountService
    {
        Task<bool> LoginAsync(string email, string password);
        Task<User> GetUserByEmailAsync(string email);

    }
}
