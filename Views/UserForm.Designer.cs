namespace ControleDeEstoque.Views {
	partial class UserForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			dgvUsers = new DataGridView();
			lblUsername = new Label();
			lblPassword = new Label();
			lblFullname = new Label();
			lblEmail = new Label();
			lblRole = new Label();
			btnAddUser = new Button();
			txtUsername = new TextBox();
			txtPassword = new TextBox();
			txtFullname = new TextBox();
			txtEmail = new TextBox();
			txtRole = new TextBox();
			((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
			SuspendLayout();
			// 
			// dgvUsers
			// 
			dgvUsers.BorderStyle = BorderStyle.None;
			dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvUsers.Location = new Point(12, 242);
			dgvUsers.Name = "dgvUsers";
			dgvUsers.Size = new Size(776, 447);
			dgvUsers.TabIndex = 0;
			// 
			// lblUsername
			// 
			lblUsername.AutoSize = true;
			lblUsername.Location = new Point(12, 18);
			lblUsername.Name = "lblUsername";
			lblUsername.Size = new Size(60, 15);
			lblUsername.TabIndex = 1;
			lblUsername.Text = "Username";
			// 
			// lblPassword
			// 
			lblPassword.AutoSize = true;
			lblPassword.Location = new Point(12, 51);
			lblPassword.Name = "lblPassword";
			lblPassword.Size = new Size(57, 15);
			lblPassword.TabIndex = 2;
			lblPassword.Text = "Password";
			// 
			// lblFullname
			// 
			lblFullname.AutoSize = true;
			lblFullname.Location = new Point(12, 91);
			lblFullname.Name = "lblFullname";
			lblFullname.Size = new Size(56, 15);
			lblFullname.TabIndex = 3;
			lblFullname.Text = "Fullname";
			// 
			// lblEmail
			// 
			lblEmail.AutoSize = true;
			lblEmail.Location = new Point(12, 123);
			lblEmail.Name = "lblEmail";
			lblEmail.Size = new Size(36, 15);
			lblEmail.TabIndex = 4;
			lblEmail.Text = "Email";
			// 
			// lblRole
			// 
			lblRole.AutoSize = true;
			lblRole.Location = new Point(12, 155);
			lblRole.Name = "lblRole";
			lblRole.Size = new Size(30, 15);
			lblRole.TabIndex = 5;
			lblRole.Text = "Role";
			// 
			// btnAddUser
			// 
			btnAddUser.Location = new Point(12, 184);
			btnAddUser.Name = "btnAddUser";
			btnAddUser.Size = new Size(75, 23);
			btnAddUser.TabIndex = 6;
			btnAddUser.Text = "Salvar";
			btnAddUser.UseVisualStyleBackColor = true;
			btnAddUser.Click += btnAddUser_Click;
			// 
			// txtUsername
			// 
			txtUsername.Location = new Point(151, 15);
			txtUsername.Name = "txtUsername";
			txtUsername.Size = new Size(440, 23);
			txtUsername.TabIndex = 7;
			// 
			// txtPassword
			// 
			txtPassword.Location = new Point(151, 51);
			txtPassword.Name = "txtPassword";
			txtPassword.Size = new Size(440, 23);
			txtPassword.TabIndex = 8;
			// 
			// txtFullname
			// 
			txtFullname.Location = new Point(151, 83);
			txtFullname.Name = "txtFullname";
			txtFullname.Size = new Size(440, 23);
			txtFullname.TabIndex = 9;
			// 
			// txtEmail
			// 
			txtEmail.Location = new Point(151, 115);
			txtEmail.Name = "txtEmail";
			txtEmail.Size = new Size(440, 23);
			txtEmail.TabIndex = 10;
			// 
			// txtRole
			// 
			txtRole.Location = new Point(151, 147);
			txtRole.Name = "txtRole";
			txtRole.Size = new Size(440, 23);
			txtRole.TabIndex = 11;
			// 
			// UserForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 701);
			Controls.Add(txtRole);
			Controls.Add(txtEmail);
			Controls.Add(txtFullname);
			Controls.Add(txtPassword);
			Controls.Add(txtUsername);
			Controls.Add(btnAddUser);
			Controls.Add(lblRole);
			Controls.Add(lblEmail);
			Controls.Add(lblFullname);
			Controls.Add(lblPassword);
			Controls.Add(lblUsername);
			Controls.Add(dgvUsers);
			Name = "UserForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Gerenciamento de Usuários";
			((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dgvUsers;
		private Label lblUsername;
		private Label lblPassword;
		private Label lblFullname;
		private Label lblEmail;
		private Label lblRole;
		private Button btnAddUser;
		private TextBox txtUsername;
		private TextBox txtPassword;
		private TextBox txtFullname;
		private TextBox txtEmail;
		private TextBox txtRole;
	}
}