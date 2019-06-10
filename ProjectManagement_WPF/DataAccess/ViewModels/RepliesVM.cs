using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class RepliesVM
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public int Reply_From { get; set; }
        public int Ticket_Id { get; set; }
        public RepliesVM(string message, int reply_from, int ticket_id)
        {
            this.Message = message;
            this.Reply_From = reply_from;
            this.Ticket_Id = ticket_id;
        }
        public RepliesVM() { }
        public void Update(int id, string message, int reply_from, int ticket_id)
        {
            this.Id = id;
            this.Message = message;
            this.Reply_From = reply_from;
            this.Ticket_Id = ticket_id;
        }
    }
}
