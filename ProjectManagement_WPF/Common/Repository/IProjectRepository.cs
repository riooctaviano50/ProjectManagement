using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repository
{
    public interface IProjectRepository
    {
        List<Project> Get();
        Project Get(int id);
        bool Insert(ProjectVM projectVM);
        bool Update(int id, ProjectVM projectVM);
        bool Delete(int id);
    }
}
