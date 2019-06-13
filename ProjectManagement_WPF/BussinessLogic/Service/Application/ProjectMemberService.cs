using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;
using Common.Repository;
using Common.Repository.Application;

namespace BussinessLogic.Service.Application
{
    public class ProjectMemberService : IProjectMemberService
    {
        public IRepliesRepository iRepliesRepository = new RepliesRepository();
        bool status = false;

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProjectMember> Get()
        {
            throw new NotImplementedException();
        }

        public ProjectMember Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProjectMember> GetSearch(string values)
        {
            throw new NotImplementedException();
        }

        public bool Insert(ProjectMemberVM projectmemberVM)
        {
            throw new NotImplementedException();
        }
    }
}
