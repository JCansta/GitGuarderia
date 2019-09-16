using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Guarderia
{
    public partial class Salida : Form
    {
        MySqlConnection conexion;
        MySqlCommand cmd;
        MySqlDataAdapter da;

        DataView dv;
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=guarderia;";
        public Salida()
        {
            InitializeComponent();
        }
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void buscarbtn_Click(object sender, EventArgs e)
        {
            /*  if (check_id.Checked == true)
              {
                  dv.RowFilter = "ID Mascota=" + id_mascotext.Text + "";
              }
              if (check_doc.Checked == true)
              {
                  dv.RowFilter = "Cedula Propietario =" + id_mascotext.Text + "";
              }
              */
            string sql = "SELECT * FROM mascota where ID_masco=" + id_mascotext.Text + ";";

            try
            {
                MySqlConnection Conexion = new MySqlConnection(connectionString.ToString());

                Conexion.Open();

                MySqlCommand Comando = new MySqlCommand(sql, Conexion);


                MySqlDataAdapter dp = new MySqlDataAdapter(Comando);
                DataSet ds = new DataSet("mascota");
                /*
                dp.Fill(ds, "Foto");
                int count = ds.Tables["Foto"].Rows.Count;
                if (count >0)
                {
                    var data = (Byte[])ds.Tables["Foto"].Rows[count - 1]["Foto"];
                    var stream = new MemoryStream(data);
                    imagen_masco.Image = Image.FromStream(stream);
                        }


    */
            }
            catch (Exception evt)
            {
                MessageBox.Show("ID no encontrada: " + evt.Message);
                goto final;
            }

            if (check_id.Checked == true)
            {
                try
                {
                    dv.RowFilter = "ID=" + id_mascotext.Text;
                }
                catch (Exception)
                {
                    MessageBox.Show("ID no encontrada");
                    
                }
            }
            if (check_doc.Checked == true)
            {
                try
                {
                    dv.RowFilter = "Cedula=" + id_mascotext.Text;
                }
                catch (Exception)
                {

                    MessageBox.Show("Cedula no encontrada");
                }
            }


        final:
            ;
            
        }
        private void dgv_salida_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string value = "";
            if (e.ColumnIndex == dgv_salida.Columns["Dar Salida"].Index)
            {

                value = dgv_salida.Rows[e.RowIndex].Cells["ID registro"].Value.ToString();

                string query = "UPDATE ingreso SET fecha_out=sysdate() WHERE id_regist='"+value+"'";

                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;

                try
                {
                    databaseConnection.Open();
                    MySqlDataReader myReader = commandDatabase.ExecuteReader();

                    MessageBox.Show("Usuario insertado satisfactoriamente");

                    databaseConnection.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                Salida_Load(sender, e);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Salida_Load(object sender, EventArgs e)
        {
            string comando = "SELECT i.id_regist as 'ID registro', m.ID_masco as 'ID',m.Nom_masc as Nombre,m.raza as Raza,m.Tamaño as Medida,m.vacunas as Vacunado," +
                " i.cedu_due as 'Cedula',m.Genero,i.fecha_in as Entrada FROM mascota m, ingreso i where i.ID_masco = m.ID_masco and i.fecha_out is NUll ";


            dgv_salida.CellClick += dgv_salida_CellClick;
            conexion = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=guarderia");
            conexion.Open();
            cmd = new MySqlCommand(comando, conexion);
            da = new MySqlDataAdapter(cmd);

            DataTable tabla = new DataTable();
            da.Fill(tabla);



            dv = new DataView(tabla);


            dgv_salida.DataSource = dv;
            dgv_salida.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_salida.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewButtonColumn uninstallButtonColumn = new DataGridViewButtonColumn();
            uninstallButtonColumn.Name = "Dar Salida";
            uninstallButtonColumn.Text = "Salida";
            int columnIndex = 2;
            if (dgv_salida.Columns["Dar Salida"] == null)
            {
                dgv_salida.Columns.Insert(columnIndex, uninstallButtonColumn);
            }

        }

        private void dgv_salida_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buscarbtn_Click_1(object sender, EventArgs e)
        {

        }

        private void id_mascotext_TextChanged(object sender, EventArgs e)
        {

        }
       



        

        private void id_mascotext_Enter_1(object sender, EventArgs e)
        {
            if (id_mascotext.Text == "🔎")
            {
                id_mascotext.Text = "";
                id_mascotext.ForeColor = Color.Black;
            }
        }

        private void id_mascotext_Leave_1(object sender, EventArgs e)
        {
            if (id_mascotext.Text == "")
            {
                id_mascotext.Text = "🔎";
                id_mascotext.ForeColor = Color.Orange;
            }
        }
    }
}
