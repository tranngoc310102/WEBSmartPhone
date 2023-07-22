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
	public partial class frmManagerAccount : Form
	{
		public frmManagerAccount()
		{
			InitializeComponent();
		}
		BindingSource source;
		IAccountRepository accountRepository = new AccountRepository();
		private void frmManagerAccount_Load(object sender, EventArgs e)
		{
			LoadAccount(sender, e);
		}
		private void LoadAccount(object sender, EventArgs e)
		{
			ProjectContext context = new ProjectContext();
			source = new BindingSource();
			source.DataSource = context.Accounts.ToList();
			dgvAccount.DataSource = null;
			dgvAccount.DataSource = source;
			btnEdit.Enabled = false;
			btnDelete.Enabled = false;
		}
		private Account GetAccount(object sender, EventArgs e)
		{
			DataGridViewRow selectedRow = dgvAccount.CurrentRow;
			Account a = new Account();
			if (selectedRow != null)
			{
				a.AccountId = int.Parse(selectedRow.Cells["AccountId"].Value.ToString());				
				a.AccountName = selectedRow.Cells["AccountName"].Value.ToString();
				a.Address = selectedRow.Cells["Address"].Value.ToString();
				a.Phone = selectedRow.Cells["Phone"].Value.ToString();
				a.Username = selectedRow.Cells["Username"].Value.ToString();
			}
			return a;
		}
		private void Clear(object sender, EventArgs e)
		{
			txtAid.Text = string.Empty;
			txtAddress.Text = string.Empty;
			txtAname.Text = string.Empty;
			txtPhone.Text = string.Empty;
			txtUser.Text = string.Empty;
			btnEdit.Enabled = false;
			btnDelete.Enabled = false;
		}
		private void dgvProduct_DoubleClick(object sender, EventArgs e)
		{
			Account acc = new Account();
			acc = GetAccount(sender, e);
			txtAid.Text = acc.AccountId.ToString();
			txtAname.Text = acc.AccountName;
			txtAddress.Text = acc.Address;
			txtPhone.Text= acc.Phone;
			txtUser.Text = acc.Username;
			btnEdit.Enabled = true;
			btnDelete.Enabled = true;
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			Account account = new Account();
			account.AccountId = int.Parse(txtAid.Text);
			account.AccountName = txtAname.Text;
			account.Address = txtAddress.Text;
			account.Phone = txtPhone.Text;
			account.Username = txtUser.Text;
			Account a = accountRepository.GetAccount(account.AccountId);
			account.Pass = a.Pass;
			account.Role = a.Role;	
			accountRepository.Update(account);
			Clear(sender, e);
			LoadAccount(sender, e);
			MessageBox.Show("Update Account Successfull");
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int accid = int.Parse(txtAid.Text);
			accountRepository.DeleteAccount(accid);
			Clear(sender, e);
			LoadAccount(sender, e);
			MessageBox.Show("Delete Account Successfull");
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			string key = txtSearch.Text.ToString();
			List<Account> accounts = new List<Account>();
			ProjectContext context = new ProjectContext();
			if (cbxSearch.Text.Equals("ID"))
			{
				try
				{
					int aid = int.Parse(key);
					accounts = context.Accounts.Where(a => a.AccountId == aid).ToList();
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
					accounts = context.Accounts.Where(a =>a.AccountName.Contains(key)).ToList();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Enter FullName");
				}
			}
			source = new BindingSource();
			source.DataSource = accounts;
			dgvAccount.DataSource = null;
			dgvAccount.DataSource = source;
			btnEdit.Enabled = false;
			btnDelete.Enabled = false;
			Clear(sender, e);
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
			LoadAccount(sender, e);
			Clear(sender, e);
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
