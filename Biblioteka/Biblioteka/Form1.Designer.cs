
namespace Biblioteka
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dugme_dodaj = new System.Windows.Forms.Button();
            this.dugme_promeni = new System.Windows.Forms.Button();
            this.dugme_obrisi = new System.Windows.Forms.Button();
            this.vrati_na_pocetak = new System.Windows.Forms.Button();
            this.korak_nazad = new System.Windows.Forms.Button();
            this.korak_napred = new System.Windows.Forms.Button();
            this.napred = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(275, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(275, 117);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(277, 157);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(146, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(275, 198);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(148, 20);
            this.textBox4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "naslov";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "autor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "br_strana";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "povez";
            // 
            // dugme_dodaj
            // 
            this.dugme_dodaj.Location = new System.Drawing.Point(139, 293);
            this.dugme_dodaj.Name = "dugme_dodaj";
            this.dugme_dodaj.Size = new System.Drawing.Size(75, 23);
            this.dugme_dodaj.TabIndex = 8;
            this.dugme_dodaj.Text = "Dodaj";
            this.dugme_dodaj.UseVisualStyleBackColor = true;
            this.dugme_dodaj.Click += new System.EventHandler(this.button1_Click);
            // 
            // dugme_promeni
            // 
            this.dugme_promeni.Location = new System.Drawing.Point(310, 293);
            this.dugme_promeni.Name = "dugme_promeni";
            this.dugme_promeni.Size = new System.Drawing.Size(75, 23);
            this.dugme_promeni.TabIndex = 9;
            this.dugme_promeni.Text = "Promeni";
            this.dugme_promeni.UseVisualStyleBackColor = true;
            this.dugme_promeni.Click += new System.EventHandler(this.dugme_promeni_Click);
            // 
            // dugme_obrisi
            // 
            this.dugme_obrisi.Location = new System.Drawing.Point(472, 293);
            this.dugme_obrisi.Name = "dugme_obrisi";
            this.dugme_obrisi.Size = new System.Drawing.Size(75, 23);
            this.dugme_obrisi.TabIndex = 10;
            this.dugme_obrisi.Text = "Obrisi";
            this.dugme_obrisi.UseVisualStyleBackColor = true;
            this.dugme_obrisi.Click += new System.EventHandler(this.dugme_obrisi_Click);
            // 
            // vrati_na_pocetak
            // 
            this.vrati_na_pocetak.Location = new System.Drawing.Point(110, 357);
            this.vrati_na_pocetak.Name = "vrati_na_pocetak";
            this.vrati_na_pocetak.Size = new System.Drawing.Size(75, 23);
            this.vrati_na_pocetak.TabIndex = 11;
            this.vrati_na_pocetak.Text = "<<<";
            this.vrati_na_pocetak.UseVisualStyleBackColor = true;
            this.vrati_na_pocetak.Click += new System.EventHandler(this.vrati_na_pocetak_Click);
            // 
            // korak_nazad
            // 
            this.korak_nazad.Location = new System.Drawing.Point(231, 357);
            this.korak_nazad.Name = "korak_nazad";
            this.korak_nazad.Size = new System.Drawing.Size(75, 23);
            this.korak_nazad.TabIndex = 12;
            this.korak_nazad.Text = "<";
            this.korak_nazad.UseVisualStyleBackColor = true;
            this.korak_nazad.Click += new System.EventHandler(this.korak_nazad_Click);
            // 
            // korak_napred
            // 
            this.korak_napred.Location = new System.Drawing.Point(370, 357);
            this.korak_napred.Name = "korak_napred";
            this.korak_napred.Size = new System.Drawing.Size(75, 23);
            this.korak_napred.TabIndex = 13;
            this.korak_napred.Text = ">";
            this.korak_napred.UseVisualStyleBackColor = true;
            this.korak_napred.Click += new System.EventHandler(this.korak_napred_Click);
            // 
            // napred
            // 
            this.napred.Location = new System.Drawing.Point(511, 357);
            this.napred.Name = "napred";
            this.napred.Size = new System.Drawing.Size(75, 23);
            this.napred.TabIndex = 14;
            this.napred.Text = ">>>";
            this.napred.UseVisualStyleBackColor = true;
            this.napred.Click += new System.EventHandler(this.napred_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.napred);
            this.Controls.Add(this.korak_napred);
            this.Controls.Add(this.korak_nazad);
            this.Controls.Add(this.vrati_na_pocetak);
            this.Controls.Add(this.dugme_obrisi);
            this.Controls.Add(this.dugme_promeni);
            this.Controls.Add(this.dugme_dodaj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button dugme_dodaj;
        private System.Windows.Forms.Button dugme_promeni;
        private System.Windows.Forms.Button dugme_obrisi;
        private System.Windows.Forms.Button vrati_na_pocetak;
        private System.Windows.Forms.Button korak_nazad;
        private System.Windows.Forms.Button korak_napred;
        private System.Windows.Forms.Button napred;
    }
}

