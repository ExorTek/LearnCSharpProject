
namespace Project1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxProductName = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.tbxProduct = new System.Windows.Forms.TextBox();
            this.gbxCategory.SuspendLayout();
            this.gbxProductName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.label1);
            this.gbxCategory.Controls.Add(this.cbxCategory);
            this.gbxCategory.Location = new System.Drawing.Point(12, 12);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(237, 79);
            this.gbxCategory.TabIndex = 0;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Category List";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(47, 41);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(121, 24);
            this.cbxCategory.TabIndex = 0;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category";
            // 
            // gbxProductName
            // 
            this.gbxProductName.Controls.Add(this.tbxProduct);
            this.gbxProductName.Controls.Add(this.label2);
            this.gbxProductName.Location = new System.Drawing.Point(255, 12);
            this.gbxProductName.Name = "gbxProductName";
            this.gbxProductName.Size = new System.Drawing.Size(237, 79);
            this.gbxProductName.TabIndex = 1;
            this.gbxProductName.TabStop = false;
            this.gbxProductName.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product Name";
            // 
            // dgwProducts
            // 
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(13, 97);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.RowHeadersWidth = 51;
            this.dgwProducts.RowTemplate.Height = 24;
            this.dgwProducts.Size = new System.Drawing.Size(887, 304);
            this.dgwProducts.TabIndex = 2;
            // 
            // tbxProduct
            // 
            this.tbxProduct.Location = new System.Drawing.Point(62, 38);
            this.tbxProduct.Name = "tbxProduct";
            this.tbxProduct.Size = new System.Drawing.Size(122, 22);
            this.tbxProduct.TabIndex = 4;
            this.tbxProduct.TextChanged += new System.EventHandler(this.tbxProduct_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 413);
            this.Controls.Add(this.dgwProducts);
            this.Controls.Add(this.gbxProductName);
            this.Controls.Add(this.gbxCategory);
            this.Name = "Form1";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.gbxProductName.ResumeLayout(false);
            this.gbxProductName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.GroupBox gbxProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.TextBox tbxProduct;
    }
}

