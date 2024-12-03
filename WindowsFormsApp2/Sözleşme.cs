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
    public partial class Sözleşme : Form
    {
        public Sözleşme()
        {
            InitializeComponent();
        }
        private string baglantiCumlesi = @"Data Source=localhost;Initial Catalog=Arackiralama;Integrated Security=True";

        public void Arac_Listele()
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutCumlesi = "Select * From Araclar  where Durumu = 'Boş'";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                cbxAraç.Items.Add(read["Plaka"]);
            }
        }
        public void Sozlesme_Listele()
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Select * From Sozlesme";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }


        private void Sözleşme_Load(object sender, EventArgs e)
        {
            Arac_Listele();
            Sozlesme_Listele();
        }

        private void cbxAraç_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Select * From Araclar where Plaka like '" + cbxAraç.SelectedItem + "'";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtMarka.Text = read["Marka"].ToString();
                txtSeri.Text = read["Seri"].ToString();
                txtModel.Text = read["Model"].ToString();
                txtRenk.Text = read["Renk"].ToString();
            }
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            TimeSpan gunfarki = DateTime.Parse(datetimeDonus.Text) - DateTime.Parse(datetimeCikis.Text);
            int gunhesap = gunfarki.Days;
            txtGun.Text = gunhesap.ToString();
            txtTutar.Text = (gunhesap * int.Parse(txtKiraUcret.Text)).ToString();
        }

        private void cbxKiraSekil_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Select Kira_Ücreti From Araclar";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (cbxKiraSekil.SelectedIndex == 0)
                {
                    txtKiraUcret.Text = (int.Parse(read["Kira_Ücreti"].ToString()) * 1).ToString();
                }
                else if (cbxKiraSekil.SelectedIndex == 1)
                {
                    txtKiraUcret.Text = (int.Parse(read["Kira_Ücreti"].ToString()) * 0.80).ToString();
                }
                else if (cbxKiraSekil.SelectedIndex == 2)
                {
                    txtKiraUcret.Text = (int.Parse(read["Kira_Ücreti"].ToString()) * 0.50).ToString();
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Insert Into Sozlesme Values (@tcno,@adsoyad,@Telefon,@ehliyetno,@ehliyettarih,@Plaka,@Marka,@Seri,@model,@renk,@kirasekli,@kiraucreti,@kiralanangunsayisi,@tutar,@cikistarihi,@donustarihi)";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            komut.Parameters.AddWithValue("@tcno", txtTc.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@Telefon", txtTel.Text);
            komut.Parameters.AddWithValue("@ehliyetno", txtEhliyetNo.Text);
            komut.Parameters.AddWithValue("@ehliyettarih", txtEhliyetTarih.Text);
            komut.Parameters.AddWithValue("@Plaka", cbxAraç.Text);
            komut.Parameters.AddWithValue("@Marka", txtMarka.Text);
            komut.Parameters.AddWithValue("@Seri", txtSeri.Text);
            komut.Parameters.AddWithValue("@model", txtModel.Text);
            komut.Parameters.AddWithValue("@renk", txtRenk.Text);
            komut.Parameters.AddWithValue("@kirasekli", cbxKiraSekil.Text);
            komut.Parameters.AddWithValue("@kiraucreti", txtKiraUcret.Text);
            komut.Parameters.AddWithValue("@kiralanangunsayisi", txtGun.Text);
            komut.Parameters.AddWithValue("@tutar", txtTutar.Text);
            komut.Parameters.AddWithValue("@cikistarihi", datetimeCikis.Text);
            komut.Parameters.AddWithValue("@donustarihi", datetimeDonus.Text);

            string komutCumlesiUp = "Update Araclar set Durumu = 'Dolu' where Plaka = '" + cbxAraç.SelectedItem + "'";
            SqlCommand komutUp = new SqlCommand(komutCumlesiUp, baglanti);

            komut.ExecuteNonQuery();
            komutUp.ExecuteNonQuery();
            baglanti.Close();
            Sozlesme_Listele();
            Arac_Listele();
            MessageBox.Show("Kayıt Başarılı");
        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {

            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Select * From Musteriler where Tc_No like '" + txtTcAra.Text + "'";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtTc.Text = read["Tc_No"].ToString();
                txtAdSoyad.Text = read["Ad_Soyad"].ToString();
                txtTel.Text = read["Telefon_Numarası"].ToString();
            }
        }

        private void btnAracTeslim_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            DateTime Bugün = DateTime.Parse(satir.Cells["Donus_Tarih"].Value.ToString());

            int ucret = int.Parse(satir.Cells["Kira_Ücreti"].Value.ToString());
            int tutar = int.Parse(satir.Cells["Tutar"].Value.ToString());
            DateTime cikis = DateTime.Parse(satir.Cells["Cikis_Tarih"].Value.ToString());
            TimeSpan gun = cikis - Bugün;
            int gunu = gun.Days;
            int ToplamTutar = gunu * ucret;

            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Delete from Sozlesme where Plaka = @Plaka";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            komut.Parameters.AddWithValue("@Plaka", satir.Cells["Plaka"].Value.ToString());
            komut.ExecuteNonQuery();

            string komutCumlesiUpd = "Update Araclar set Durumu ='Bos' where Plaka = @Plaka";
            SqlCommand komutUpd = new SqlCommand(komutCumlesiUpd, baglanti);
            komutUpd.Parameters.AddWithValue("@Plaka", satir.Cells["Plaka"].Value.ToString());
            komutUpd.ExecuteNonQuery();

            string komutCumlesiSatis = "Insert Into satis Values (@tcno, @adsoyad, @Telefon, @Plaka, @gun, @kiraSekli, @kiraucret, @tutar, @cikistarih, @donustarih)";
            SqlCommand komutSatis = new SqlCommand(komutCumlesiSatis, baglanti);

            komutSatis.Parameters.AddWithValue("@tcno", satir.Cells["Tc_No"].Value.ToString());
            komutSatis.Parameters.AddWithValue("@adsoyad", satir.Cells["Ad_Soyad"].Value.ToString());
            komutSatis.Parameters.AddWithValue("@Telefon", satir.Cells["Telefon"].Value.ToString());
            komutSatis.Parameters.AddWithValue("@Plaka", satir.Cells["Plaka"].Value.ToString());
            komutSatis.Parameters.AddWithValue("@gun", gunu);
            komutSatis.Parameters.AddWithValue("@kiraSekli", satir.Cells["Kira_Sekli"].Value.ToString());
            komutSatis.Parameters.AddWithValue("@kiraucret", ucret);
            komutSatis.Parameters.AddWithValue("@tutar", ToplamTutar);
            komutSatis.Parameters.AddWithValue("@cikistarih", cikis);
            komutSatis.Parameters.AddWithValue("@donustarih", DateTime.Parse(satir.Cells["Donus_Tarih"].Value.ToString()));

            komutSatis.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Araç Teslim Edildi");
        }





    }

}
