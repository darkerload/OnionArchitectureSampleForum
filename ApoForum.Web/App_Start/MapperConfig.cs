using Apo.Infrastructure.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApoForum.Web.App_Start
{
    public class MapperConfig
    {
        
        public static void RegisterMap()
        {
            Mapper.InitializeMap();
        }
    }
}