using ControleDeEstoque.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;

namespace ControleDeEstoque.DAL {
	public class ProductDAL {
		public List<Product> GetAllProducts() {
			List<Product> products = new List<Product>();

			using (OracleConnection connection = DatabaseConnection.GetConnection()) {
				connection.Open();
				string query = "SELECT PRODUCT_ID, NAME_PRODUCT, DESCRIPTION_PRODUCT, SUPPLIER_ID, CATEGORY_PRODUCT, PRICE FROM TBL_PRODUCT";
				OracleCommand cmd = new OracleCommand(query, connection);
				OracleDataReader reader = cmd.ExecuteReader();

				while (reader.Read()) {
					Product product = new Product {
						ProductId = Convert.ToInt32(reader["PRODUCT_ID"]),
						NameProduct = reader["NAME_PRODUCT"].ToString(),
						DescriptionProduct = reader["DESCRIPTION_PRODUCT"].ToString(),
						SupplierId = reader["SUPPLIER_ID"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["SUPPLIER_ID"]),
						CategoryProduct = reader["CATEGORY_PRODUCT"].ToString(),
						Price = Convert.ToDecimal(reader["PRICE"])
					};
					products.Add(product);
				}
			}

			return products;
		}

		public void AddProduct(Product product) {
			using (OracleConnection connection = DatabaseConnection.GetConnection()) {
				connection.Open();
				string query = "INSERT INTO TBL_PRODUCT (PRODUCT_ID, NAME_PRODUCT, DESCRIPTION_PRODUCT, SUPPLIER_ID, CATEGORY_PRODUCT, PRICE) VALUES (PRODUCT_SEQ.NEXTVAL, :NameProduct, :DescriptionProduct, :SupplierId, :CategoryProduct, :Price)";
				OracleCommand cmd = new OracleCommand(query, connection);
				cmd.Parameters.Add(new OracleParameter("NameProduct", product.NameProduct));
				cmd.Parameters.Add(new OracleParameter("DescriptionProduct", product.DescriptionProduct));
				cmd.Parameters.Add(new OracleParameter("SupplierId", product.SupplierId));
				cmd.Parameters.Add(new OracleParameter("CategoryProduct", product.CategoryProduct));
				cmd.Parameters.Add(new OracleParameter("Price", product.Price));
				cmd.ExecuteNonQuery();
			}
		}

		public void UpdateProduct(Product product) {
			using (OracleConnection connection = DatabaseConnection.GetConnection()) {
				connection.Open();
				string query = "UPDATE TBL_PRODUCT SET NAME_PRODUCT = :NameProduct, DESCRIPTION_PRODUCT = :DescriptionProduct, SUPPLIER_ID = :SupplierId, CATEGORY_PRODUCT = :CategoryProduct, PRICE = :Price WHERE PRODUCT_ID = :ProductId";
				OracleCommand cmd = new OracleCommand(query, connection);
				cmd.Parameters.Add(new OracleParameter("NameProduct", product.NameProduct));
				cmd.Parameters.Add(new OracleParameter("DescriptionProduct", product.DescriptionProduct));
				cmd.Parameters.Add(new OracleParameter("SupplierId", product.SupplierId));
				cmd.Parameters.Add(new OracleParameter("CategoryProduct", product.CategoryProduct));
				cmd.Parameters.Add(new OracleParameter("Price", product.Price));
				cmd.Parameters.Add(new OracleParameter("ProductId", product.ProductId));
				cmd.ExecuteNonQuery();
			}
		}

		public void DeleteProduct(int productId) {
			using (OracleConnection connection = DatabaseConnection.GetConnection()) {
				connection.Open();
				string query = "DELETE FROM TBL_PRODUCT WHERE PRODUCT_ID = :ProductId";
				OracleCommand cmd = new OracleCommand(query, connection);
				cmd.Parameters.Add(new OracleParameter("ProductId", productId));
				cmd.ExecuteNonQuery();
			}
		}

		public Product GetProductById(int productId) {
			Product product = null;

			using (OracleConnection connection = DatabaseConnection.GetConnection()) {
				connection.Open();
				string query = "SELECT PRODUCT_ID, NAME_PRODUCT, DESCRIPTION_PRODUCT, SUPPLIER_ID, CATEGORY_PRODUCT, PRICE FROM TBL_PRODUCT WHERE PRODUCT_ID = :ProductId";
				OracleCommand cmd = new OracleCommand(query, connection);
				cmd.Parameters.Add(new OracleParameter("ProductId", productId));
				OracleDataReader reader = cmd.ExecuteReader();

				if (reader.Read()) {
					product = new Product {
						ProductId = Convert.ToInt32(reader["PRODUCT_ID"]),
						NameProduct = reader["NAME_PRODUCT"].ToString(),
						DescriptionProduct = reader["DESCRIPTION_PRODUCT"].ToString(),
						SupplierId = reader["SUPPLIER_ID"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["SUPPLIER_ID"]),
						CategoryProduct = reader["CATEGORY_PRODUCT"].ToString(),
						Price = Convert.ToDecimal(reader["PRICE"])
					};
				}
			}

			return product;
		}
	}
}
