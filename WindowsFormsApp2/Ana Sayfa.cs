using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           MusteriEkle musteriEklefrm = new MusteriEkle();
            musteriEklefrm.Show();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AraçEkle araceklefrm = new AraçEkle ();
            araceklefrm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMusteriListele_Click(object sender, EventArgs e)
        {
            MusteriListele musterilistelefrm = new MusteriListele();    
            musterilistelefrm.Show();
        }

        private void btnAracListele_Click(object sender, EventArgs e)
        {
            AracListele araclistelefrm = new AracListele(); 
            araclistelefrm.Show();
        }

        private void btnSozlesme_Click(object sender, EventArgs e)
        {
            Sözleşme sozlesmefrm = new Sözleşme();
            sozlesmefrm.Show();
        }

        private void btnSatıslar_Click(object sender, EventArgs e)
        {
            Satis satisfrm = new Satis();  
            satisfrm.Show();
        }
    }
}
