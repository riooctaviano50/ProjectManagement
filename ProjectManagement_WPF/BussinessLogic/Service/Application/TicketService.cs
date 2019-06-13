using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;
using Common.Repository.Application;
using Common.Repository;

namespace BussinessLogic.Service.Application
{
    public class TicketService : ITicketService
    {
        ITicketRepository iTicketRepository = new TicketRepository();
        bool status = false;

        public bool Delete(int id)
        {
            return iTicketRepository.Delete(id);
        }

        public List<Ticket> Get()
        {
            return iTicketRepository.Get();
        }

        public Ticket Get(int id)
        {
            return iTicketRepository.Get(id);
        }

        public bool Insert(TicketVM ticketVM)
        {
            if (string.IsNullOrWhiteSpace(ticketVM.Message))
            {
                return status;
            }
            else
            {
                return iTicketRepository.Insert(ticketVM);
            }
        }
    }
}
