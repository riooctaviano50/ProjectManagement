using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Repository;
using Common.Repository.Application;
using DataAccess.Models;
using DataAccess.ViewModels;

namespace BussinessLogic.Service.Application
{
    public class ProjectService : IProjectService
    {
        bool status = false;
        IProjectRepository iProjectRepository = new ProjectRepository();

        public bool Delete(int id)
        {
            return iProjectRepository.Delete(id);
        }

        public List<Project> Get()
        {
            return iProjectRepository.Get();
        }

        public Project Get(int id)
        {
            return iProjectRepository.Get(id);
        }

        public bool Insert(ProjectVM projectVM)
        {
            if (string.IsNullOrWhiteSpace(projectVM.Name))
            {
                return status;
            }
            else
            {
                return iProjectRepository.Insert(projectVM);
            }
        }

        public bool Update(int id, ProjectVM projectVM)
        {
            return iProjectRepository.Update(id, projectVM);
        }
    }
}
