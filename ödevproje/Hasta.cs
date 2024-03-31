using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödevproje
{
    public partial class Hasta : Form
    {
        public Hasta()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "insert ino HastaTbl values('" + HAdSoyadTb.Text + "','" + HTelefonTb.Text + "','" + AdresTb.Text + "','" + HDogumTarih.Value.Date + "','" + HCinsiyetCb.SelectedItem + "','" + AlerjiTb.Text + "')";
            Hastalar Hs = new Hastalar();
            try
            {

                Hs.HastaEkle(query);
                MessageBox.Show("HASTA EKLENDİ");

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void AlerjiTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void HDogumTarih_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
