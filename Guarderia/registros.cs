using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Guarderia
{
    public partial class registros : Form
    {
        
        MySqlConnection conexion;
        MySqlCommand cmd;
        MySqlDataAdapter da;


        DataView dv;
        public registros()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buscar_ced_CheckedChanged(object sender, EventArgs e)
        {
            buscar_id.Checked = false;
        }

        private void buscar_id_CheckedChanged(object sender, EventArgs e)
        {
            buscar_ced.Checked = false;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (buscar_ced.Checked==true)
            {
                try
                {
                    dv.RowFilter = "Documento=" + filtrotext.Text + "";
                }
                catch (Exception)
                {

                    MessageBox.Show("Documento no encontrado");
                }
                
            }
            if (buscar_id.Checked==true)
            {
                try
                {
                    dv.RowFilter = "ID='" + filtrotext.Text + "'";
                }
                catch (Exception)
                {
                    MessageBox.Show("ID no encontrado");
                }
            }
            

            
        }

        private void buscar_Load(object sender, EventArgs e)
        {
            conexion = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=guarderia");
            cmd = new MySqlCommand("SELECT i.id_regist ID, m.Nom_masc Mascota, d.Nombre Propietario, d.num_doc Documento, s.nom_serv Servicio, i.fecha_in Ingreso, i.fecha_out Salida  " +
                "FROM ingreso i, servicios s, dueno d, mascota m " +
                "where i.cedu_due = d.num_doc and i.id_serv = s.id_serv and m.ID_masco = i.id_masco ", conexion);
            da = new MySqlDataAdapter(cmd);

            DataTable tabla = new DataTable();
            da.Fill(tabla);



            dv= new DataView(tabla);


            dgvBusqueda.DataSource = dv;
            dgvBusqueda.Columns["Propietario"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvBusqueda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            
        }

        private void dgvBusqueda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void limpiarbtn_Click(object sender, EventArgs e)
        {
            dv.RowFilter = "";
        }

        private void filtrotext_Enter(object sender, EventArgs e)
        {
            if (filtrotext.Text== "🔎")
            {
                filtrotext.Text = "";
                filtrotext.ForeColor = Color.Black;
            }
        }

       

        private void filtrotext_Leave(object sender, EventArgs e)
        {
            if (filtrotext.Text == "")
            {
                filtrotext.Text = "🔎";
                filtrotext.ForeColor = Color.Orange;
            }
        }
        private void filtrotext_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
