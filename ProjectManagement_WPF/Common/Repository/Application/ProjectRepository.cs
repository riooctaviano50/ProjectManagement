using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Context;
using DataAccess.Models;
using DataAccess.ViewModels;

namespace Common.Repository.Application
{
    public class ProjectRepository : IProjectRepository
    {
        MyContext myContext = new MyContext();
        bool status = false;

        public bool Delete(int id)
        {
            var get = Get(id);
            if (get != null)
            {
                get.Delete();
                myContext.Entry(get).State = EntityState.Modified;
                myContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Project> Get()
        {
            var get = myContext.Projects.Include("Employee").Where(x => x.IsDelete == false).ToList();
            return get;
        }

        public Project Get(int id)
        {
            var get = myContext.Projects.Find(id);
            return get;
        }

        public bool Insert(ProjectVM projectVM)
        {
            var push = new Project(projectVM);
            myContext.Projects.Add(push);
            var result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            else
            {
                return status;
            }
            return status;
        }
        //'System.Data.Entity.Infrastructure.DbUpdateException' occurred in EntityFramework.dll

        public bool Update(int id, ProjectVM projectVM)
        {
            var get = Get(id);
            var getStatus = myContext.Statuses.Find(projectVM.Status_Id);
            get.Status = getStatus;
            if (get != null)
            {
                get.Update(id, projectVM);
                myContext.Entry(get).State = EntityState.Modified;
                myContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
