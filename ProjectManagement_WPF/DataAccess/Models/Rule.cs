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
    [Table("TB_M_Rule")]
    public class Rule : BaseModel
    {
        public string Name { get; set; }

        public Rule() { }

        public Rule(RuleVM ruleVM)
        {
            this.Name = ruleVM.Name;
        }

        public void Update(int id, RuleVM ruleVM)
        {
            this.Name = ruleVM.Name;
        }

        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.ToLocalTime();
        }
    }


}
