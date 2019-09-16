using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Guarderia
{
    public partial class actualizar : Form
    {
        public static string valor;
        public actualizar()
        {
            InitializeComponent();
        }
        private void AbrirFormInPanel(object formhijo)
        {
            if (this.panelview.Controls.Count > 0)

                this.panelview.Controls.RemoveAt(0);
                Form fh = formhijo as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.panelview.Controls.Add(fh);
                this.panelview.Tag = fh;
                fh.Show();

        }
       
        private void buscarbtn_Click(object sender, EventArgs e)
        {
            valor = actualizardato.Text;

            if (check_doc.Checked==true)
            {
                AbrirFormInPanel(new actualizar_dueno());
            }
            if (check_id.Checked == true)
            {
                AbrirFormInPanel(new actualizar_id());
            }
            

            
            

            actualizar_dueno frm2 = new actualizar_dueno();
            actualizar_id frm3 = new actualizar_id();

        }

        private void actualizardato_Enter(object sender, EventArgs e)
        {
            if (actualizardato.Text == "🔎")
            {
                actualizardato.Text = "";
                actualizardato.ForeColor = Color.Black;
            }
        }

        private void actualizardato_Leave(object sender, EventArgs e)
        {
            if (actualizardato.Text == "")
            {
                actualizardato.Text = "🔎";
                actualizardato.ForeColor = Color.Orange;
            }
        }

        private void check_doc_CheckedChanged(object sender, EventArgs e)
        {
            if (check_id.Checked==true)
            {
                check_id.Checked = false;
            }
        }

        private void actualizar_Load(object sender, EventArgs e)
        {

        }

        private void check_id_CheckedChanged(object sender, EventArgs e)
        {
            if (check_doc.Checked==true)
            {
                check_doc.Checked = false;
            }
        }
    }
}
