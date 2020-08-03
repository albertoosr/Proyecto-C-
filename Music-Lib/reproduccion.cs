using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Lib
{
    public partial class reproduccion : Form
    {
        public reproduccion()
        {
            InitializeComponent();
        }

        private string ruta = "";

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnElegir_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                ruta = openFileDialog1.FileName;
                lblRuta.Text = ruta;

            }

            progressBar1.Minimum = 1;
            progressBar1.Maximum = 100;
            progressBar1.Step = 2;

            for (int x=0; x < 100; x++)
            {
                progressBar1.PerformStep();
            }


        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void btnReproducir_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = ruta;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void registrarCanciònToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registro frm2 = new registro();
            //frm2.MdiParent = this;
            frm2.TopMost = true;
            frm2.Show();
        }

        private void reproduccion_Load(object sender, EventArgs e)
        {

        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog()==DialogResult.OK)
            {
                btnElegir.BackColor = colorDialog1.Color;
                btnParar.BackColor = colorDialog1.Color;
                btnPausar.BackColor = colorDialog1.Color;
                btnReproducir.BackColor = colorDialog1.Color;
                panel1.BackColor = colorDialog1.Color;
            }
        }
    }
}
