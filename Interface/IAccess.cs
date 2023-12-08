/*using DPLK.Models.context;
using DPLK.Service;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace DPLK.Interface
{


    public class AccessControlService : IAccessControlService
    {
        private readonly PensionContext _context;

        public AccessControlService(PensionContext context)
        {
            _context = context;
        }

        public async Task<bool> HasAccess(string userId, string url)
        {
            var userAccess = await _context.TAksesMenus
                .Join(_context.TUsers,
                    access => access.IdProfile,
                    user => user.IdUser,
                    (access, user) => new { Access = access, User = user })
                .Join(_context.TMenus,
                    joined => joined.Access.IdMenu,
                    menu => menu.IdMenu,
                    (joined, menu) => new { joined.User.IdUser, MenuUrl = menu.Url })
                .FirstOrDefaultAsync(x => x.IdProfile == userId && x.MenuUrl == url);

            return userAccess != null;

        }
    }
}*/