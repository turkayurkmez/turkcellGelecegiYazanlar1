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

        private void Form1_Load(object sender, EventArgs e)
        {
            Category category = new Category { Id = 1, Name = "Kırtasiye ofis malzemeleri" };
            Product product = new Product { Id = 9, Name = "Fabook", Description = "Çiçekli defter" };
        }
    }
}
