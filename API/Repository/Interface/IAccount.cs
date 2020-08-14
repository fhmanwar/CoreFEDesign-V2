using API.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository.Interface
{
    public interface IAccount
    {
        Task<IEnumerable<AccountVM>> getAll();
        AccountVM getID(int id);
        int Create(AccountVM accountVM);
        int Update(AccountVM accountVM, int id);
        int Delete(int id);
    }
}
