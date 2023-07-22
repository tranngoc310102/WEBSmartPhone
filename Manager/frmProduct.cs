using Model.BusinessObject;
using Model.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager
{
	public partial class frmProduct : Form
	{
		public frmProduct()
		{
			InitializeComponent();
		}
		IProductRepository productRepository = new ProductRepository();
		private void lbPimg_Click(object sender, EventArgs e)
		{

		}

		private void btnNewCate_Click(object sender, EventArgs e)
		{
			Category c = new Category();
			c.Note = txtNote.Text;
			c.CategoryName = txtCname.Text;
			ICategoryRepository categoryRepository = new CategoryRepository();
			categoryRepository.InsertCategory(c);
			txtCname.Text = string.Empty;
			txtNote.Text = string.Empty;
			MessageBox.Show("Create Category Successfully!");
			frmProduct_Load(sender, e);
		}

		private void btnNewPro_Click(object sender, EventArgs e)
		{
			ProjectContext context = new ProjectContext();
			Product p = new Product();
			p.ProductName = txtPname.Text;
			int categoryId = context.Categories
	.Where(c => c.CategoryName.Equals(cbxCate.Text))
	.Select(c => c.CategoryId)
	.FirstOrDefault();
			p.CategoryId = categoryId;
			p.Price = float.Parse(txtPrice.Text);
			p.ProductImg = txtPimg.Text;
			productRepository.InsertProduct(p);
			this.Hide();
			frmManagerProduct frmManagerProduct = new frmManagerProduct();
			frmManagerProduct.ShowDialog();
			this.Close();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			frmManagerProduct frmManagerProduct = new frmManagerProduct();
			this.Hide();
			frmManagerProduct.ShowDialog();
			this.Close();
		}

		private void frmProduct_Load(object sender, EventArgs e)
		{
			ProjectContext context = new ProjectContext();
			var categoryNames = context.Categories.Select(c => c.CategoryName).ToList();
			cbxCate.DataSource = categoryNames;
		}
	}
}
