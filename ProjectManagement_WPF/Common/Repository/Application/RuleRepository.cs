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
    public class RuleRepository : IRuleRepository
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

        public List<Rule> Get()
        {
            var get = myContext.Rules.Where(X => X.IsDelete == false).ToList();
            return get;
        }

        public Rule Get(int id)
        {
            var get = myContext.Rules.Find(id);
            return get;
        }

        public List<Rule> GetSearch(string Values)
        {
            var get = myContext.Rules.Where
            (x => (x.Name.Contains(Values) ||
            x.Id.ToString().Contains(Values)) &&
            x.IsDelete == false).ToList();
            return get;
        }

        public bool Insert(RuleVM RuleVM)
        {
            var push = new Rule(RuleVM);
            myContext.Rules.Add(push);
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

        public bool Update(int id, RuleVM ruleVM)
        {
            var get = Get(id);
            if (get != null)
            {
                get.Update(id, ruleVM);
                myContext.Entry(get).State = System.Data.Entity.EntityState.Modified;
                var result = myContext.SaveChanges();
                return true;
            }
            else
            {
                return true;
            }
        }
    }
}
