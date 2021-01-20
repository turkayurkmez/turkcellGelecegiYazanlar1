using introEFCore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using introEFCore.Data;
using introEFCore.Services;

namespace introEFCore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Director director = new Director();
            //director.Name = "Nuri Bilge";
            //director.LastName = "Ceylan";
            //Movie ahlat = new Movie();
            //ahlat.Name = "Ahlat Ağacı";

            //director.Movies.Add(ahlat);
            getDirectorsToSelect();
            
        }

        private void getDirectorsToSelect()
        {
            comboBoxYonetmenler.DataSource = dbContext.Directors.ToList();
            comboBoxYonetmenler.DisplayMember = "Name";
            comboBoxYonetmenler.ValueMember = "Id";
        }

        TurkcellDbContext dbContext = new TurkcellDbContext();
        DirectorBusiness directorBusiness = new DirectorBusiness();
        private void buttonGetir_Click(object sender, EventArgs e)
        {
            getDirectors();
        }

        private void getDirectors()
        {

            dataGridView1.DataSource = directorBusiness.GetDirectors();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Director director = new Director();
            director.Name = textBoxYonetmenAd.Text;
            director.LastName = textBoxYonetmenSoyad.Text;
            director.Info = textBoxYonetmenBiyo.Text;

            directorBusiness.Add(director);
            getDirectors();

        }

        Director selectedDirector = null;
        private void buttonGuncelle_Click(object sender, EventArgs e)
        {

            selectedDirector.Name = textBoxYonetmenAd.Text;
            selectedDirector.LastName = textBoxYonetmenSoyad.Text;
            selectedDirector.Info = textBoxYonetmenBiyo.Text;
            //dbContext.Entry(selectedDirector).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            //var result = dbContext.SaveChanges();
            directorBusiness.Edit(selectedDirector);
            getDirectors();
        }

        private void comboBoxYonetmenler_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int selectedDirectorId = (int)comboBoxYonetmenler.SelectedValue;
            //var director = dbContext.Directors.Where(y => y.Id == selectedDirectorId)
            //                                  .FirstOrDefault();

            var director = directorBusiness.GetDirectorById(selectedDirectorId);

            selectedDirector = director;

            textBoxYonetmenAd.Text = director.Name;
            textBoxYonetmenSoyad.Text = director.LastName;
            textBoxYonetmenBiyo.Text = director.Info;

            buttonGuncelle.Enabled = true;
            buttonSil.Enabled = true;

        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            //dbContext.Directors.Remove(selectedDirector);
            //dbContext.SaveChanges();
            directorBusiness.Edit(selectedDirector);
            getDirectors();
        }
    }
}
