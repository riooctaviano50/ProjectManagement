using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;
using DataAccess.Context;

namespace Common.Repository.Application
{
    public class ProjectMemberRepository : IProjectMemberRepository
    {
        MyContext myContext = new MyContext();
        bool status = false;
        public bool Delete(int id)
        {
            var get = Get(id);
            if (get != null)
            {
                get.Delete();
                var result = myContext.SaveChanges();
                if (result > 0)
                {
                    status = true;
                }
                else
                {
                    status = false;
                }
            }
            return status;
        }

        public List<ProjectMember> Get()
        {
            var get = myContext.ProjectMembers.Where(X => X.IsDelete == false).ToList();
            return get;
        }

        public ProjectMember Get(int id)
        {
            var get = myContext.ProjectMembers.Find(id);
            return get;
        }

        public List<ProjectMember> GetSearch(string values)
        {
            var get = myContext.ProjectMembers.Where
                (X => (X.User_Id.ToString().Contains(values) ||
                X.Id.ToString().Contains(values)) &&
                X.IsDelete == false).ToList();
            return get;
        }

        public bool Insert(ProjectMemberVM projectmemberVM)
        {
            var push = new ProjectMember(projectmemberVM);
            myContext.ProjectMembers.Add(push);
            var result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            else
            {
                status = false;
            }
            return status;
        }
    }
}
