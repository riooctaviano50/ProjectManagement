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
    public class StatusService : IStatusService
    {
        bool status = false;
        IStatusRepository iStatusRepository = new StatusRepository();


        public bool Delete(int id)
        {
            return iStatusRepository.Delete(id);
        }

        public List<Status> Get()
        {
            return iStatusRepository.Get();
        }

        public Status Get(int id)
        {
            return iStatusRepository.Get(id);
        }

        public bool Insert(StatusVM statusVM)
        {
            if (string.IsNullOrWhiteSpace(statusVM.Name))
            {
                return status;
            }
            else
            {
                return iStatusRepository.Insert(statusVM);
            }
        }

        public bool Update(int id, StatusVM statusVM)
        {
            return iStatusRepository.Update(id, statusVM);
        }
    }
}
