using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Repository;
using Common.Repository.Application;
using DataAccess.Models;
using DataAccess.ViewModels;
using Task = DataAccess.Models.Task;

namespace BussinessLogic.Service.Application
{
    public class TaskService : ITaskService
    {

        bool status = false;
        ITaskRepository iTaskRepository = new TaskRepository();

        public bool Delete(int id)
        {
            return iTaskRepository.Delete(id);
        }

        public List<Task> Get()
        {
            return iTaskRepository.Get();
        }

        public Task Get(int id)
        {
            return iTaskRepository.Get(id);
        }

        public bool Insert(TaskVM taskVM)
        {
            if (string.IsNullOrWhiteSpace(taskVM.Name))
            {
                return status;
            }
            else
            {
                return iTaskRepository.Insert(taskVM);
            }
        }

        public bool Update(int id, TaskVM taskVM)
        {
            return iTaskRepository.Update(id, taskVM);
        }
    }
}
