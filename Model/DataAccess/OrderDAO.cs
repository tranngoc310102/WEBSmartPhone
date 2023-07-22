using Model.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DataAccess
{
    public class OrderDAO
    {
        private static OrderDAO instance = null;
        private static readonly object intanceLock = new object();
        public static OrderDAO Instance
        {
            get
            {
                lock (intanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDAO();
                    }
                    return instance;
                }
            }
        }
        public void AddOrder(Order order)
        {
            try
            {
                using ProjectContext stock = new ProjectContext();
                stock.Orders.Add(order);
                stock.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Order> GetAllOrder()
        {
            List<Order> orders;
            try
            {
                using ProjectContext stock = new ProjectContext();
                orders = stock.Orders.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orders;
        }
        public void UpdateOrder(Order order)
        {
            try
            {
                using ProjectContext stock = new ProjectContext();
                stock.Entry<Order>(order).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                stock.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Order GetOrder(int orderid)
        {
            Order order;
            try
            {
                using ProjectContext stock = new ProjectContext();
                order = stock.Orders.SingleOrDefault(O => O.OrderId == orderid);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return order;
        }
    }
}
