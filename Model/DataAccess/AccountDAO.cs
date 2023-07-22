using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Model.BusinessObject;

namespace Model.DataAccess
{
    public class AccountDAO
    {
        private static AccountDAO instance = null;
        private static readonly object intanceLock = new object();
        public static AccountDAO Instance
        {
            get
            {
                lock (intanceLock)
                {
                    if (instance == null)
                    {
                        instance = new AccountDAO();
                    }
                    return instance;
                }
            }
        }
        public void AddAccount(Account acc)
        {
            try
            {
                using ProjectContext stock = new ProjectContext();
                stock.Accounts.Add(acc);
                stock.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Account> GetAllAccount()
        {
            List<Account> accs;
            try
            {
                using ProjectContext stock = new ProjectContext();
                accs = stock.Accounts.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return accs;
        }
        public void UpdateAccount(Account acc)
        {
            try
            {
                using ProjectContext stock = new ProjectContext();
                stock.Entry<Account>(acc).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                stock.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DeleteAccount(int accid)
        {
            try
            {
                using ProjectContext stock = new ProjectContext();
                var o = stock.Accounts.SingleOrDefault(O => O.AccountId == accid);
                stock.Accounts.Remove(o);
                stock.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Account GetAccount(int accid)
        {
            Account acc;
            try
            {
                using ProjectContext stock = new ProjectContext();
                acc = stock.Accounts.SingleOrDefault(O => O.AccountId == accid);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return acc;
        }
    }
}
