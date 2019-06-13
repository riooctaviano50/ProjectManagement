using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repository
{
   public  interface IProjectMemberRepository
    {
        List<ProjectMember> Get();
        List<ProjectMember> GetSearch(string values);
        ProjectMember Get(int id);
        bool Insert(ProjectMemberVM projectmemberVM);
        bool Delete(int id);
    }
}
