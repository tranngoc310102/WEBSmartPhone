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
using Model.BusinessObject;
namespace Manager
{
	public partial class frmManagerProduct : Form
	{
		public frmManagerProduct()
		{
			InitializeComponent();
		}
		BindingSource source;
		IProductRepository productRepository = new ProductRepository();
		private void frmManagerProduct_Load(object sender, EventArgs e)
		{
			ProjectContext context = new ProjectContext();
			source = new BindingSource();
			source.DataSource = context.Products.ToList();
			dgvProduct.DataSource = null;
			dgvProduct.DataSource = source;
			btnEdit.Enabled = false;
			btnDelete.Enabled = false;
			txtPid.Enabled = false;
			var categoryNames = context.Categories.Select(c => c.CategoryName).ToList();
			cbxCid.DataSource = categoryNames;
			cbxCid.SelectedIndex = -1;
		}
		private Product GetProduct(object sender, EventArgs e)
		{
			DataGridViewRow selectedRow = dgvProduct.CurrentRow;
			Product p = new Product();
			if (selectedRow != null)
			{
				p.ProductId = int.Parse(selectedRow.Cells["ProductId"].Value.ToString());
				p.CategoryId = int.Parse(selectedRow.Cells["CategoryId"].Value.ToString());
				p.ProductName = selectedRow.Cells["ProductName"].Value.ToString();
				p.Price = float.Parse(selectedRow.Cells["Price"].Value.ToString());
				p.ProductImg = selectedRow.Cells["ProductImg"].Value.ToString();
			}
			return p;
		}
		private void Clear(object sender, EventArgs e)
		{
			txtPid.Text = string.Empty;
			txtCid.Text = string.Empty;
			txtPname.Text = string.Empty;
			txtPrice.Text = string.Empty;
			txtPimg.Text = string.Empty;
			btnEdit.Enabled = false;
			btnDelete.Enabled = false;
			cbxCid.SelectedIndex = -1;
		}
		private void dgvProduct_DoubleClick(object sender, EventArgs e)
		{
			ProjectContext context = new ProjectContext();
			Product product = GetProduct(sender, e);
			txtPid.Text = product.ProductId.ToString();
			txtPname.Text = product.ProductName;
			var category = context.Categories.FirstOrDefault(c => c.CategoryId == product.CategoryId);
			if (category != null)
			{
				txtCid.Text = category.CategoryName;
			}
			txtPrice.Text = product.Price.ToString();
			txtPimg.Text = product.ProductImg;
			btnEdit.Enabled = true;
			btnDelete.Enabled = true;
			cbxCid.SelectedIndex = -1;
		}

		private void btnProductManager_Click(object sender, EventArgs e)
		{
			frmManagerProduct_Load(sender, e);
			Clear(sender, e);
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			ProjectContext context = new ProjectContext();
			Product p = new Product();
			p.ProductId = int.Parse(txtPid.Text);
			if (cbxCid.Text != null)
			{
				var category = context.Categories.FirstOrDefault(c => c.CategoryName.Equals(cbxCid.Text));
				p.CategoryId = category.CategoryId;
			}
			else
			{
				var category = context.Categories.FirstOrDefault(c => c.CategoryName.Equals(txtCid.Text));
				p.CategoryId = category.CategoryId;
			}
			p.ProductName = txtPname.Text;
			p.Price = float.Parse(txtPrice.Text);
			p.ProductImg = txtPimg.Text;
			productRepository.Update(p);
			Clear(sender, e);
			source = new BindingSource();
			source.DataSource = context.Products.ToList();
			dgvProduct.DataSource = null;
			dgvProduct.DataSource = source;
			btnEdit.Enabled = false;
			btnDelete.Enabled = false;
			txtPid.Enabled = false;
			cbxCid.SelectedIndex = -1;
			cbxCid.DataSource = context.Categories.Select(c => c.CategoryName).ToList();
			MessageBox.Show("Update Product Successfully!");
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			frmProduct frmProduct = new frmProduct();
			this.Hide();
			frmProduct.ShowDialog();
			this.Close();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			ProjectContext context = new ProjectContext();
			Product p = new Product();
			p.ProductId = int.Parse(txtPid.Text);
			var category = context.Categories.FirstOrDefault(c => c.CategoryName.Equals(txtCid.Text));
			p.CategoryId = category.CategoryId;
			p.ProductName = txtPname.Text;
			p.Price = float.Parse(txtPrice.Text);
			p.ProductImg = txtPimg.Text;
			productRepository.DeleteProduct(p.ProductId);
			Clear(sender, e);
			source = new BindingSource();
			source.DataSource = context.Products.ToList();
			dgvProduct.DataSource = null;
			dgvProduct.DataSource = source;
			btnEdit.Enabled = false;
			btnDelete.Enabled = false;
			txtPid.Enabled = false;
			cbxCid.SelectedIndex = -1;
			cbxCid.DataSource = context.Categories.Select(c => c.CategoryName).ToList();
			MessageBox.Show("Delete Product Successfully!");
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			string key = txtSearch.Text.ToString();
			List<Product> products = new List<Product>();
			ProjectContext context = new ProjectContext();
			if (cbxSearch.Text.Equals("ID"))
			{
				try
				{
					int pid = int.Parse(key);
					products = context.Products.Where(p => p.ProductId == pid).ToList();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Enter ProductID");
				}
			}
			else
			{
				try
				{
					products = context.Products.Where(p => p.ProductName.Contains(key)).ToList();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Enter FullName");
				}
			}
			Clear(sender, e);
			source = new BindingSource();
			source.DataSource = products;
			dgvProduct.DataSource = null;
			dgvProduct.DataSource = source;
			btnEdit.Enabled = false;
			btnDelete.Enabled = false;
			txtPid.Enabled = false;
			cbxCid.SelectedIndex = -1;
			cbxCid.DataSource = context.Categories.Select(c => c.CategoryName).ToList();
		}

		private void btnAccount_Click(object sender, EventArgs e)
		{
			frmManagerAccount frmManagerAccount = new frmManagerAccount();
			this.Hide();
			frmManagerAccount.ShowDialog();
			this.Close();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			frmManager frmManager = new frmManager();
			this.Hide();
			frmManager.ShowDialog();
			this.Close();
		}
	}
}
