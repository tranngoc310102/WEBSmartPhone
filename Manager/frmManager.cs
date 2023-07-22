using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.BusinessObject;
using Model.DataAccess;

namespace Manager
{
	public partial class frmManager : Form
	{
		public frmManager()
		{
			InitializeComponent();
		}
		BindingSource source;
		IOrderRepository orderRepository = new OrderRepository();
		private void lbMemId_Click(object sender, EventArgs e)
		{

		}

		private void frmManager_Load(object sender, EventArgs e)
		{
			ProjectContext context = new ProjectContext();
			source = new BindingSource();
			source.DataSource = context.Orders.ToList();
			dgvOrder.DataSource = null;
			dgvOrder.DataSource = source;
			btnEdit.Enabled = false;
		}

		private void dgvOrder_DoubleClick(object sender, EventArgs e)
		{
			Order o = GetOrder(sender, e);
			txtAccid.Text = o.AccountId.ToString();
			txtDate.Text = o.OrderDate.ToString();
			txtPid.Text = o.ProductId.ToString();
			txtTotal.Text = o.Total.ToString();
			switch (o.Status)
			{
				case 0:
					txtStatus.Text = "Đã đặt hàng";
					break;
				case 1:
					txtStatus.Text = "Đã xác nhận";
					break;
				case 2:
					txtStatus.Text = "Đang vận chuyển";
					break;
				case 3:
					txtStatus.Text = "Đã giao hàng";
					break;
				case 4:
					txtStatus.Text = "Đã hoàn";
					break;
			}
			txtFullname.Text = o.FullName;
			btnEdit.Enabled = true;
		}
		private Order GetOrder(object sender, EventArgs e)
		{
			DataGridViewRow selectedRow = dgvOrder.CurrentRow;
			Order o = new Order();
			if (selectedRow != null)
			{
				o.AccountId = int.Parse(selectedRow.Cells["AccountId"].Value.ToString());
				o.ProductId = int.Parse(selectedRow.Cells["ProductId"].Value.ToString());
				o.FullName = selectedRow.Cells["FullName"].Value.ToString();
				o.Status = int.Parse(selectedRow.Cells["Status"].Value.ToString());
				o.Total = float.Parse(selectedRow.Cells["Total"].Value.ToString());
				o.OrderDate = DateTime.Parse(selectedRow.Cells["OrderDate"].Value.ToString());
				o.OrderId = int.Parse(selectedRow.Cells["OrderId"].Value.ToString());
			}
			return o;
		}
		private void Clear(object sender, EventArgs e)
		{
			txtAccid.Text = string.Empty;
			txtStatus.Text = string.Empty;
			txtTotal.Text = string.Empty;
			txtFullname.Text = string.Empty;
			txtDate.Text = string.Empty;
			txtPid.Text = string.Empty;
			cbxStatus.SelectedIndex = 0;
		}
		private void btnEdit_Click(object sender, EventArgs e)
		{
			Order o = new Order();
			o = GetOrder(sender, e);
			int orderid = o.OrderId;
			int status = 0;
			if (cbxStatus.Text.Equals("Đã đặt hàng"))
			{
				status = 0;
			}
			else if (cbxStatus.Text.Equals("Đã xác nhận"))
			{
				status = 1;
			}
			else if (cbxStatus.Text.Equals("Đang vận chuyển"))
			{
				status = 2;
			}
			else if (cbxStatus.Text.Equals("Đã giao hàng"))
			{
				status = 3;
			}
			else if (cbxStatus.Text.Equals("Đã hoàn"))
			{
				status = 4;
			}
			else
			{
				status = (int)o.Status;
			}
			o.Status = status;
			orderRepository.Update(o);
			Clear(sender, e);
			frmManager_Load(sender, e);
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			string key = txtSearch.Text.ToString();
			List<Order> orders = new List<Order>();
			ProjectContext context = new ProjectContext();
			if (cbxSearch.Text.Equals("ID"))
			{
				try
				{
					int pid = int.Parse(key);
					orders = context.Orders.Where(o => o.ProductId == pid).ToList();
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
					orders = context.Orders.Where(o => o.FullName.Contains(key)).ToList();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Enter FullName");
				}
			}
			Clear(sender, e);
			btnEdit.Enabled = false;
			source = new BindingSource();
			source.DataSource = orders;
			dgvOrder.DataSource = null;
			dgvOrder.DataSource = source;
			btnEdit.Enabled = false;
		}

		private void btnProductManager_Click(object sender, EventArgs e)
		{
			frmManagerProduct frmManagerProduct = new frmManagerProduct();
			this.Hide();
			frmManagerProduct.ShowDialog();
			this.Close();
		}

		private void btnAccount_Click(object sender, EventArgs e)
		{
			frmManagerAccount frmManagerAccount = new frmManagerAccount();
			this.Hide();
			frmManagerAccount.ShowDialog();
			this.Close();
		}
	}
}
