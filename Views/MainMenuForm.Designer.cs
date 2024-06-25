namespace ControleDeEstoque.Views {
	partial class MainMenuForm {
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
			panel1 = new Panel();
			lblSystemLabel2 = new Label();
			lblSystemLabel = new Label();
			btnMainMenuClose = new Button();
			panel2 = new Panel();
			btnManageProducts = new Button();
			btnManageUsers = new Button();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.InactiveCaption;
			panel1.BackgroundImage = Properties.Resources.pexels_pixabay_372787;
			panel1.Controls.Add(lblSystemLabel2);
			panel1.Controls.Add(lblSystemLabel);
			panel1.Controls.Add(btnMainMenuClose);
			panel1.Location = new Point(254, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(548, 451);
			panel1.TabIndex = 1;
			// 
			// lblSystemLabel2
			// 
			lblSystemLabel2.AutoSize = true;
			lblSystemLabel2.BackColor = SystemColors.Window;
			lblSystemLabel2.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
			lblSystemLabel2.ForeColor = SystemColors.HotTrack;
			lblSystemLabel2.Location = new Point(44, 108);
			lblSystemLabel2.Name = "lblSystemLabel2";
			lblSystemLabel2.Size = new Size(364, 41);
			lblSystemLabel2.TabIndex = 2;
			lblSystemLabel2.Text = "CONTROLE DE ESTOQUE";
			// 
			// lblSystemLabel
			// 
			lblSystemLabel.AutoSize = true;
			lblSystemLabel.BackColor = SystemColors.Window;
			lblSystemLabel.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
			lblSystemLabel.ForeColor = SystemColors.HotTrack;
			lblSystemLabel.Location = new Point(44, 49);
			lblSystemLabel.Name = "lblSystemLabel";
			lblSystemLabel.Size = new Size(192, 41);
			lblSystemLabel.TabIndex = 1;
			lblSystemLabel.Text = "SISTEMA DE";
			// 
			// btnMainMenuClose
			// 
			btnMainMenuClose.BackColor = SystemColors.ActiveCaption;
			btnMainMenuClose.FlatAppearance.BorderSize = 0;
			btnMainMenuClose.FlatStyle = FlatStyle.Flat;
			btnMainMenuClose.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnMainMenuClose.ForeColor = SystemColors.ButtonHighlight;
			btnMainMenuClose.Location = new Point(496, 0);
			btnMainMenuClose.Name = "btnMainMenuClose";
			btnMainMenuClose.Size = new Size(52, 50);
			btnMainMenuClose.TabIndex = 0;
			btnMainMenuClose.Text = "X";
			btnMainMenuClose.UseVisualStyleBackColor = false;
			btnMainMenuClose.Click += btnMainMenuClose_Click;
			// 
			// panel2
			// 
			panel2.BackColor = SystemColors.ActiveCaption;
			panel2.Controls.Add(btnManageProducts);
			panel2.Controls.Add(btnManageUsers);
			panel2.Location = new Point(-1, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(257, 454);
			panel2.TabIndex = 2;
			// 
			// btnManageProducts
			// 
			btnManageProducts.BackColor = SystemColors.ButtonFace;
			btnManageProducts.FlatAppearance.BorderSize = 0;
			btnManageProducts.FlatStyle = FlatStyle.Flat;
			btnManageProducts.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnManageProducts.ForeColor = SystemColors.HotTrack;
			btnManageProducts.Location = new Point(13, 56);
			btnManageProducts.Name = "btnManageProducts";
			btnManageProducts.Size = new Size(236, 34);
			btnManageProducts.TabIndex = 1;
			btnManageProducts.Text = "Gestão de Produtos";
			btnManageProducts.UseVisualStyleBackColor = false;
			btnManageProducts.Click += btnManageProducts_Click;
			// 
			// btnManageUsers
			// 
			btnManageUsers.BackColor = SystemColors.ButtonFace;
			btnManageUsers.FlatAppearance.BorderSize = 0;
			btnManageUsers.FlatStyle = FlatStyle.Flat;
			btnManageUsers.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnManageUsers.ForeColor = SystemColors.HotTrack;
			btnManageUsers.Location = new Point(13, 16);
			btnManageUsers.Name = "btnManageUsers";
			btnManageUsers.Size = new Size(236, 34);
			btnManageUsers.TabIndex = 0;
			btnManageUsers.Text = "Gestão de Usuários";
			btnManageUsers.UseVisualStyleBackColor = false;
			btnManageUsers.Click += btnManageUsers_Click;
			// 
			// MainMenuForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(panel2);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "MainMenuForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "MainForm";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel2.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion
		private Panel panel1;
		private Panel panel2;
		private Button btnMainMenuClose;
		private Button btnManageUsers;
		private Button btnManageProducts;
		private Label lblSystemLabel;
		private Label lblSystemLabel2;
	}
}