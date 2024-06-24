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
			List<User> users = userController.GetAllUsers();
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

			txtUserId.Text = "";
			txtUsername.Text = "";
			txtPassword.Text = "";
			txtFullname.Text = "";
			txtEmail.Text = "";
			txtRole.Text = "";
		}

		private void btnUpdate_Click(object sender, EventArgs e) {

			//int userId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["UserId"].Value);
			if (string.IsNullOrEmpty(txtUserId.Text)) {
				MessageBox.Show("Please enter a User ID to update.");
			}
			User user = new User {
				UserId = Convert.ToInt32(txtUserId.Text),
				Username = txtUsername.Text,
				Password = txtPassword.Text,
				FullName = txtFullname.Text,
				Email = txtEmail.Text,
				Role = txtRole.Text
			};
			userController.UpdateUser(user);
			LoadUsers();

			txtUserId.Text = "";
			txtUsername.Text = "";
			txtPassword.Text = "";
			txtFullname.Text = "";
			txtEmail.Text = "";
			txtRole.Text = "";
		}

		private void btnDelete_Click(object sender, EventArgs e) {
			if (dgvUsers.SelectedRows.Count > 0) {
				int userId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["UserId"].Value);
				userController.DeleteUser(userId);
				LoadUsers();
			}
			else {
				MessageBox.Show("Please select a user to delete.");
			}
			txtUserId.Text = "";
			txtUsername.Text = "";
			txtPassword.Text = "";
			txtFullname.Text = "";
			txtEmail.Text = "";
			txtRole.Text = "";
		}

		private void btnGetById_Click(object sender, EventArgs e) {
			if (!int.TryParse(txtUserId.Text, out int userId)) {
				MessageBox.Show("Please enter a valid User ID.");
				return;
			}

			User user = userController.GetUserById(userId);
			if (user != null) {
				txtUsername.Text = user.Username;
				txtPassword.Text = user.Password;
				txtFullname.Text = user.FullName;
				txtEmail.Text = user.Email;
				txtRole.Text = user.Role;
			}
			else {
				MessageBox.Show("User not found.");
			}
		}


		private void dgvUsers_SelectionChanged(object sender, EventArgs e) {
			if (dgvUsers.SelectedRows.Count > 0) {
				txtUserId.Text = dgvUsers.SelectedRows[0].Cells["UserId"].Value.ToString();
				txtUsername.Text = dgvUsers.SelectedRows[0].Cells["Username"].Value.ToString();
				txtPassword.Text = dgvUsers.SelectedRows[0].Cells["Password"].Value.ToString();
				txtFullname.Text = dgvUsers.SelectedRows[0].Cells["FullName"].Value.ToString();
				txtEmail.Text = dgvUsers.SelectedRows[0].Cells["Email"].Value.ToString();
				txtRole.Text = dgvUsers.SelectedRows[0].Cells["Role"].Value.ToString();
			}
		}

		private void btnClear_Click(object sender, EventArgs e) {
			txtUserId.Text = "";
			txtUsername.Text = "";
			txtPassword.Text = "";
			txtFullname.Text = "";
			txtEmail.Text = "";
			txtRole.Text = "";
		}
	}
}
