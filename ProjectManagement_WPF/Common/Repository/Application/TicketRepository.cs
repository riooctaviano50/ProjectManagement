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
    public class TicketRepository : ITicketRepository
    {
        MyContext myContext = new MyContext();
        bool status = false;

        public bool Delete(int id)
        {
            var get = Get(id);
            if (get != null)
            {
                get.Delete();
                myContext.Entry(get).State = System.Data.Entity.EntityState.Modified;
                var result = myContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Ticket> Get()
        {
            var get = myContext.Tickets.Include("Employee").Where(x => x.IsDelete == false).ToList();
            return get;
        }

        public Ticket Get(int id)
        {
            var get = myContext.Tickets.Find(id);
            return get;
        }

        public bool Insert(TicketVM ticketVM)
        {
            var push = new Ticket(ticketVM);
            var getEmployee = myContext.Employees.Find(ticketVM.From_UserId);
            push.Employee = getEmployee;
            myContext.Tickets.Add(push);
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

    }
}
