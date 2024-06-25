using ControleDeEstoque.Controllers;
using ControleDeEstoque.Models;
using Oracle.DataAccess.Client;
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
	public partial class ProductForm : Form {

		private readonly ProductController productController;

		public ProductForm() {
			InitializeComponent();
			productController = new ProductController();
			LoadProducts();
		}

		private void LoadProducts() {
			List<Product> products = productController.GetAllProducts();
			dgvProducts.DataSource = products;
			dgvProducts.Columns["ProductId"].Visible = true;
			dgvProducts.Columns["NameProduct"].HeaderText = "Name";
			dgvProducts.Columns["DescriptionProduct"].HeaderText = "Description";
			dgvProducts.Columns["SupplierId"].HeaderText = "Supplier ID";
			dgvProducts.Columns["CategoryProduct"].HeaderText = "Category";
			dgvProducts.Columns["Price"].HeaderText = "Price";
		}

		private void dgvProducts_SelectionChanged(object sender, EventArgs e) {
			if (dgvProducts.SelectedRows.Count > 0) {
				DataGridViewRow selectedRow = dgvProducts.SelectedRows[0];
				txtProductId.Text = selectedRow.Cells["ProductId"].Value.ToString();
				txtNameProduct.Text = selectedRow.Cells["NameProduct"].Value.ToString();
				txtDescriptionProduct.Text = selectedRow.Cells["DescriptionProduct"].Value.ToString();
				txtSupplierId.Text = selectedRow.Cells["SupplierId"].Value.ToString();
				txtCategoryProduct.Text = selectedRow.Cells["CategoryProduct"].Value.ToString();
				txtPrice.Text = selectedRow.Cells["Price"].Value.ToString();
			}
		}

		private void btnAdd_Click(object sender, EventArgs e) {
			Product product = new Product {
				NameProduct = txtNameProduct.Text,
				DescriptionProduct = txtDescriptionProduct.Text,
				SupplierId = string.IsNullOrEmpty(txtSupplierId.Text) ? (int?)null : Convert.ToInt32(txtSupplierId.Text),
				CategoryProduct = txtCategoryProduct.Text,
				Price = Convert.ToDecimal(txtPrice.Text)
			};
			productController.AddProduct(product);
			LoadProducts();

			txtNameProduct.Text = "";
			txtDescriptionProduct.Text = "";
			txtSupplierId.Text = "";
			txtCategoryProduct.Text = "";
			txtPrice.Text = "";
			txtProductId.Text = "";
		}

		private void btnUpdate_Click(object sender, EventArgs e) {
			try {
				if (string.IsNullOrEmpty(txtProductId.Text)) {
					MessageBox.Show("Please enter a Product ID to update.");
					return;
				}

				Product product = new Product {
					ProductId = Convert.ToInt32(txtProductId.Text),
					NameProduct = txtNameProduct.Text,
					DescriptionProduct = txtDescriptionProduct.Text,
					SupplierId = string.IsNullOrEmpty(txtSupplierId.Text) ? (int?)null : Convert.ToInt32(txtSupplierId.Text),
					CategoryProduct = txtCategoryProduct.Text,
					Price = Convert.ToDecimal(txtPrice.Text)
				};

				productController.UpdateProduct(product);
				LoadProducts();

				txtNameProduct.Text = "";
				txtDescriptionProduct.Text = "";
				txtSupplierId.Text = "";
				txtCategoryProduct.Text = "";
				txtPrice.Text = "";
				txtProductId.Text = "";
			}
			catch (FormatException fe) {
				MessageBox.Show($"Format error: {fe.Message}");
			}
			catch (OracleException oe) {
				MessageBox.Show($"Database error: {oe.Message}");
			}
			catch (Exception ex) {
				MessageBox.Show($"Unexpected error: {ex.Message}");
			}
		}

		private void btnGetById_Click(object sender, EventArgs e) {
			if (string.IsNullOrEmpty(txtProductId.Text)) {
				MessageBox.Show("Please enter a Product ID to search.");
				return;
			}

			int productId = Convert.ToInt32(txtProductId.Text);
			Product product = productController.GetProductById(productId);

			if (product != null) {
				txtNameProduct.Text = product.NameProduct;
				txtDescriptionProduct.Text = product.DescriptionProduct;
				txtSupplierId.Text = product.SupplierId.ToString();
				txtCategoryProduct.Text = product.CategoryProduct;
				txtPrice.Text = product.Price.ToString();
			}
			else {
				MessageBox.Show("Product not found.");
			}
		}

		private void btnClear_Click(object sender, EventArgs e) {
			txtNameProduct.Text = "";
			txtDescriptionProduct.Text = "";
			txtSupplierId.Text = "";
			txtCategoryProduct.Text = "";
			txtPrice.Text = "";
			txtProductId.Text = "";
		}

		private void btnDelete_Click(object sender, EventArgs e) {
			if (string.IsNullOrEmpty(txtProductId.Text)) {
				MessageBox.Show("Please enter a Product ID to delete.");
				return;
			}

			int productId = Convert.ToInt32(txtProductId.Text);
			productController.DeleteProduct(productId);
			LoadProducts();

			txtNameProduct.Text = "";
			txtDescriptionProduct.Text = "";
			txtSupplierId.Text = "";
			txtCategoryProduct.Text = "";
			txtPrice.Text = "";
			txtProductId.Text = "";
		}
	}
}
