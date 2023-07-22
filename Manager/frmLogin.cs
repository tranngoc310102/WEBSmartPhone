using System.Diagnostics.Metrics;
using System.Text.Json;

namespace Manager
{
	public partial class frmLogin : Form
	{
		public frmLogin()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string jsonFilePath = "./appsettings.json";

			// Đọc tệp JSON vào một chuỗi
			string jsonString = File.ReadAllText(jsonFilePath);

			// Phân tích chuỗi JSON thành đối tượng
			var jsonObject = JsonDocument.Parse(jsonString).RootElement;

			// Truy cập vào các thuộc tính trong đối tượng JSON
			string email = jsonObject.GetProperty("Email").GetString();
			string password = jsonObject.GetProperty("Pass").GetString();
			if (email.Equals(txtEmail.Text) && password.Equals(txtPass.Text))
			{
				frmManager frmmana = new frmManager();
				this.Hide();
				frmmana.ShowDialog();
				this.Close();

			}			
			else
			{
				MessageBox.Show("Login not successful");
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}