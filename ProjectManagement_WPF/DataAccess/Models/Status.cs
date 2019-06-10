using Core.Base;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("TB_M_Status")]
    public class Status : BaseModel
    {
        public string Name { get; set; }

        public Status() { }

        public Status(StatusVM statusVM)
        {
            this.Name = statusVM.Name;
            this.CreateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Update(int id, StatusVM statusVM)
        {
            this.Id = id;
            this.Name = statusVM.Name;
            this.UpdateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.ToLocalTime();
        }
    }

    
}
