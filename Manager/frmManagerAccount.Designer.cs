namespace Manager
{
	partial class frmManagerAccount
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			btnProductManager = new Button();
			btnAccount = new Button();
			cbxSearch = new ComboBox();
			txtSearch = new TextBox();
			btnSearch = new Button();
			lbAid = new Label();
			lbAddress = new Label();
			lbAname = new Label();
			lbPhone = new Label();
			dgvAccount = new DataGridView();
			btnEdit = new Button();
			btnClose = new Button();
			txtPhone = new TextBox();
			txtAddress = new TextBox();
			txtAname = new TextBox();
			txtAid = new TextBox();
			lbUser = new Label();
			txtUser = new TextBox();
			btnDelete = new Button();
			((System.ComponentModel.ISupportInitialize)dgvAccount).BeginInit();
			SuspendLayout();
			// 
			// btnProductManager
			// 
			btnProductManager.Location = new Point(767, 12);
			btnProductManager.Name = "btnProductManager";
			btnProductManager.Size = new Size(148, 34);
			btnProductManager.TabIndex = 0;
			btnProductManager.Text = "Product Manager";
			btnProductManager.UseVisualStyleBackColor = true;
			btnProductManager.Click += btnProductManager_Click;
			// 
			// btnAccount
			// 
			btnAccount.Location = new Point(937, 12);
			btnAccount.Name = "btnAccount";
			btnAccount.Size = new Size(155, 34);
			btnAccount.TabIndex = 1;
			btnAccount.Text = "Account Manager";
			btnAccount.UseVisualStyleBackColor = true;
			btnAccount.Click += btnAccount_Click;
			// 
			// cbxSearch
			// 
			cbxSearch.FormattingEnabled = true;
			cbxSearch.Items.AddRange(new object[] { "ID", "Name" });
			cbxSearch.Location = new Point(12, 18);
			cbxSearch.Name = "cbxSearch";
			cbxSearch.Size = new Size(80, 28);
			cbxSearch.TabIndex = 2;
			// 
			// txtSearch
			// 
			txtSearch.Location = new Point(98, 19);
			txtSearch.Name = "txtSearch";
			txtSearch.Size = new Size(186, 27);
			txtSearch.TabIndex = 3;
			// 
			// btnSearch
			// 
			btnSearch.Location = new Point(305, 19);
			btnSearch.Name = "btnSearch";
			btnSearch.Size = new Size(94, 29);
			btnSearch.TabIndex = 4;
			btnSearch.Text = "Search";
			btnSearch.UseVisualStyleBackColor = true;
			btnSearch.Click += btnSearch_Click;
			// 
			// lbAid
			// 
			lbAid.AutoSize = true;
			lbAid.Location = new Point(12, 105);
			lbAid.Name = "lbAid";
			lbAid.Size = new Size(78, 20);
			lbAid.TabIndex = 5;
			lbAid.Text = "AccountID";
			// 
			// lbAddress
			// 
			lbAddress.AutoSize = true;
			lbAddress.Location = new Point(12, 196);
			lbAddress.Name = "lbAddress";
			lbAddress.Size = new Size(62, 20);
			lbAddress.TabIndex = 6;
			lbAddress.Text = "Address";
			// 
			// lbAname
			// 
			lbAname.AutoSize = true;
			lbAname.Location = new Point(12, 148);
			lbAname.Name = "lbAname";
			lbAname.Size = new Size(107, 20);
			lbAname.TabIndex = 7;
			lbAname.Text = "Account Name";
			// 
			// lbPhone
			// 
			lbPhone.AutoSize = true;
			lbPhone.Location = new Point(524, 108);
			lbPhone.Name = "lbPhone";
			lbPhone.Size = new Size(108, 20);
			lbPhone.TabIndex = 9;
			lbPhone.Text = "Phone Number";
			// 
			// dgvAccount
			// 
			dgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvAccount.Location = new Point(132, 281);
			dgvAccount.Name = "dgvAccount";
			dgvAccount.RowHeadersWidth = 51;
			dgvAccount.RowTemplate.Height = 29;
			dgvAccount.Size = new Size(859, 167);
			dgvAccount.TabIndex = 10;
			dgvAccount.DoubleClick += dgvProduct_DoubleClick;
			// 
			// btnEdit
			// 
			btnEdit.Location = new Point(863, 246);
			btnEdit.Name = "btnEdit";
			btnEdit.Size = new Size(128, 29);
			btnEdit.TabIndex = 12;
			btnEdit.Text = "Edit Account";
			btnEdit.UseVisualStyleBackColor = true;
			btnEdit.Click += btnEdit_Click;
			// 
			// btnClose
			// 
			btnClose.Location = new Point(210, 246);
			btnClose.Name = "btnClose";
			btnClose.Size = new Size(119, 29);
			btnClose.TabIndex = 14;
			btnClose.Text = "Close";
			btnClose.UseVisualStyleBackColor = true;
			btnClose.Click += btnClose_Click;
			// 
			// txtPhone
			// 
			txtPhone.Location = new Point(675, 98);
			txtPhone.Name = "txtPhone";
			txtPhone.Size = new Size(316, 27);
			txtPhone.TabIndex = 16;
			// 
			// txtAddress
			// 
			txtAddress.Location = new Point(132, 189);
			txtAddress.Name = "txtAddress";
			txtAddress.Size = new Size(301, 27);
			txtAddress.TabIndex = 17;
			// 
			// txtAname
			// 
			txtAname.Location = new Point(132, 141);
			txtAname.Name = "txtAname";
			txtAname.Size = new Size(301, 27);
			txtAname.TabIndex = 18;
			// 
			// txtAid
			// 
			txtAid.Location = new Point(132, 101);
			txtAid.Name = "txtAid";
			txtAid.Size = new Size(301, 27);
			txtAid.TabIndex = 19;
			// 
			// lbUser
			// 
			lbUser.AutoSize = true;
			lbUser.Location = new Point(524, 148);
			lbUser.Name = "lbUser";
			lbUser.Size = new Size(78, 20);
			lbUser.TabIndex = 20;
			lbUser.Text = "UserName";
			// 
			// txtUser
			// 
			txtUser.Location = new Point(675, 145);
			txtUser.Name = "txtUser";
			txtUser.Size = new Size(316, 27);
			txtUser.TabIndex = 21;
			// 
			// btnDelete
			// 
			btnDelete.Location = new Point(534, 246);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(128, 29);
			btnDelete.TabIndex = 24;
			btnDelete.Text = "Delete Account";
			btnDelete.UseVisualStyleBackColor = true;
			btnDelete.Click += btnDelete_Click;
			// 
			// frmManagerAccount
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1104, 450);
			Controls.Add(btnDelete);
			Controls.Add(txtUser);
			Controls.Add(lbUser);
			Controls.Add(txtAid);
			Controls.Add(txtAname);
			Controls.Add(txtAddress);
			Controls.Add(txtPhone);
			Controls.Add(btnClose);
			Controls.Add(btnEdit);
			Controls.Add(dgvAccount);
			Controls.Add(lbPhone);
			Controls.Add(lbAname);
			Controls.Add(lbAddress);
			Controls.Add(lbAid);
			Controls.Add(btnSearch);
			Controls.Add(txtSearch);
			Controls.Add(cbxSearch);
			Controls.Add(btnAccount);
			Controls.Add(btnProductManager);
			Name = "frmManagerAccount";
			Text = "frmManagerAccount";
			Load += frmManagerAccount_Load;
			((System.ComponentModel.ISupportInitialize)dgvAccount).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		private Button btnProductManager;
		private Button btnAccount;
		private ComboBox cbxSearch;
		private TextBox txtSearch;
		private Button btnSearch;
		private Label lbAid;
		private Label lbAddress;
		private Label lbAname;
		private Label lbdate;
		private Label lbPhone;
		private DataGridView dgvAccount;
		private Button btnEdit;
		private Button btnClose;
		private TextBox txtDate;
		private TextBox txtTotal;
		private TextBox txtFullname;
		private TextBox txtAid;
		private Button btnDelete;
		private TextBox txtAddress;
		private TextBox txtPhone;
		private TextBox txtAname;
		private TextBox txtUser;
		private Label lbUser;
	}
}