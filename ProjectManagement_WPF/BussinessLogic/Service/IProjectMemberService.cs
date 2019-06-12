using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic.Service
{
    public interface IProjectMemberService
    {
        List<ProjectMember> Get();
        List<ProjectMember> GetSearch(string values);
        ProjectMember Get(int id);
        bool Insert(ProjectMemberVM projectmemberVM);
        bool Delete(int id);
    }
}
