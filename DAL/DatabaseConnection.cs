using System;
using System.Collections.Generic;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Configuration;

namespace ControleDeEstoque.DAL {
	public static class DatabaseConnection {
		private static string connectionString = ConfigurationManager.ConnectionStrings["OracleDbContext"].ConnectionString;

		public static OracleConnection GetConnection() {
			return new OracleConnection(connectionString);
		}
	}
}
