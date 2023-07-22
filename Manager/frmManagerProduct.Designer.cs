namespace Manager
{
	partial class frmManagerProduct
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
			lbPid = new Label();
			lbPrice = new Label();
			lbPname = new Label();
			lbPimg = new Label();
			dgvProduct = new DataGridView();
			btnEdit = new Button();
			btnClose = new Button();
			txtPimg = new TextBox();
			txtPrice = new TextBox();
			txtPname = new TextBox();
			txtPid = new TextBox();
			lbCid = new Label();
			txtCid = new TextBox();
			cbxCid = new ComboBox();
			btnCreate = new Button();
			btnDelete = new Button();
			((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
			SuspendLayout();
			// 
			// btnProductManager
			// 
			btnProductManager.Location = new Point(767, 12);
			btnProductManager.Name = "btnProductManager";
			btnProductManager.Size = new Size(152, 34);
			btnProductManager.TabIndex = 0;
			btnProductManager.Text = "Product Manager";
			btnProductManager.UseVisualStyleBackColor = true;
			btnProductManager.Click += btnProductManager_Click;
			// 
			// btnAccount
			// 
			btnAccount.Location = new Point(937, 12);
			btnAccount.Name = "btnAccount";
			btnAccount.Size = new Size(137, 34);
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
			// lbPid
			// 
			lbPid.AutoSize = true;
			lbPid.Location = new Point(12, 105);
			lbPid.Name = "lbPid";
			lbPid.Size = new Size(75, 20);
			lbPid.TabIndex = 5;
			lbPid.Text = "ProductID";
			// 
			// lbPrice
			// 
			lbPrice.AutoSize = true;
			lbPrice.Location = new Point(12, 196);
			lbPrice.Name = "lbPrice";
			lbPrice.Size = new Size(41, 20);
			lbPrice.TabIndex = 6;
			lbPrice.Text = "Price";
			// 
			// lbPname
			// 
			lbPname.AutoSize = true;
			lbPname.Location = new Point(12, 148);
			lbPname.Name = "lbPname";
			lbPname.Size = new Size(104, 20);
			lbPname.TabIndex = 7;
			lbPname.Text = "Product Name";
			// 
			// lbPimg
			// 
			lbPimg.AutoSize = true;
			lbPimg.Location = new Point(524, 108);
			lbPimg.Name = "lbPimg";
			lbPimg.Size = new Size(112, 20);
			lbPimg.TabIndex = 9;
			lbPimg.Text = "Product Images";
			// 
			// dgvProduct
			// 
			dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvProduct.Location = new Point(132, 281);
			dgvProduct.Name = "dgvProduct";
			dgvProduct.RowHeadersWidth = 51;
			dgvProduct.RowTemplate.Height = 29;
			dgvProduct.Size = new Size(859, 167);
			dgvProduct.TabIndex = 10;
			dgvProduct.DoubleClick += dgvProduct_DoubleClick;
			// 
			// btnEdit
			// 
			btnEdit.Location = new Point(863, 246);
			btnEdit.Name = "btnEdit";
			btnEdit.Size = new Size(128, 29);
			btnEdit.TabIndex = 12;
			btnEdit.Text = "Edit Product";
			btnEdit.UseVisualStyleBackColor = true;
			btnEdit.Click += btnEdit_Click;
			// 
			// btnClose
			// 
			btnClose.Location = new Point(132, 246);
			btnClose.Name = "btnClose";
			btnClose.Size = new Size(119, 29);
			btnClose.TabIndex = 14;
			btnClose.Text = "Close";
			btnClose.UseVisualStyleBackColor = true;
			btnClose.Click += btnClose_Click;
			// 
			// txtPimg
			// 
			txtPimg.Location = new Point(675, 98);
			txtPimg.Name = "txtPimg";
			txtPimg.Size = new Size(316, 27);
			txtPimg.TabIndex = 16;
			// 
			// txtPrice
			// 
			txtPrice.Location = new Point(132, 189);
			txtPrice.Name = "txtPrice";
			txtPrice.Size = new Size(301, 27);
			txtPrice.TabIndex = 17;
			// 
			// txtPname
			// 
			txtPname.Location = new Point(132, 141);
			txtPname.Name = "txtPname";
			txtPname.Size = new Size(301, 27);
			txtPname.TabIndex = 18;
			// 
			// txtPid
			// 
			txtPid.Location = new Point(132, 101);
			txtPid.Name = "txtPid";
			txtPid.Size = new Size(301, 27);
			txtPid.TabIndex = 19;
			// 
			// lbCid
			// 
			lbCid.AutoSize = true;
			lbCid.Location = new Point(524, 196);
			lbCid.Name = "lbCid";
			lbCid.Size = new Size(84, 20);
			lbCid.TabIndex = 20;
			lbCid.Text = "CategoryID";
			// 
			// txtCid
			// 
			txtCid.Location = new Point(675, 189);
			txtCid.Name = "txtCid";
			txtCid.Size = new Size(136, 27);
			txtCid.TabIndex = 21;
			// 
			// cbxCid
			// 
			cbxCid.FormattingEnabled = true;
			cbxCid.Items.AddRange(new object[] { "Status", "Đã đặt hàng", "Đã xác nhận", "Đang vận chuyển", "Đã giao hàng", "Đã hoàn" });
			cbxCid.Location = new Point(840, 188);
			cbxCid.Name = "cbxCid";
			cbxCid.Size = new Size(151, 28);
			cbxCid.TabIndex = 22;
			// 
			// btnCreate
			// 
			btnCreate.Location = new Point(675, 246);
			btnCreate.Name = "btnCreate";
			btnCreate.Size = new Size(136, 29);
			btnCreate.TabIndex = 23;
			btnCreate.Text = "Create Product";
			btnCreate.UseVisualStyleBackColor = true;
			btnCreate.Click += btnCreate_Click;
			// 
			// btnDelete
			// 
			btnDelete.Location = new Point(305, 246);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(128, 29);
			btnDelete.TabIndex = 24;
			btnDelete.Text = "Delete Product";
			btnDelete.UseVisualStyleBackColor = true;
			btnDelete.Click += btnDelete_Click;
			// 
			// frmManagerProduct
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1104, 450);
			Controls.Add(btnDelete);
			Controls.Add(btnCreate);
			Controls.Add(cbxCid);
			Controls.Add(txtCid);
			Controls.Add(lbCid);
			Controls.Add(txtPid);
			Controls.Add(txtPname);
			Controls.Add(txtPrice);
			Controls.Add(txtPimg);
			Controls.Add(btnClose);
			Controls.Add(btnEdit);
			Controls.Add(dgvProduct);
			Controls.Add(lbPimg);
			Controls.Add(lbPname);
			Controls.Add(lbPrice);
			Controls.Add(lbPid);
			Controls.Add(btnSearch);
			Controls.Add(txtSearch);
			Controls.Add(cbxSearch);
			Controls.Add(btnAccount);
			Controls.Add(btnProductManager);
			Name = "frmManagerProduct";
			Text = "frmMain";
			Load += frmManagerProduct_Load;
			((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		private Button btnProductManager;
		private Button btnAccount;
		private ComboBox cbxSearch;
		private TextBox txtSearch;
		private Button btnSearch;
		private Label lbPid;
		private Label lbPrice;
		private Label lbPname;
		private Label lbdate;
		private Label lbPimg;
		private DataGridView dgvProduct;
		private Button btnEdit;
		private Button btnClose;
		private TextBox txtDate;
		private TextBox txtTotal;
		private TextBox txtFullname;
		private TextBox txtPid;
		private TextBox txtAccid;
		private Label lbStatus;
		private TextBox txtStatus;
		private ComboBox cbxCid;
		private Button btnCreate;
		private Button btnDelete;
		private TextBox txtPrice;
		private TextBox txtPimg;
		private TextBox txtPname;
		private TextBox txtCid;
		private Label lbCid;
	}
}