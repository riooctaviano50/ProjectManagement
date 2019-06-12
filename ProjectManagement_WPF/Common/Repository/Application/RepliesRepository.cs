using DataAccess.Context;
using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repository.Application
{
    public class RepliesRepository : IRepliesRepository
    {
        MyContext myContext = new MyContext();
        bool status = false;

        public bool Delete(int id)
        {
            var pull = Get(id);
            pull.Delete();
            myContext.Entry(pull).State = EntityState.Modified;
            var result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }

        public List<Replies> Get()
        {
            var get = myContext.Replies.Where(x => x.IsDelete == false).ToList();
            return get;
        }

        public Replies Get(int id)
        {
            var get = myContext.Replies.SingleOrDefault(x => x.IsDelete == false && x.Id == id);
            return get;
        }

        public bool Insert(RepliesVM repliesVM)
        {
            var push = new Replies(repliesVM);
            var getTicket = myContext.Tickets.Find(repliesVM.Ticket_Id);
            push.Ticket = getTicket;
            myContext.Replies.Add(push);
            var result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }

        public List<Replies> Search(string param)
        {
            var get = myContext.Replies.Include("Employee").Where(x => x.Id.ToString().Contains(param) || x.Message.Contains(param) || x.Reply_From.ToString().Contains(param) || x.Ticket_Id.ToString().Contains(param)).ToList();
            return get;
        }
    }
}
