
namespace introEFCore
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonGetir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxYonetmenAd = new System.Windows.Forms.TextBox();
            this.textBoxYonetmenSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxYonetmenBiyo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxYonetmenler = new System.Windows.Forms.ComboBox();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.buttonGetir);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(983, 543);
            this.splitContainer1.SplitterDistance = 327;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(648, 539);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonGetir
            // 
            this.buttonGetir.Location = new System.Drawing.Point(41, 19);
            this.buttonGetir.Name = "buttonGetir";
            this.buttonGetir.Size = new System.Drawing.Size(132, 59);
            this.buttonGetir.TabIndex = 1;
            this.buttonGetir.Text = "Yönetmenleri Getir";
            this.buttonGetir.UseVisualStyleBackColor = true;
            this.buttonGetir.Click += new System.EventHandler(this.buttonGetir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSil);
            this.groupBox1.Controls.Add(this.buttonGuncelle);
            this.groupBox1.Controls.Add(this.comboBoxYonetmenler);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBoxYonetmenBiyo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxYonetmenSoyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxYonetmenAd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 413);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yönetmen Ekle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yönetmen Adı";
            // 
            // textBoxYonetmenAd
            // 
            this.textBoxYonetmenAd.Location = new System.Drawing.Point(15, 120);
            this.textBoxYonetmenAd.Name = "textBoxYonetmenAd";
            this.textBoxYonetmenAd.Size = new System.Drawing.Size(137, 20);
            this.textBoxYonetmenAd.TabIndex = 1;
            // 
            // textBoxYonetmenSoyad
            // 
            this.textBoxYonetmenSoyad.Location = new System.Drawing.Point(15, 170);
            this.textBoxYonetmenSoyad.Name = "textBoxYonetmenSoyad";
            this.textBoxYonetmenSoyad.Size = new System.Drawing.Size(137, 20);
            this.textBoxYonetmenSoyad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yönetmen Soyadı";
            // 
            // textBoxYonetmenBiyo
            // 
            this.textBoxYonetmenBiyo.Location = new System.Drawing.Point(14, 222);
            this.textBoxYonetmenBiyo.Multiline = true;
            this.textBoxYonetmenBiyo.Name = "textBoxYonetmenBiyo";
            this.textBoxYonetmenBiyo.Size = new System.Drawing.Size(251, 95);
            this.textBoxYonetmenBiyo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yönetmen Biyo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Yönetmen Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxYonetmenler
            // 
            this.comboBoxYonetmenler.FormattingEnabled = true;
            this.comboBoxYonetmenler.Location = new System.Drawing.Point(15, 39);
            this.comboBoxYonetmenler.Name = "comboBoxYonetmenler";
            this.comboBoxYonetmenler.Size = new System.Drawing.Size(250, 21);
            this.comboBoxYonetmenler.TabIndex = 7;
            this.comboBoxYonetmenler.SelectionChangeCommitted += new System.EventHandler(this.comboBoxYonetmenler_SelectionChangeCommitted);
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.Enabled = false;
            this.buttonGuncelle.Location = new System.Drawing.Point(40, 352);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(193, 23);
            this.buttonGuncelle.TabIndex = 8;
            this.buttonGuncelle.Text = "Yönetmeni Güncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = true;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Enabled = false;
            this.buttonSil.Location = new System.Drawing.Point(40, 381);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(193, 23);
            this.buttonSil.TabIndex = 9;
            this.buttonSil.Text = "Yönetmeni Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 543);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonGetir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxYonetmenBiyo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxYonetmenSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxYonetmenAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.ComboBox comboBoxYonetmenler;
        private System.Windows.Forms.Button buttonSil;
    }
}

