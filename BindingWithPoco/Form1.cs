using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dapper;
using Equin.ApplicationFramework;

namespace BindingWithPoco
{
    public partial class Form1 : Form
    {
        private BindingList<Product> _products;
        private BindingListView<Product> _productsView;

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadData();
        }

        private void LoadData()
        {
            var connStr = Properties.Settings.Default.db;
            var conn = new SqlConnection(connStr);
            var sql = "SELECT * FROM Products;";
            _products = new BindingList<Product>(conn.Query<Product>(sql).ToList());
            _productsView = new BindingListView<Product>(_products);

            bindingSource1.DataSource = _productsView;
            dataGridView1.DataSource = bindingSource1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var inputLower = ((TextBox)sender).Text.ToLower();
            _productsView.ApplyFilter(p => p.ProductName.ToLower().Contains(inputLower));
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = e.RowIndex;
            if (row < 0)
            {
                return;
            }

            var prod = _productsView[row].Object;
            MessageBox.Show($"ProductID={prod.ProductID}, ProductName={prod.ProductName}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _products.Add(new Product
            {
                ProductID = 999,
                ProductName = "Added!"
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _products[0].ProductName = "MODIFIED!";
        }

    }
}
