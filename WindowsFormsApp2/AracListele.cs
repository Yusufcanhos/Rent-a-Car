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

namespace WindowsFormsApp2
{
    public partial class AracListele : Form
    {
        public AracListele()
        {
            InitializeComponent();
        }

        private string baglantiCumlesi = @"Data Source=localhost;Initial Catalog=Arackiralama;Integrated Security=True";
        private void txtAdres_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMarka.SelectedIndex == 0)
            {
                cbxSeri.Items.Clear();
                cbxSeri.Text = "";

                cbxSeri.Items.Add("A3");
                cbxSeri.Items.Add("A4");
                cbxSeri.Items.Add("A5");
                cbxSeri.Items.Add("A6");
                cbxSeri.Items.Add("A7");
                cbxSeri.Items.Add("RS6");
            }

            else if (cbxMarka.SelectedIndex == 1)
            {
                cbxSeri.Items.Clear();
                cbxSeri.Text = "";

                cbxSeri.Items.Add("320d");
                cbxSeri.Items.Add("520d");
                cbxSeri.Items.Add("M3");
                cbxSeri.Items.Add("116i");
                cbxSeri.Items.Add("430İ");
                cbxSeri.Items.Add("Z4");
            }

            else if (cbxMarka.SelectedIndex == 2)
            {
                cbxSeri.Items.Clear();
                cbxSeri.Text = "";

                cbxSeri.Items.Add("Albea");
                cbxSeri.Items.Add("Egea");
                cbxSeri.Items.Add("Linea");
                cbxSeri.Items.Add("Punto");
                cbxSeri.Items.Add("Egea Cross");
                cbxSeri.Items.Add("500X");
            }

            else if (cbxMarka.SelectedIndex == 3)
            {
                cbxSeri.Items.Clear();
                cbxSeri.Text = "";

                cbxSeri.Items.Add("Focus");
                cbxSeri.Items.Add("Fiesta");
                cbxSeri.Items.Add("Mondeo");
                cbxSeri.Items.Add("Kuga");
                cbxSeri.Items.Add("Puma");
                cbxSeri.Items.Add("Ranger");
            }

            else if (cbxMarka.SelectedIndex == 4)
            {
                cbxSeri.Items.Clear();
                cbxSeri.Text = "";

                cbxSeri.Items.Add("Civic");
                cbxSeri.Items.Add("City");
                cbxSeri.Items.Add("Jazz");
                cbxSeri.Items.Add("Accord");
                cbxSeri.Items.Add("CR-V");
                cbxSeri.Items.Add("HR-V");
            }

            else if (cbxMarka.SelectedIndex == 5)
            {
                cbxSeri.Items.Clear();
                cbxSeri.Text = "";

                cbxSeri.Items.Add("C200 D");
                cbxSeri.Items.Add("A180 D");
                cbxSeri.Items.Add("CLA200");
                cbxSeri.Items.Add("E240");
                cbxSeri.Items.Add("E220");
                cbxSeri.Items.Add("GLA");
            }


            else if (cbxMarka.SelectedIndex == 6)
            {
                cbxSeri.Items.Clear();
                cbxSeri.Text = "";

                cbxSeri.Items.Add("308");
                cbxSeri.Items.Add("406");
                cbxSeri.Items.Add("508");
                cbxSeri.Items.Add("607");
                cbxSeri.Items.Add("3008");
                cbxSeri.Items.Add("5008");

            }
            else if (cbxMarka.SelectedIndex == 7)
            {
                cbxSeri.Items.Clear();
                cbxSeri.Text = "";

                cbxSeri.Items.Add("Clio");
                cbxSeri.Items.Add("Fluence");
                cbxSeri.Items.Add("Megane");
                cbxSeri.Items.Add("Symbol");
                cbxSeri.Items.Add("Kadjar");
                cbxSeri.Items.Add("Captur");
            }

            else if (cbxMarka.SelectedIndex == 8)
            {
                cbxSeri.Items.Clear();
                cbxSeri.Text = "";

                cbxSeri.Items.Add("Leon");
                cbxSeri.Items.Add("Arona");
                cbxSeri.Items.Add("Ateca");
                cbxSeri.Items.Add("Cordoba");
                cbxSeri.Items.Add("Altea");
                cbxSeri.Items.Add("Toledo");
            }

            else if (cbxMarka.SelectedIndex == 9)
            {
                cbxSeri.Items.Clear();
                cbxSeri.Text = "";

                cbxSeri.Items.Add("Polo");
                cbxSeri.Items.Add("Golf");
                cbxSeri.Items.Add("Passat");
                cbxSeri.Items.Add("Jetta");
                cbxSeri.Items.Add("T-Roc");
                cbxSeri.Items.Add("Tiguan");
            }
        }

        public void Arac_Listele()
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Select * From Araclar";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void Arac_Listele_Load(object sender, EventArgs e)
        {
            Arac_Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Update Araclar set Marka = @Marka, Seri = @Seri, Model = @Model, Renk = @Renk, Kilometre = @Km, Yakit = @Yakit, Kira_Ücreti = @Ucret, Durumu = @Durum Where Plaka = @Plaka";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            komut.Parameters.AddWithValue("@Plaka", txtPlaka.Text);
            komut.Parameters.AddWithValue("@Marka", cbxMarka.SelectedItem);
            komut.Parameters.AddWithValue("@Seri", cbxSeri.SelectedItem);
            komut.Parameters.AddWithValue("@Model", txtModel.Text);
            komut.Parameters.AddWithValue("@Renk", txtRenk.Text);
            komut.Parameters.AddWithValue("@Km", txtKm.Text);
            komut.Parameters.AddWithValue("@Yakit", cbxYakıt.SelectedItem) ;
            komut.Parameters.AddWithValue("@Ucret", txtUcret.Text) ;
            komut.Parameters.AddWithValue("@Durum", cbxDurum.SelectedItem) ;

            komut.ExecuteNonQuery();
            baglanti.Close();
            Arac_Listele();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {    
            string Plaka = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete From Araclar Where Plaka =@Plaka",baglanti);
            komut.Parameters.AddWithValue("@Plaka", Plaka);

          
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Araç Başarıyla Silindi.");
            Arac_Listele();
        }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPlaka.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cbxMarka.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cbxSeri.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtModel.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtRenk.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtKm.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            cbxYakıt.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtUcret.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            cbxDurum.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
        }

        private void AracListele_Load(object sender, EventArgs e)
        {
            //Bu kod satırı 'arackiralamaDataSet.Araclar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.araclarTableAdapter.Fill(this.arackiralamaDataSet.Araclar);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
