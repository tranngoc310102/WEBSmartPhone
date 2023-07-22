using Model.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DataAccess
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProduct();
        Product GetProduct(int proid);
        void InsertProduct(Product pro);
        void Update(Product pro);
        void DeleteProduct(int proid);
    }
}
