using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Model.BusinessObject;

namespace Model.DataAccess
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAll();
        Account GetAccount(int accid);
        void InsertAccount(Account acc);
        void Update(Account acc);
        void DeleteAccount(int accid);
    }
}
