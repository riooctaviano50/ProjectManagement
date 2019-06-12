using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class TicketVM
    {
        public int Id { get; set; }
        public int From_UserId { get; set; }
        public string Message { get; set; }
        public int Project_Id { get; set; }
        public int Status_Id { get; set; }
        public TicketVM(int from_userid, string message, int project_Id, int status_Id)
        {
            this.From_UserId = from_userid;
            this.Message = message;
            this.Project_Id = project_Id;
            this.Status_Id = status_Id;
        }
        public TicketVM() { }
    }
}
