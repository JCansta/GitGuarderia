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
using MySql.Data.MySqlClient;

namespace Guarderia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(panel1.Width == 247)
            {
                panel1.Width = 67;
                logo.Width = 61;
                logo.Height = 61;
                
            }
            else
            {
                panel1.Width = 247;
                logo.Width = 241;
                logo.Height = 147;
                
            }
        }

        private void Panelcontenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void AbrirFormInPanel (object formhijo)
        {
            if (this.Panelcontenedor.Controls.Count>0)
            
                this.Panelcontenedor.Controls.RemoveAt(0);
                Form fh = formhijo as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.Panelcontenedor.Controls.Add(fh);
                this.Panelcontenedor.Tag = fh;
                fh.Show();
            
        }
        
        private void ingresobtn_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new ingreso());
        }

        private void registrobtn_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new registros());
        }

        private void salidabtn_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Salida());
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new filtros());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new actualizar());
        }

        private void cerrarbtn_MouseHover(object sender, EventArgs e)
        {

        }

        private void buscarbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            button1.Visible = false;
            button2.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            button1.Visible = true;
            button2.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
