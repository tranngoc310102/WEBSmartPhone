using Model.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DataAccess
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetAllOrder();
        Order GetOrder(int orderid);
        void InsertOrder(Order order);
        void Update(Order order);
    }
}
