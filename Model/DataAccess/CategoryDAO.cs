using Model.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DataAccess
{
    public class CategoryDAO
    {
		private static CategoryDAO instance = null;
		private static readonly object intanceLock = new object();
		public static CategoryDAO Instance
		{
			get
			{
				lock (intanceLock)
				{
					if (instance == null)
					{
						instance = new CategoryDAO();
					}
					return instance;
				}
			}
		}
		public void AddCategory(Category cate)
		{
			try
			{
				using ProjectContext stock = new ProjectContext();
				stock.Categories.Add(cate);
				stock.SaveChanges();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
	}
}
