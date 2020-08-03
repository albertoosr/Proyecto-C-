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
    public partial class registro : Form
    {
        public registro()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ListViewItem lista = new ListViewItem(txtNombre.Text);
            lista.SubItems.Add(txtNombre.Text);
            listView1.Items.Add(lista);

            txtNombre.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lista in listView1.SelectedItems)
            {
                lista.Remove();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }
    }
}
