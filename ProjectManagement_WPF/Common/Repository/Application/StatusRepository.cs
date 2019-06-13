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
    public class StatusRepository : IStatusRepository
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

        public List<Status> Get()
        {
            var get = myContext.Statuses.Where(x => x.IsDelete == false).ToList();
            return get;
        }

        public Status Get(int id)
        {
            var get = myContext.Statuses.Find(id);
            return get;
        }

        public bool Insert(StatusVM statusVM)
        {
            var push = new Status(statusVM);
            myContext.Statuses.Add(push);
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

        public bool Update(int id, StatusVM statusVM)
        {
            var get = Get(id);
            if (get != null)
            {
                get.Update(id, statusVM);
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
