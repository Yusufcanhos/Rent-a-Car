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
    public partial class AraçEkle : Form
    {
        public AraçEkle()
        {
            InitializeComponent();
        }

        private string baglantiCumlesi = @"Data Source=localhost;Initial Catalog = Arackiralama; Integrated Security = True";

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbxSeri.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir araç serisi seçiniz.");
                return;
            }

            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Insert Into Araclar values (@Plaka,@Marka,@Seri,@Model,@Renk,@Kilometre,@Yakit,@Ucret,@Durum)";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);

            komut.Parameters.AddWithValue("@Plaka", txtPlaka.Text);
            komut.Parameters.AddWithValue("@Marka", cbxMarka.SelectedItem);
            komut.Parameters.AddWithValue("@Seri", cbxSeri.SelectedItem);
            komut.Parameters.AddWithValue("@Model", txtModel.Text);
            komut.Parameters.AddWithValue("@Renk", txtRenk.Text);
            komut.Parameters.AddWithValue("@Kilometre", txtKm.Text);
            komut.Parameters.AddWithValue("@Yakit", cbxYakıt.SelectedItem);
            komut.Parameters.AddWithValue("@Ucret", txtUcret.Text);
            komut.Parameters.AddWithValue("@Durum", cbxDurum.SelectedItem);

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Araç Kaydı Başarılı");
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
    }
}
