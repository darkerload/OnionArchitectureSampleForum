using ApoForum.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApoForum.Domain.Interface
{
    public interface ISubjectRepository
    {
        List<SubjectDTO> GetSubjectList();

        SubjectDTO GetSubjectById(int id);

        void NewSubject(SubjectDTO subject);
    }
}
