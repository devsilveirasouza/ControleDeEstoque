using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Models {
	public class Product {
		public int ProductId { get; set; }
		public string NameProduct { get; set; }
		public string DescriptionProduct { get; set; }
		public int? SupplierId { get; set; }
		public string CategoryProduct { get; set; }
		public decimal Price { get; set; }
	}
}

