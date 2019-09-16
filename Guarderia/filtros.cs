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
    public partial class filtros : Form
    {
        MySqlConnection conexion;
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataView dv;

        public filtros()
        {
            InitializeComponent();
        }
        private void buscar_Load(object sender, EventArgs e)
        {
            conexion = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=guarderia");
            cmd = new MySqlCommand("SELECT i.id_regist ID, m.Nom_masc Mascota, d.Nombre Propietario, d.num_doc Documento, s.nom_serv Servicio, i.fecha_in Ingreso, " +
                "i.fecha_out Salida FROM ingreso i, servicios s, dueno d, mascota m " +
                "where i.cedu_due = d.num_doc and i.id_serv = s.id_serv and m.ID_masco = i.id_masco ", conexion);
            da = new MySqlDataAdapter(cmd);

            DataTable tabla = new DataTable();
            da.Fill(tabla);



            dv = new DataView(tabla);


            dgvfiltros.DataSource = dv;
            dgvfiltros.Columns["Propietario"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvfiltros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void filtromasregis_Click(object sender, EventArgs e)
        {
            conexion = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=guarderia");
            cmd = new MySqlCommand("SELECT count(ID) Cantidad, Cedula, Nombre FROM(SELECT i.id_regist ID, i.cedu_due Cedula, d.nombre Nombre FROM ingreso i, " +
                "dueno d WHERE d.num_doc=i.cedu_due) tabla1 Group by Cedula  ", conexion);
            da = new MySqlDataAdapter(cmd);

            DataTable tabla = new DataTable();
            da.Fill(tabla);

            

            dv = new DataView(tabla);


            dgvfiltros.DataSource = dv;
            dgvfiltros.Columns["Cedula"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvfiltros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            conexion.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conexion = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=guarderia");
            cmd = new MySqlCommand("SELECT count(Nom_masc) as Cantidad, Tamaño as Medida FROM mascota Group BY Tamaño ", conexion);
            da = new MySqlDataAdapter(cmd);

            DataTable tabla = new DataTable();
            da.Fill(tabla);



            dv = new DataView(tabla);


            dgvfiltros.DataSource = dv;
            dgvfiltros.Columns["Medida"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvfiltros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void filtromesbtn_Click(object sender, EventArgs e)
        {
            conexion = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=guarderia");
            cmd = new MySqlCommand("SELECT id_regist as 'ID Registro', id_masco as 'ID Mascota', cedu_due as Cedula, id_serv as Servicio, fecha_in as Fecha " +
                "FROM ingreso WHERE fecha_in >= DATE_SUB(sysdate(), INTERVAL 1 month) ", conexion);
            da = new MySqlDataAdapter(cmd);

            DataTable tabla = new DataTable();
            da.Fill(tabla);



            dv = new DataView(tabla);


            dgvfiltros.DataSource = dv;
            dgvfiltros.Columns["Fecha"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvfiltros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void servifiltrobtn_Click(object sender, EventArgs e)
        {
            conexion = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=guarderia");
            
            cmd = new MySqlCommand("SELECT count(contador), Servicio, Descripcion, ID FROM(SELECT i.id_regist contador, s.nom_serv Servicio, s.descrip Descripcion, " +
                "s.id_serv ID FROM ingreso i, servicios s WHERE i.id_serv=s.id_serv) tabla1 Group by Servicio ", conexion);
            da = new MySqlDataAdapter(cmd);

            DataTable tabla = new DataTable();
            da.Fill(tabla);



            dv = new DataView(tabla);


            dgvfiltros.DataSource = dv;
            dgvfiltros.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvfiltros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void filtros_Load(object sender, EventArgs e)
        {
            conexion = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=guarderia");

            cmd = new MySqlCommand("SELECT count(contador), Servicio, Descripcion, ID FROM(SELECT i.id_regist contador, s.nom_serv Servicio, s.descrip Descripcion, " +
                "s.id_serv ID FROM ingreso i, servicios s WHERE i.id_serv=s.id_serv) tabla1 Group by Servicio ", conexion);
            da = new MySqlDataAdapter(cmd);

            DataTable tabla = new DataTable();
            da.Fill(tabla);



            dv = new DataView(tabla);


            dgvfiltros.DataSource = dv;
            dgvfiltros.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvfiltros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
    }
}
