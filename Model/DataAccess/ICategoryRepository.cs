using Model.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DataAccess
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategory();
        Category GetCategory(int cateid);
        void InsertCategory(Category cate);
        void Update(Category cate);
        void DeleteCategory(int cateid);
    }
}
