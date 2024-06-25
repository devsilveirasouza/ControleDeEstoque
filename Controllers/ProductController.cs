using ControleDeEstoque.DAL;
using ControleDeEstoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Controllers {
	public class ProductController {
		private readonly ProductDAL productDAL;

		public ProductController() {
			productDAL = new ProductDAL();
		}

		public List<Product> GetAllProducts() {
			return productDAL.GetAllProducts();
		}

		public void AddProduct(Product product) {
			productDAL.AddProduct(product);
		}

		public void UpdateProduct(Product product) {
			productDAL.UpdateProduct(product);
		}

		public void DeleteProduct(int productId) {
			productDAL.DeleteProduct(productId);
		}

		public Product GetProductById(int productId) {
			return productDAL.GetProductById(productId);
		}

	}

}
