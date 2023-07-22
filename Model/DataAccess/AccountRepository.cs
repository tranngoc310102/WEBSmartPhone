using Model.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DataAccess
{
	public class AccountRepository : IAccountRepository
	{
		public void DeleteAccount(int accid) => AccountDAO.Instance.DeleteAccount(accid);
		public Account GetAccount(int accid) => AccountDAO.Instance.GetAccount(accid);
		public IEnumerable<Account> GetAll() => AccountDAO.Instance.GetAllAccount();
		public void InsertAccount(Account acc) => AccountDAO.Instance.AddAccount(acc);
		public void Update(Account acc) =>AccountDAO.Instance.UpdateAccount(acc);
	}
}
