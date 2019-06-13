using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Context;
using DataAccess.Models;
using DataAccess.ViewModels;
using Task = DataAccess.Models.Task;

namespace Common.Repository.Application
{
    public class TaskRepository : ITaskRepository
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

        public List<Task> Get()
        {
            var get = myContext.Tasks.Include("Employee").Include("Status").Include("Project").Where(x => x.IsDelete == false).ToList();
            return get;
        }

        public Task Get(int id)
        {
            var get = myContext.Tasks.Find(id);
            return get;
        }

        public bool Insert(TaskVM taskVM)
        {
            var push = new Task(taskVM);
            myContext.Tasks.Add(push);
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

        public bool Update(int id, TaskVM taskVM)
        {
            var get = Get(id);
            var getStatus = myContext.Statuses.Find(taskVM.Status_Id);
            get.Status = getStatus;
            if (get != null)
            {
                get.Update(id, taskVM);
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
