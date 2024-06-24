using ControleDeEstoque.DAL;
using ControleDeEstoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Controllers {
	public class UserController {
		private readonly UserDAL userDAL;

		public UserController() {
			userDAL = new UserDAL();
		}

		public List<User> GetAllUsers() {
			return userDAL.GetAllUsers();
		}

		public void AddUser(User user) {
			userDAL.AddUser(user);
		}

		public void UpdateUser(User user) {
			userDAL.UpdateUser(user);
		}

		public void DeleteUser(int userId) {
			userDAL.DeleteUser(userId);
		}

		public User GetUserById(int userId) {
			return userDAL.GetUserById(userId);
		}
	}
}