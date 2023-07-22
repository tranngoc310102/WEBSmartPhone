namespace Manager
{
	partial class frmLogin
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
			btnLogin = new Button();
			btnCancel = new Button();
			lbTextLogin = new Label();
			lbEmail = new Label();
			lbPass = new Label();
			txtEmail = new TextBox();
			txtPass = new TextBox();
			SuspendLayout();
			// 
			// btnLogin
			// 
			btnLogin.Location = new Point(204, 209);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(105, 29);
			btnLogin.TabIndex = 3;
			btnLogin.Text = "Login";
			btnLogin.UseVisualStyleBackColor = true;
			btnLogin.Click += btnLogin_Click;
			// 
			// btnCancel
			// 
			btnCancel.Location = new Point(304, 209);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(105, 29);
			btnCancel.TabIndex = 4;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = true;
			btnCancel.Click += btnCancel_Click;
			// 
			// lbTextLogin
			// 
			lbTextLogin.AutoSize = true;
			lbTextLogin.Location = new Point(220, 19);
			lbTextLogin.Name = "lbTextLogin";
			lbTextLogin.Size = new Size(84, 20);
			lbTextLogin.TabIndex = 2;
			lbTextLogin.Text = "Form Login";
			lbTextLogin.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// lbEmail
			// 
			lbEmail.AutoSize = true;
			lbEmail.Location = new Point(95, 104);
			lbEmail.Name = "lbEmail";
			lbEmail.Size = new Size(46, 20);
			lbEmail.TabIndex = 5;
			lbEmail.Text = "Email";
			// 
			// lbPass
			// 
			lbPass.AutoSize = true;
			lbPass.Location = new Point(95, 161);
			lbPass.Name = "lbPass";
			lbPass.Size = new Size(70, 20);
			lbPass.TabIndex = 6;
			lbPass.Text = "Password";
			// 
			// txtEmail
			// 
			txtEmail.Location = new Point(204, 97);
			txtEmail.Name = "txtEmail";
			txtEmail.Size = new Size(205, 27);
			txtEmail.TabIndex = 1;
			// 
			// txtPass
			// 
			txtPass.Location = new Point(204, 154);
			txtPass.Name = "txtPass";
			txtPass.Size = new Size(205, 27);
			txtPass.TabIndex = 2;
			// 
			// frmLogin
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(513, 291);
			Controls.Add(txtPass);
			Controls.Add(txtEmail);
			Controls.Add(lbPass);
			Controls.Add(lbEmail);
			Controls.Add(lbTextLogin);
			Controls.Add(btnCancel);
			Controls.Add(btnLogin);
			Name = "frmLogin";
			Text = "frmLogin";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnLogin;
		private Button btnCancel;
		private Label lbTextLogin;
		private Label lbEmail;
		private Label lbPass;
		private TextBox txtEmail;
		private TextBox txtPass;
	}
}