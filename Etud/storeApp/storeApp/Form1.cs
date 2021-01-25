using storeApp.Data;
using storeApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace storeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        void getCategories()
        {
            var db = new miniShopDbContext();
            dataGridViewCategories.DataSource = db.Categories.ToList();
            var category = db.Categories.ToList()[0];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Category category = new Category { Id = 1, Name = "Kırtasiye ofis malzemeleri" };
            Product product = new Product { Id = 9, Name = "Fabook", Description = "Çiçekli defter" };

            getCategories();
            getProducts();
        }

        miniShopDbContext db = new miniShopDbContext();
        private void getProducts()
        {
          
            comboBoxProducts.DataSource = db.Products.Select(p => new { p.Id, p.Name }).ToList();
            comboBoxProducts.DisplayMember = "Name";
            comboBoxProducts.ValueMember = "Id";


        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
         

            Category newCategory = new Category();
            newCategory.Name = textBoxCategoryName.Text;
            newCategory.Description = textBoxCategoryDesc.Text;

            db.Categories.Add(newCategory);
            int affectedRow = db.SaveChanges();
            if (affectedRow > 0)
            {
                MessageBox.Show("başarılı");
                getCategories();
            }
            else
            {
                MessageBox.Show("olmadı");

            }

        }

        private void comboBoxProducts_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
            var selectedProductId = (int)comboBoxProducts.SelectedValue;
            var product = db.Products.Find(selectedProductId);
            MessageBox.Show($"{product.Name} isimli ürünün fiyatı {product.Price} ve puanı {product.Rating}");
        }
    }
}
