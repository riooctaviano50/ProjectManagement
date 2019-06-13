using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic.Service
{
<<<<<<< HEAD
   public interface IRuleService
=======
    interface IRuleService
>>>>>>> remotes/origin/Farin
    {
        List<Rule> Get();
        List<Rule> GetSearch(string Values);
        Rule Get(int id);
        bool Insert(RuleVM ruleVM);
        bool Update(int id, RuleVM ruleVM);
        bool Delete(int id);
    }
}
