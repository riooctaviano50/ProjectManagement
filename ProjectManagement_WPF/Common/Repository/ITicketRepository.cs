using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repository
{
    public interface ITicketRepository
    {
        List<Ticket> Get();
        Ticket Get(int id);
        bool Insert(TicketVM ticketVM);
        bool Delete(int id);
    }
}
