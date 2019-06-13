using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic.Service
{
    public interface ITicketService
    {
        List<Ticket> Get();
        Ticket Get(int id);
        bool Insert(TicketVM ticketVM);
        bool Delete(int id);
    }
}
