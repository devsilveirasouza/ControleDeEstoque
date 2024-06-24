using ControleDeEstoque.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;

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
				string query = "INSERT INTO TBL_USER (USERNAME, PASSWORD, FULL_NAME, EMAIL, ROLE) VALUES ( :Username, :Password, :FullName, :Email, :Role)";
				OracleCommand cmd = new OracleCommand(query, connection);
				cmd.Parameters.Add(new OracleParameter("Username", user.Username));
				cmd.Parameters.Add(new OracleParameter("Password", user.Password));
				cmd.Parameters.Add(new OracleParameter("FullName", user.FullName));
				cmd.Parameters.Add(new OracleParameter("Email", user.Email));
				cmd.Parameters.Add(new OracleParameter("Role", user.Role));
				cmd.ExecuteNonQuery();
			}
		}

		public void UpdateUser(User user) {
			if (user == null || string.IsNullOrEmpty(user.Username) || string.IsNullOrEmpty(user.Password) || string.IsNullOrEmpty(user.FullName) || string.IsNullOrEmpty(user.Email)) {
				throw new ArgumentException("User object and its fields must not be null or empty");
			}

			using (OracleConnection connection = DatabaseConnection.GetConnection()) {
				connection.Open();
				string query = "UPDATE TBL_USER SET USERNAME = :Username, PASSWORD = :Password, FULL_NAME = :FullName, EMAIL = :Email, ROLE = :Role WHERE USER_ID = :UserId";
				OracleCommand cmd = new OracleCommand(query, connection);
				cmd.Parameters.Add(new OracleParameter("Username", user.Username));
				cmd.Parameters.Add(new OracleParameter("Password", user.Password));
				cmd.Parameters.Add(new OracleParameter("FullName", user.FullName));
				cmd.Parameters.Add(new OracleParameter("Email", user.Email));
				cmd.Parameters.Add(new OracleParameter("Role", user.Role));
				cmd.Parameters.Add(new OracleParameter("UserId", user.UserId));
				cmd.ExecuteNonQuery();
			}
		}


		public void DeleteUser(int userId) {
			using (OracleConnection connection = DatabaseConnection.GetConnection()) {
				connection.Open();
				string query = "DELETE FROM TBL_USER WHERE USER_ID = :UserId";
				OracleCommand cmd = new OracleCommand(query, connection);
				cmd.Parameters.Add(new OracleParameter("UserId", userId));
				cmd.ExecuteNonQuery();
			}
		}

		public User GetUserById(int userId) {
			User user = null;

			using (OracleConnection connection = DatabaseConnection.GetConnection()) {
				connection.Open();
				string query = "SELECT USER_ID, USERNAME, PASSWORD, FULL_NAME, EMAIL, ROLE FROM TBL_USER WHERE USER_ID = :UserId";
				OracleCommand cmd = new OracleCommand(query, connection);
				cmd.Parameters.Add(new OracleParameter("UserId", userId));
				OracleDataReader reader = cmd.ExecuteReader();

				if (reader.Read()) {
					user = new User {
						UserId = Convert.ToInt32(reader["USER_ID"]),
						Username = reader["USERNAME"].ToString(),
						Password = reader["PASSWORD"].ToString(),
						FullName = reader["FULL_NAME"].ToString(),
						Email = reader["EMAIL"].ToString(),
						Role = reader["ROLE"].ToString()
					};
				}
			}

			return user;
		}
	}
}
