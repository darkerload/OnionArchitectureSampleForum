using ApoForum.Data;
using ApoForum.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApoForum.Domain.DTOs;

namespace Apo.Infrastructure.Repository
{
    public class UserRolesRepository :  IUserRolesRepository
    {
        IRepository<AspNetRoles> repository;
        public UserRolesRepository(IRepository<AspNetRoles> repository)
        {
            this.repository = repository;
        }
        public List<UserRolesDTO> RolesList()
        {
            var getRolesList = repository.GetAll();
            var rolesList = AutoMapper.Mapper.Map<IQueryable<AspNetRoles>, List<UserRolesDTO>>(getRolesList);
            return rolesList;
        }
    }
}
