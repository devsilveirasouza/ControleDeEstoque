using ControleDeEstoque.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.DAL {
	public class UserDAL {
		public List<User> GetAllUsers() {
			List<User> users = new List<User>();

			using (OracleConnection connection = DatabaseConnection.GetConnection()) {
				connection.Open();
				string query = "SELECT USER_ID, USERNAME, PASSWORD, FULL_NAME, EMAIL, ROLE FROM TBL_USER";
				OracleCommand cmd = new OracleCommand(query, connection);
				OracleDataReader reader = cmd.ExecuteReader();

				while (reader.Read()) {
					User user = new User {
						UserId = Convert.ToInt32(reader["USER_ID"]),
						Username = reader["USERNAME"].ToString(),
						Password = reader["PASSWORD"].ToString(),
						FullName = reader["FULL_NAME"].ToString(),
						Email = reader["EMAIL"].ToString(),
						Role = reader["ROLE"].ToString()
					};
					users.Add(user);
				}
			}

			return users;
		}

		public void AddUser(User user) {
			using (OracleConnection connection = DatabaseConnection.GetConnection()) {
				connection.Open();
				string query = "INSERT INTO TBL_USER (USER_ID, USERNAME, PASSWORD, FULL_NAME, EMAIL, ROLE) VALUES (USER_SEQ.NEXTVAL, :Username, :Password, :FullName, :Email, :Role)";
				OracleCommand cmd = new OracleCommand(query, connection);
				cmd.Parameters.Add(new OracleParameter("Username", user.Username));
				cmd.Parameters.Add(new OracleParameter("Password", user.Password));
				cmd.Parameters.Add(new OracleParameter("FullName", user.FullName));
				cmd.Parameters.Add(new OracleParameter("Email", user.Email));
				cmd.Parameters.Add(new OracleParameter("Role", user.Role));
				cmd.ExecuteNonQuery();
			}
		}

		// Métodos UpdateUser e DeleteUser podem ser adicionados de maneira similar
	}
}
