using System.Threading.Tasks;

namespace DPLK.Service
{
    public interface IAccessControlService
    {
        Task<bool> HasAccess(string userId, string url);
    }
}
