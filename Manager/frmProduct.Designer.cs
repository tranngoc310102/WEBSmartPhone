namespace Manager
{
	partial class frmProduct
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
			lbCreate = new Label();
			lbPname = new Label();
			lbCid = new Label();
			lbPrice = new Label();
			lbPimg = new Label();
			txtPimg = new TextBox();
			txtPname = new TextBox();
			txtPrice = new TextBox();
			cbxCate = new ComboBox();
			lbNewCate = new Label();
			txtCname = new TextBox();
			lbNote = new Label();
			lbCname = new Label();
			txtNote = new TextBox();
			btnNewCate = new Button();
			btnNewPro = new Button();
			btnClose = new Button();
			SuspendLayout();
			// 
			// lbCreate
			// 
			lbCreate.AutoSize = true;
			lbCreate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			lbCreate.Location = new Point(84, 19);
			lbCreate.Name = "lbCreate";
			lbCreate.Size = new Size(215, 31);
			lbCreate.TabIndex = 5;
			lbCreate.Text = "Create new product";
			// 
			// lbPname
			// 
			lbPname.AutoSize = true;
			lbPname.Location = new Point(12, 83);
			lbPname.Name = "lbPname";
			lbPname.Size = new Size(104, 20);
			lbPname.TabIndex = 1;
			lbPname.Text = "Product Name";
			// 
			// lbCid
			// 
			lbCid.AutoSize = true;
			lbCid.Location = new Point(12, 144);
			lbCid.Name = "lbCid";
			lbCid.Size = new Size(84, 20);
			lbCid.TabIndex = 2;
			lbCid.Text = "CategoryID";
			// 
			// lbPrice
			// 
			lbPrice.AutoSize = true;
			lbPrice.Location = new Point(12, 202);
			lbPrice.Name = "lbPrice";
			lbPrice.Size = new Size(41, 20);
			lbPrice.TabIndex = 3;
			lbPrice.Text = "Price";
			// 
			// lbPimg
			// 
			lbPimg.AutoSize = true;
			lbPimg.Location = new Point(12, 254);
			lbPimg.Name = "lbPimg";
			lbPimg.Size = new Size(112, 20);
			lbPimg.TabIndex = 4;
			lbPimg.Text = "Product Images";
			lbPimg.Click += lbPimg_Click;
			// 
			// txtPimg
			// 
			txtPimg.Location = new Point(138, 247);
			txtPimg.Name = "txtPimg";
			txtPimg.Size = new Size(197, 27);
			txtPimg.TabIndex = 10;
			// 
			// txtPname
			// 
			txtPname.Location = new Point(138, 76);
			txtPname.Name = "txtPname";
			txtPname.Size = new Size(197, 27);
			txtPname.TabIndex = 7;
			// 
			// txtPrice
			// 
			txtPrice.Location = new Point(138, 195);
			txtPrice.Name = "txtPrice";
			txtPrice.Size = new Size(197, 27);
			txtPrice.TabIndex = 9;
			// 
			// cbxCate
			// 
			cbxCate.FormattingEnabled = true;
			cbxCate.Location = new Point(138, 136);
			cbxCate.Name = "cbxCate";
			cbxCate.Size = new Size(197, 28);
			cbxCate.TabIndex = 11;
			// 
			// lbNewCate
			// 
			lbNewCate.AutoSize = true;
			lbNewCate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			lbNewCate.Location = new Point(407, 19);
			lbNewCate.Name = "lbNewCate";
			lbNewCate.Size = new Size(226, 31);
			lbNewCate.TabIndex = 12;
			lbNewCate.Text = "Create new Category";
			// 
			// txtCname
			// 
			txtCname.Location = new Point(483, 80);
			txtCname.Name = "txtCname";
			txtCname.Size = new Size(150, 27);
			txtCname.TabIndex = 17;
			// 
			// lbNote
			// 
			lbNote.AutoSize = true;
			lbNote.Location = new Point(364, 144);
			lbNote.Name = "lbNote";
			lbNote.Size = new Size(42, 20);
			lbNote.TabIndex = 15;
			lbNote.Text = "Note";
			// 
			// lbCname
			// 
			lbCname.AutoSize = true;
			lbCname.Location = new Point(364, 83);
			lbCname.Name = "lbCname";
			lbCname.Size = new Size(113, 20);
			lbCname.TabIndex = 14;
			lbCname.Text = "Category Name";
			// 
			// txtNote
			// 
			txtNote.Location = new Point(483, 141);
			txtNote.Name = "txtNote";
			txtNote.Size = new Size(150, 27);
			txtNote.TabIndex = 18;
			// 
			// btnNewCate
			// 
			btnNewCate.Location = new Point(483, 214);
			btnNewCate.Name = "btnNewCate";
			btnNewCate.Size = new Size(150, 29);
			btnNewCate.TabIndex = 19;
			btnNewCate.Text = "Create Category";
			btnNewCate.UseVisualStyleBackColor = true;
			btnNewCate.Click += btnNewCate_Click;
			// 
			// btnNewPro
			// 
			btnNewPro.Location = new Point(220, 344);
			btnNewPro.Name = "btnNewPro";
			btnNewPro.Size = new Size(165, 29);
			btnNewPro.TabIndex = 20;
			btnNewPro.Text = "Create Product";
			btnNewPro.UseVisualStyleBackColor = true;
			btnNewPro.Click += btnNewPro_Click;
			// 
			// btnClose
			// 
			btnClose.Location = new Point(28, 344);
			btnClose.Name = "btnClose";
			btnClose.Size = new Size(144, 29);
			btnClose.TabIndex = 21;
			btnClose.Text = "Close";
			btnClose.UseVisualStyleBackColor = true;
			btnClose.Click += btnClose_Click;
			// 
			// frmProduct
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(658, 450);
			Controls.Add(btnClose);
			Controls.Add(btnNewPro);
			Controls.Add(btnNewCate);
			Controls.Add(txtNote);
			Controls.Add(txtCname);
			Controls.Add(lbNote);
			Controls.Add(lbCname);
			Controls.Add(lbNewCate);
			Controls.Add(cbxCate);
			Controls.Add(txtPimg);
			Controls.Add(txtPrice);
			Controls.Add(txtPname);
			Controls.Add(lbCreate);
			Controls.Add(lbPimg);
			Controls.Add(lbPrice);
			Controls.Add(lbCid);
			Controls.Add(lbPname);
			Name = "frmProduct";
			Text = "frmProduct";
			Load += frmProduct_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lbCreate;
		private Label lbPname;
		private Label lbCid;
		private Label lbPrice;
		private Label lbPimg;
		private TextBox txtPimg;
		private TextBox txtPname;
		private TextBox txtPrice;
		private ComboBox cbxCate;
		private Label lbNewCate;
		private TextBox txtCname;
		private Label lbNote;
		private Label lbCname;
		private TextBox txtNote;
		private Button btnNewCate;
		private Button btnNewPro;
		private Button btnClose;
	}
}