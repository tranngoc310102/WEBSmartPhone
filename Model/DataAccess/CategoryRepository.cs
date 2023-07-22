using Model.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DataAccess
{
	public class CategoryRepository : ICategoryRepository
	{
		public void DeleteCategory(int cateid)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Category> GetAllCategory()
		{
			throw new NotImplementedException();
		}

		public Category GetCategory(int cateid)
		{
			throw new NotImplementedException();
		}

		public void InsertCategory(Category cate) => CategoryDAO.Instance.AddCategory(cate);
		public void Update(Category cate)
		{
			throw new NotImplementedException();
		}
	}
}
