using Model.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DataAccess
{
    public class OrderRepository : IOrderRepository
    {
        public IEnumerable<Order> GetAllOrder() => OrderDAO.Instance.GetAllOrder();
        public Order GetOrder(int orderid) => OrderDAO.Instance.GetOrder(orderid);
        public void InsertOrder(Order order) => OrderDAO.Instance.AddOrder(order);   

        public void Update(Order order) =>OrderDAO.Instance.UpdateOrder(order);
    }
}
