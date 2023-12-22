using DPLK.Models;
using DPLK.Models.Dto;
using Microsoft.Graph.Models;
using System.Threading.Tasks;

namespace DPLK.Service
{
    public interface UserService
    {
        Task<TUser> GetByIdAsync(string id, string jabatan);
    }
}
