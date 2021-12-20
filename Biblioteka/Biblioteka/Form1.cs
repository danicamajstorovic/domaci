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

namespace Biblioteka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int red = 0;
        string CS = "Data source=DESKTOP-QLJ6URB\\SQLEXPRESS; Initial catalog=Biblioteka; Integrated security=True";
        DataTable Knjiga = new DataTable();
        private void Osvezi()
        {
            textBox1.Text = Knjiga.Rows[red]["naziv_knjige"].ToString();
            textBox2.Text = Knjiga.Rows[red]["autor"].ToString();
            textBox3.Text = Knjiga.Rows[red]["br_strana"].ToString();
            textBox4.Text = Knjiga.Rows[red]["povez"].ToString();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(CS);
            veza.Open();
             

            SqlCommand naredba = new SqlCommand("INSERT INTO Knjiga (naslov, autor, br_strana, povez) VALUES(" + textBox1.Text + ", '" + textBox2.Text + "', '" + textBox3.Text + "', " + textBox4.Text + ")", veza);
            naredba.ExecuteNonQuery();
            veza.Close();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Knjiga", veza);
            Knjiga.Clear();
            adapter.Fill(Knjiga);
            red = 0;
            Osvezi();
            korak_nazad.Enabled = false;
            vrati_na_pocetak.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            SqlConnection veza = new SqlConnection(CS);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Knjiga", veza);
            adapter.Fill(Knjiga);
            Osvezi();
            korak_nazad.Enabled = false;
            vrati_na_pocetak.Enabled = false;

        }

        private void korak_napred_Click(object sender, EventArgs e)
        {
            if (red != Knjiga.Rows.Count - 1)
            {
                red++;
                Osvezi();
                if (red == Knjiga.Rows.Count - 1)
                {
                    korak_napred.Enabled = false;
                    napred.Enabled = false;
                }
                korak_nazad.Enabled = true;
                vrati_na_pocetak.Enabled = true;
            }
            else
            {
                korak_napred.Enabled = false;
            }

        }

        private void korak_nazad_Click(object sender, EventArgs e)
        {
            if (red != 0)
            {
                red--;
                Osvezi();
                if (red == 0)
                {
                    korak_nazad.Enabled = false;
                    vrati_na_pocetak.Enabled = false;
                }
                korak_napred.Enabled = true;
                napred.Enabled = true;
            }
            else
            {
                korak_nazad.Enabled = false;
            }
        }

        private void napred_Click(object sender, EventArgs e)
        {
            red = Knjiga.Rows.Count - 1;
            Osvezi();
            korak_napred.Enabled = false;
            napred.Enabled = false;
            korak_nazad.Enabled = true;
            vrati_na_pocetak.Enabled = true;

        }

        private void vrati_na_pocetak_Click(object sender, EventArgs e)
        {
            red = 0;
            Osvezi();
            korak_nazad.Enabled = false;
            vrati_na_pocetak.Enabled = false;
            korak_napred.Enabled = true;
            napred.Enabled = true;

        }

        private void dugme_obrisi_Click(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(CS);
            veza.Open();
            SqlCommand naredba = new SqlCommand("DELETE FROM Knjiga WHERE naslov = " + textBox1.Text, veza);
            naredba.ExecuteNonQuery();
            veza.Close();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Knjiga", veza);
            Knjiga.Clear();
            adapter.Fill(Knjiga);
            red = 0;
            Osvezi();
            korak_nazad.Enabled = false;
            vrati_na_pocetak.Enabled = false;

        }

        private void dugme_promeni_Click(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(CS);
            veza.Open();

            SqlCommand naredba = new SqlCommand("UPDATE Knjiga SET naslov = " + textBox1.Text + ", autor = '" + textBox2.Text + "', br_strana = '" + textBox3.Text + "', povez = " + textBox4.Text + " WHERE naslov = " + Knjiga.Rows[red]["naslov"].ToString(), veza);
            naredba.ExecuteNonQuery();
            veza.Close();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Knjiga", veza);
            Knjiga.Clear();
            adapter.Fill(Knjiga);
            red = 0;
            Osvezi();
            korak_nazad.Enabled = false;
            vrati_na_pocetak.Enabled = false;


        }
    }
}
