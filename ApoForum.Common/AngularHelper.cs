using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApoForum.Common
{
    public static class AngularHelper
    {
        public static string ToJson(this object data)
        {
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(data);
            return json.Replace("\"", "'"); ;
        }
    }
}
