using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;
using Common.Repository;
using DataAccess.Context;
using Common.Repository.Application;

namespace BussinessLogic.Service.Application
{
    public class RepliesService : IRepliesService
    {
        public IRepliesRepository iRepliesRepository = new RepliesRepository();
        bool status = false;

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(RepliesVM repliesVM)
        {
            throw new NotImplementedException();
        }


        List<Replies> IRepliesService.Get()
        {
            throw new NotImplementedException();
        }

        Replies IRepliesService.Get(int id)
        {
            throw new NotImplementedException();
        }

        List<Replies> IRepliesService.GetSearch(string values)
        {
            throw new NotImplementedException();
        }
    }
}
