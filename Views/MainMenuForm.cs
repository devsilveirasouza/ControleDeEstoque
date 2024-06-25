using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeEstoque.Views {
	public partial class MainMenuForm : Form {
		public MainMenuForm() {
			InitializeComponent();
		}

		private void btnMainMenuClose_Click(object sender, EventArgs e) {
			Application.Exit();
		}

		private void btnManageUsers_Click(object sender, EventArgs e) {
			UserForm userForm = new UserForm();
			userForm.ShowDialog();
		}

		private void btnManageProducts_Click(object sender, EventArgs e) {
			ProductForm productForm = new ProductForm();
			productForm.ShowDialog();
		}
	}
}
