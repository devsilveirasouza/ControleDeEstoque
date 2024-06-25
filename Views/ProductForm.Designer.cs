namespace ControleDeEstoque.Views {
	partial class ProductForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			btnAdd = new Button();
			btnUpdate = new Button();
			btnDelete = new Button();
			btnGetById = new Button();
			btnClear = new Button();
			lblProductId = new Label();
			txtProductId = new TextBox();
			lblNameProduct = new Label();
			lblDescriptionProduct = new Label();
			lblSupplierId = new Label();
			lblCategoryProduct = new Label();
			lblPrice = new Label();
			txtNameProduct = new TextBox();
			txtDescriptionProduct = new TextBox();
			txtSupplierId = new TextBox();
			txtCategoryProduct = new TextBox();
			txtPrice = new TextBox();
			dgvProducts = new DataGridView();
			((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
			SuspendLayout();
			// 
			// btnAdd
			// 
			btnAdd.Location = new Point(698, 29);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(75, 23);
			btnAdd.TabIndex = 0;
			btnAdd.Text = "Salvar";
			btnAdd.UseVisualStyleBackColor = true;
			btnAdd.Click += btnAdd_Click;
			// 
			// btnUpdate
			// 
			btnUpdate.Location = new Point(698, 60);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(75, 23);
			btnUpdate.TabIndex = 1;
			btnUpdate.Text = "Atualizar";
			btnUpdate.UseVisualStyleBackColor = true;
			btnUpdate.Click += btnUpdate_Click;
			// 
			// btnDelete
			// 
			btnDelete.Location = new Point(698, 89);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(75, 23);
			btnDelete.TabIndex = 2;
			btnDelete.Text = "Deletar";
			btnDelete.UseVisualStyleBackColor = true;
			btnDelete.Click += btnDelete_Click;
			// 
			// btnGetById
			// 
			btnGetById.Location = new Point(269, 30);
			btnGetById.Name = "btnGetById";
			btnGetById.Size = new Size(75, 23);
			btnGetById.TabIndex = 3;
			btnGetById.Text = "Pesquisar";
			btnGetById.UseVisualStyleBackColor = true;
			btnGetById.Click += btnGetById_Click;
			// 
			// btnClear
			// 
			btnClear.Location = new Point(698, 118);
			btnClear.Name = "btnClear";
			btnClear.Size = new Size(75, 23);
			btnClear.TabIndex = 4;
			btnClear.Text = "Limpar";
			btnClear.UseVisualStyleBackColor = true;
			btnClear.Click += btnClear_Click;
			// 
			// lblProductId
			// 
			lblProductId.AutoSize = true;
			lblProductId.Location = new Point(28, 33);
			lblProductId.Name = "lblProductId";
			lblProductId.Size = new Size(63, 15);
			lblProductId.TabIndex = 5;
			lblProductId.Text = "Product ID";
			// 
			// txtProductId
			// 
			txtProductId.Location = new Point(128, 29);
			txtProductId.Name = "txtProductId";
			txtProductId.Size = new Size(100, 23);
			txtProductId.TabIndex = 6;
			// 
			// lblNameProduct
			// 
			lblNameProduct.AutoSize = true;
			lblNameProduct.Location = new Point(28, 60);
			lblNameProduct.Name = "lblNameProduct";
			lblNameProduct.Size = new Size(39, 15);
			lblNameProduct.TabIndex = 7;
			lblNameProduct.Text = "Name";
			// 
			// lblDescriptionProduct
			// 
			lblDescriptionProduct.AutoSize = true;
			lblDescriptionProduct.Location = new Point(28, 89);
			lblDescriptionProduct.Name = "lblDescriptionProduct";
			lblDescriptionProduct.Size = new Size(67, 15);
			lblDescriptionProduct.TabIndex = 8;
			lblDescriptionProduct.Text = "Description";
			// 
			// lblSupplierId
			// 
			lblSupplierId.AutoSize = true;
			lblSupplierId.Location = new Point(28, 118);
			lblSupplierId.Name = "lblSupplierId";
			lblSupplierId.Size = new Size(50, 15);
			lblSupplierId.TabIndex = 9;
			lblSupplierId.Text = "Supplier";
			// 
			// lblCategoryProduct
			// 
			lblCategoryProduct.AutoSize = true;
			lblCategoryProduct.Location = new Point(28, 147);
			lblCategoryProduct.Name = "lblCategoryProduct";
			lblCategoryProduct.Size = new Size(55, 15);
			lblCategoryProduct.TabIndex = 10;
			lblCategoryProduct.Text = "Category";
			// 
			// lblPrice
			// 
			lblPrice.AutoSize = true;
			lblPrice.Location = new Point(28, 176);
			lblPrice.Name = "lblPrice";
			lblPrice.Size = new Size(33, 15);
			lblPrice.TabIndex = 11;
			lblPrice.Text = "Price";
			// 
			// txtNameProduct
			// 
			txtNameProduct.Location = new Point(129, 57);
			txtNameProduct.Name = "txtNameProduct";
			txtNameProduct.Size = new Size(215, 23);
			txtNameProduct.TabIndex = 12;
			// 
			// txtDescriptionProduct
			// 
			txtDescriptionProduct.Location = new Point(129, 86);
			txtDescriptionProduct.Name = "txtDescriptionProduct";
			txtDescriptionProduct.Size = new Size(215, 23);
			txtDescriptionProduct.TabIndex = 13;
			// 
			// txtSupplierId
			// 
			txtSupplierId.Location = new Point(128, 115);
			txtSupplierId.Name = "txtSupplierId";
			txtSupplierId.Size = new Size(215, 23);
			txtSupplierId.TabIndex = 14;
			// 
			// txtCategoryProduct
			// 
			txtCategoryProduct.Location = new Point(128, 144);
			txtCategoryProduct.Name = "txtCategoryProduct";
			txtCategoryProduct.Size = new Size(215, 23);
			txtCategoryProduct.TabIndex = 15;
			// 
			// txtPrice
			// 
			txtPrice.Location = new Point(128, 173);
			txtPrice.Name = "txtPrice";
			txtPrice.Size = new Size(100, 23);
			txtPrice.TabIndex = 16;
			// 
			// dgvProducts
			// 
			dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvProducts.Location = new Point(28, 216);
			dgvProducts.Name = "dgvProducts";
			dgvProducts.Size = new Size(745, 209);
			dgvProducts.TabIndex = 17;
			// 
			// ProductForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(dgvProducts);
			Controls.Add(txtPrice);
			Controls.Add(txtCategoryProduct);
			Controls.Add(txtSupplierId);
			Controls.Add(txtDescriptionProduct);
			Controls.Add(txtNameProduct);
			Controls.Add(lblPrice);
			Controls.Add(lblCategoryProduct);
			Controls.Add(lblSupplierId);
			Controls.Add(lblDescriptionProduct);
			Controls.Add(lblNameProduct);
			Controls.Add(txtProductId);
			Controls.Add(lblProductId);
			Controls.Add(btnClear);
			Controls.Add(btnGetById);
			Controls.Add(btnDelete);
			Controls.Add(btnUpdate);
			Controls.Add(btnAdd);
			Name = "ProductForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Gerenciador de Produtos";
			((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnAdd;
		private Button btnUpdate;
		private Button btnDelete;
		private Button btnGetById;
		private Button btnClear;
		private Label lblProductId;
		private TextBox txtProductId;
		private Label lblNameProduct;
		private Label lblDescriptionProduct;
		private Label lblSupplierId;
		private Label lblCategoryProduct;
		private Label lblPrice;
		private TextBox txtNameProduct;
		private TextBox txtDescriptionProduct;
		private TextBox txtSupplierId;
		private TextBox txtCategoryProduct;
		private TextBox txtPrice;
		private DataGridView dgvProducts;
	}
}