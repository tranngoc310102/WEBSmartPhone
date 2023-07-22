using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Model.BusinessObject;

namespace Model.DataAccess
{
    public class ProductDAO
    {
        private static ProductDAO instance = null;
        private static readonly object intanceLock = new object();
        public static ProductDAO Instance
        {
            get
            {
                lock (intanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }
                    return instance;
                }
            }
        }
        public void AddProduct(Product pro)
        {
            try
            {
                using ProjectContext stock = new ProjectContext();
                stock.Products.Add(pro);
                stock.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Product> GetAllProduct()
        {
            List<Product> pros;
            try
            {
                using ProjectContext stock = new ProjectContext();
                pros = stock.Products.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return pros;
        }
        public void UpdateProduct(Product pro)
        {
            try
            {
                using ProjectContext stock = new ProjectContext();
                stock.Entry<Product>(pro).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                stock.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DeleteProduct(int proid)
        {
            try
            {
                using ProjectContext stock = new ProjectContext();
                var o = stock.Products.SingleOrDefault(O => O.ProductId == proid);
                stock.Products.Remove(o);
                stock.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Product GetProduct(int proid)
        {
            Product pro;
            try
            {
                using ProjectContext stock = new ProjectContext();
                pro = stock.Products.SingleOrDefault(O => O.ProductId == proid);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return pro;
        }
    }
}
