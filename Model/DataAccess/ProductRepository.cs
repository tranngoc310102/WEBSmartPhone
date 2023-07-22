using Model.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DataAccess
{
    public class ProductRepository : IProductRepository
    {
        public void DeleteProduct(int proid) => ProductDAO.Instance.DeleteProduct(proid);
        public IEnumerable<Product> GetAllProduct() => ProductDAO.Instance.GetAllProduct();
        public Product GetProduct(int proid) => ProductDAO.Instance.GetProduct(proid);
        public void InsertProduct(Product pro) => ProductDAO.Instance.AddProduct(pro);
        public void Update(Product pro) => ProductDAO.Instance.UpdateProduct(pro);
    }
}
