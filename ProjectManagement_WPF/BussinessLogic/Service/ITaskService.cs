using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = DataAccess.Models.Task;

namespace BussinessLogic.Service
{
    public interface ITaskService
    {
        List<Task> Get();
        Task Get(int id);
        bool Insert(TaskVM taskVM);
        bool Update(int id, TaskVM taskVM);
        bool Delete(int id);
    }
}
