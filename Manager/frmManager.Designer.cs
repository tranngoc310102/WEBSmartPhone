namespace Manager
{
	partial class frmManager
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


		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btnProductManager = new Button();
			btnAccount = new Button();
			cbxSearch = new ComboBox();
			txtSearch = new TextBox();
			btnSearch = new Button();
			lbAccId = new Label();
			lbFullName = new Label();
			lbPid = new Label();
			lbdate = new Label();
			lbTotal = new Label();
			dgvOrder = new DataGridView();
			btnEdit = new Button();
			btnClose = new Button();
			txtDate = new TextBox();
			txtTotal = new TextBox();
			txtFullname = new TextBox();
			txtPid = new TextBox();
			txtAccid = new TextBox();
			lbStatus = new Label();
			txtStatus = new TextBox();
			cbxStatus = new ComboBox();
			((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
			SuspendLayout();
			// 
			// btnProductManager
			// 
			btnProductManager.Location = new Point(767, 12);
			btnProductManager.Name = "btnProductManager";
			btnProductManager.Size = new Size(153, 34);
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
			// lbAccId
			// 
			lbAccId.AutoSize = true;
			lbAccId.Location = new Point(12, 105);
			lbAccId.Name = "lbAccId";
			lbAccId.Size = new Size(78, 20);
			lbAccId.TabIndex = 5;
			lbAccId.Text = "AccountID";
			lbAccId.Click += lbMemId_Click;
			// 
			// lbFullName
			// 
			lbFullName.AutoSize = true;
			lbFullName.Location = new Point(12, 196);
			lbFullName.Name = "lbFullName";
			lbFullName.Size = new Size(76, 20);
			lbFullName.TabIndex = 6;
			lbFullName.Text = "Full Name";
			// 
			// lbPid
			// 
			lbPid.AutoSize = true;
			lbPid.Location = new Point(12, 148);
			lbPid.Name = "lbPid";
			lbPid.Size = new Size(75, 20);
			lbPid.TabIndex = 7;
			lbPid.Text = "ProductID";
			// 
			// lbdate
			// 
			lbdate.AutoSize = true;
			lbdate.Location = new Point(574, 148);
			lbdate.Name = "lbdate";
			lbdate.Size = new Size(83, 20);
			lbdate.TabIndex = 8;
			lbdate.Text = "Order Date";
			// 
			// lbTotal
			// 
			lbTotal.AutoSize = true;
			lbTotal.Location = new Point(574, 108);
			lbTotal.Name = "lbTotal";
			lbTotal.Size = new Size(42, 20);
			lbTotal.TabIndex = 9;
			lbTotal.Text = "Total";
			// 
			// dgvOrder
			// 
			dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvOrder.Location = new Point(34, 281);
			dgvOrder.Name = "dgvOrder";
			dgvOrder.RowHeadersWidth = 51;
			dgvOrder.RowTemplate.Height = 29;
			dgvOrder.Size = new Size(1029, 167);
			dgvOrder.TabIndex = 10;
			dgvOrder.DoubleClick += dgvOrder_DoubleClick;
			// 
			// btnEdit
			// 
			btnEdit.Location = new Point(675, 236);
			btnEdit.Name = "btnEdit";
			btnEdit.Size = new Size(94, 29);
			btnEdit.TabIndex = 12;
			btnEdit.Text = "Edit";
			btnEdit.UseVisualStyleBackColor = true;
			btnEdit.Click += btnEdit_Click;
			// 
			// btnClose
			// 
			btnClose.Location = new Point(305, 236);
			btnClose.Name = "btnClose";
			btnClose.Size = new Size(94, 29);
			btnClose.TabIndex = 14;
			btnClose.Text = "Close";
			btnClose.UseVisualStyleBackColor = true;
			btnClose.Click += btnClose_Click;
			// 
			// txtDate
			// 
			txtDate.Location = new Point(675, 145);
			txtDate.Name = "txtDate";
			txtDate.Size = new Size(316, 27);
			txtDate.TabIndex = 15;
			// 
			// txtTotal
			// 
			txtTotal.Location = new Point(675, 101);
			txtTotal.Name = "txtTotal";
			txtTotal.Size = new Size(316, 27);
			txtTotal.TabIndex = 16;
			// 
			// txtFullname
			// 
			txtFullname.Location = new Point(98, 189);
			txtFullname.Name = "txtFullname";
			txtFullname.Size = new Size(301, 27);
			txtFullname.TabIndex = 17;
			// 
			// txtPid
			// 
			txtPid.Location = new Point(98, 141);
			txtPid.Name = "txtPid";
			txtPid.Size = new Size(301, 27);
			txtPid.TabIndex = 18;
			// 
			// txtAccid
			// 
			txtAccid.Location = new Point(98, 101);
			txtAccid.Name = "txtAccid";
			txtAccid.Size = new Size(301, 27);
			txtAccid.TabIndex = 19;
			// 
			// lbStatus
			// 
			lbStatus.AutoSize = true;
			lbStatus.Location = new Point(574, 189);
			lbStatus.Name = "lbStatus";
			lbStatus.Size = new Size(49, 20);
			lbStatus.TabIndex = 20;
			lbStatus.Text = "Status";
			// 
			// txtStatus
			// 
			txtStatus.Location = new Point(675, 193);
			txtStatus.Name = "txtStatus";
			txtStatus.Size = new Size(136, 27);
			txtStatus.TabIndex = 21;
			// 
			// cbxStatus
			// 
			cbxStatus.FormattingEnabled = true;
			cbxStatus.Items.AddRange(new object[] { "Status", "Đã đặt hàng", "Đã xác nhận", "Đang vận chuyển", "Đã giao hàng", "Đã hoàn" });
			cbxStatus.Location = new Point(840, 193);
			cbxStatus.Name = "cbxStatus";
			cbxStatus.Size = new Size(151, 28);
			cbxStatus.TabIndex = 22;
			// 
			// frmManager
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1104, 450);
			Controls.Add(cbxStatus);
			Controls.Add(txtStatus);
			Controls.Add(lbStatus);
			Controls.Add(txtAccid);
			Controls.Add(txtPid);
			Controls.Add(txtFullname);
			Controls.Add(txtTotal);
			Controls.Add(txtDate);
			Controls.Add(btnClose);
			Controls.Add(btnEdit);
			Controls.Add(dgvOrder);
			Controls.Add(lbTotal);
			Controls.Add(lbdate);
			Controls.Add(lbPid);
			Controls.Add(lbFullName);
			Controls.Add(lbAccId);
			Controls.Add(btnSearch);
			Controls.Add(txtSearch);
			Controls.Add(cbxSearch);
			Controls.Add(btnAccount);
			Controls.Add(btnProductManager);
			Name = "frmManager";
			Text = "frmMain";
			Load += frmManager_Load;
			((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnProductManager;
		private Button btnAccount;
		private ComboBox cbxSearch;
		private TextBox txtSearch;
		private Button btnSearch;
		private Label lbAccId;
		private Label lbFullName;
		private Label lbPid;
		private Label lbdate;
		private Label lbTotal;
		private DataGridView dgvOrder;
		private Button btnEdit;
		private Button btnClose;
		private TextBox txtDate;
		private TextBox txtTotal;
		private TextBox txtFullname;
		private TextBox txtPid;
		private TextBox txtAccid;
		private Label lbStatus;
		private TextBox txtStatus;
		private ComboBox cbxStatus;
	}
}