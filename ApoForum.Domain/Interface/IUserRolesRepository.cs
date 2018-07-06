using ApoForum.Domain.DTOs;
using System.Collections.Generic;

namespace Apo.Infrastructure.Repository
{
    public interface IUserRolesRepository
    {
        List<UserRolesDTO> RolesList();
    }
}