
namespace introForm
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
            this.components = new System.ComponentModel.Container();
            this.textBoxKelime = new System.Windows.Forms.TextBox();
            this.buttonTikla = new System.Windows.Forms.Button();
            this.buttonArttır = new System.Windows.Forms.Button();
            this.labelSayac = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelSaat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxKelime
            // 
            this.textBoxKelime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKelime.Location = new System.Drawing.Point(164, 220);
            this.textBoxKelime.Name = "textBoxKelime";
            this.textBoxKelime.Size = new System.Drawing.Size(210, 31);
            this.textBoxKelime.TabIndex = 0;
            // 
            // buttonTikla
            // 
            this.buttonTikla.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTikla.Location = new System.Drawing.Point(223, 260);
            this.buttonTikla.Name = "buttonTikla";
            this.buttonTikla.Size = new System.Drawing.Size(151, 43);
            this.buttonTikla.TabIndex = 1;
            this.buttonTikla.Text = "Tıkla";
            this.buttonTikla.UseVisualStyleBackColor = true;
            this.buttonTikla.Click += new System.EventHandler(this.buttonTikla_Click);
            // 
            // buttonArttır
            // 
            this.buttonArttır.Location = new System.Drawing.Point(164, 95);
            this.buttonArttır.Name = "buttonArttır";
            this.buttonArttır.Size = new System.Drawing.Size(75, 23);
            this.buttonArttır.TabIndex = 2;
            this.buttonArttır.Text = "Arttır";
            this.buttonArttır.UseVisualStyleBackColor = true;
            this.buttonArttır.Click += new System.EventHandler(this.buttonArttır_Click);
            // 
            // labelSayac
            // 
            this.labelSayac.AutoSize = true;
            this.labelSayac.Location = new System.Drawing.Point(190, 64);
            this.labelSayac.Name = "labelSayac";
            this.labelSayac.Size = new System.Drawing.Size(13, 13);
            this.labelSayac.TabIndex = 3;
            this.labelSayac.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelSaat
            // 
            this.labelSaat.AutoSize = true;
            this.labelSaat.Location = new System.Drawing.Point(190, 9);
            this.labelSaat.Name = "labelSaat";
            this.labelSaat.Size = new System.Drawing.Size(35, 13);
            this.labelSaat.TabIndex = 4;
            this.labelSaat.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 320);
            this.Controls.Add(this.labelSaat);
            this.Controls.Add(this.labelSayac);
            this.Controls.Add(this.buttonArttır);
            this.Controls.Add(this.buttonTikla);
            this.Controls.Add(this.textBoxKelime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxKelime;
        private System.Windows.Forms.Button buttonTikla;
        private System.Windows.Forms.Button buttonArttır;
        private System.Windows.Forms.Label labelSayac;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelSaat;
    }
}

