using ApoForum.Data.EntityFramework;
using ApoForum.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apo.Infrastructure.Mapper
{
    public class Mapper
    {
        public static void InitializeMap()
        {
            //AutoMapper.Mapper.CreateMap<tblSubject, SubjectDTO>();
            //AutoMapper.Mapper.CreateMap<SubjectDTO, tblSubject>();
            AutoMapper.Mapper.CreateMap<AspNetRoles, UserRolesDTO>();
        }
    }
}
