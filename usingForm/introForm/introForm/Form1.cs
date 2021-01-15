using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace introForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTikla_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBoxKelime.Text);

        }

        int sayac = 0;

        private void buttonArttır_Click(object sender, EventArgs e)
        {
            sayac++;
            labelSayac.Text = sayac.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelSaat.Text = DateTime.Now.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
