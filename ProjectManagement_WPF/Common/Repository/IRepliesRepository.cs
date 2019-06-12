using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repository
{
    public interface IRepliesRepository
    {
        List<Replies> Get();
        Replies Get(int id);
        bool Insert(RepliesVM repliesVM);
        List<Replies> Search(string param);
        bool Delete(int id);
    }
}
