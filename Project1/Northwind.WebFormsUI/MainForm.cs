using Northwind.Bussines.Concrete;
using Northwind.DataAccess.Concrete.EntityFramework;
using System;
using System.Windows.Forms;
using Northwind.Bussines.Abstract;

namespace Northwind.WebFormsUI
{
    public partial class MainForm : Form
    {
        
        private IProductService _productService;
        public MainForm()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgwProducts.DataSource = _productService.GettAll();
        }
    }
}
