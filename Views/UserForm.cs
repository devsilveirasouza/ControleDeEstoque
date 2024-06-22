using ControleDeEstoque.Controllers;
using ControleDeEstoque.Models;
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
	public partial class UserForm : Form {
		private readonly UserController userController;

		public UserForm() {
			InitializeComponent();
			userController = new UserController();
			LoadUsers();
		}

		private void LoadUsers() {
			var users = userController.GetAllUsers();
			dgvUsers.DataSource = users;
		}

		private void btnAddUser_Click(object sender, EventArgs e) {
			User user = new User {
				Username = txtUsername.Text,
				Password = txtPassword.Text,
				FullName = txtFullname.Text,
				Email = txtEmail.Text,
				Role = txtRole.Text
			};

			userController.AddUser(user);
			LoadUsers();
		}
		// Métodos para atualizar e deletar usuários podem ser adicionados de maneira similiar
	}
}
