using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApoForum.Domain.DTOs
{
    public class SubjectDTO
    {
        public int id { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public DateTime? createDate { get; set; }
    }
}
