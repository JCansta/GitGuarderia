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
    public partial class ingreso : Form
    {
        
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=guarderia;";
        

        public ingreso()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            vacmascno.Checked = false;
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        private string GenerarCodigo()
        {
            Random obj = new Random();
            string sCadena = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            int longitud = sCadena.Length;
            char cletra;
            int nlongitud = 5;
            string sNuevacadena = string.Empty;
            for (int i = 0; i < nlongitud; i++)
            {
                cletra = sCadena[obj.Next(longitud)];
                sNuevacadena += cletra.ToString();
            }

            return sNuevacadena;
        }
        private string GenerarCodigo2()
        {
            Random obj = new Random();
            string sCadena = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            int longitud = sCadena.Length;
            char cletra;
            int nlongitud = 10;
            string sNuevacadena = string.Empty;
            for (int i = 0; i < nlongitud; i++)
            {
                cletra = sCadena[obj.Next(longitud)];
                sNuevacadena += cletra.ToString();
            }

            return sNuevacadena;
        }
        

        private void Guardarbtn_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            string cod_aleat = GenerarCodigo();
            string cod_aleat2 = GenerarCodigo2();

            if (nom_masctext.Text==null || nom_masctext.Text=="")
            {
                MessageBox.Show("No se ingreso el nombre de la mascota");
                goto salta;
            }
            if (raza_masco.Text == null || raza_masco.Text=="")
            {
                MessageBox.Show("No se ingreso la raza de la mascota");
                goto salta;
            }
            if (nom_dueno.Text == null || nom_dueno.Text=="")
            {
                MessageBox.Show("No se ingreso el nombre del dueño");
                goto salta;
            }
            if (num_docsuenotext.Text == null || num_docsuenotext.Text=="")
            {
                MessageBox.Show("No se ingreso el numero de documento");
                goto salta;
            }
            if (correo_dueno.Text == null || correo_dueno.Text=="")
            {
                MessageBox.Show("No se ingreso el correo");
                goto salta;
            }
            if (gen_masc.Text == null || gen_masc.Text =="")
            {
                MessageBox.Show("No se ingreso el genero de la mascota");
                goto salta;
            }
            
            string vacuna = "";
            if (vac_mascsi.Checked==true)
            {
                vacuna = "si";
            }
            else
            {
                vacuna = "no";
            }

            string sql = "SELECT num_doc from dueno where num_doc="+num_docsuenotext.Text+";";
            string dato = "";
            try
            {
                MySqlConnection Conexion = new MySqlConnection(connectionString.ToString());

                Conexion.Open();

                MySqlCommand Comando = new MySqlCommand(sql, Conexion);


                MySqlDataReader Datos = Comando.ExecuteReader();
                if (Datos.NextResult())
                {
                    // si trae registro
                    dato = Datos["nombre"].ToString();
                }else
                {
                    // no trajo registros
                    dato = null;
                }

                Datos.Close();
                Conexion.Close();
                //dato = "algo";


            }
            catch (Exception)
            {
                
                dato = null;
                
            }


            if (dato!=null)
            {
                goto usuario;   
            }

            string query = "INSERT INTO mascota(`Nom_masc`, `Raza`, `Tamaño`,`vacunas`,`Genero`,`Foto`,`ID_masco`) VALUES ('" + nom_masctext.Text +
                "', '" + raza_masco.Text + "', '" + lista_tamano.Text + "','" + vacuna + "', '" + gen_masc.Text + "','" + img_masco.Image + "','" + cod_aleat + "'); \n" +
                "INSERT INTO dueno(`Nombre`,`num_doc`,`Correo`,`tel_dueno`) VALUES ('" + nom_duenoText.Text + "','" + num_docsuenotext.Text + "','" + correo_dueno.Text + "','" + Tel_dueno.Text + "');\n";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
               commandDatabase.ExecuteNonQuery();

                

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
            
            string query1 = "INSERT INTO ingreso(`id_regist`,`id_masco`,`cedu_due`,`id_Serv`,`fecha_in`) VALUES ('" + cod_aleat2 + "','" + cod_aleat + "','" + num_docsuenotext.Text + "','" + masc_servi.SelectedValue + " ',sysdate()); ";


            
            MySqlCommand commandDatabase1 = new MySqlCommand(query1, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                //MySqlDataReader myReader = commandDatabase1.ExecuteReader();
                commandDatabase1.ExecuteNonQuery();

                 MessageBox.Show("Usuario insertado satisfactoriamente");

                databaseConnection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        borrar:
            nom_masctext.Text = "";
            raza_masco.Text = "";
            nom_duenoText.Text = "";
            num_docsuenotext.Text = "";
            correo_dueno.Text = "";
            gen_masc.Text = "";
            Tel_dueno.Text = "";

            goto salta;

        usuario:
            string query2 = "INSERT INTO mascota(`Nom_masc`, `Raza`, `Tamaño`,`vacunas`,`Genero`,`Foto`,`ID_masco`) VALUES ('" + nom_masctext.Text +
                "', '" + raza_masco.Text + "', '" + lista_tamano.Text + "','"+vacuna+"', '" + gen_masc.Text + "','" + img_masco.Image + "','" + cod_aleat + "'); \n" +
                "INSERT INTO ingreso(`id_regist`,`id_masco`,`cedu_due`,`id_Serv`,`fecha_in`) VALUES ('" + cod_aleat2 + "','" + cod_aleat + "','" + num_docsuenotext.Text + 
                "','" + masc_servi.SelectedValue + " ',sysdate()); ";


            MySqlConnection databaseConnection2 = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase2 = new MySqlCommand(query2, databaseConnection2);
            commandDatabase2.CommandTimeout = 60;

            try
            {
                databaseConnection2.Open();
                MySqlDataReader myReader = commandDatabase2.ExecuteReader();

                MessageBox.Show("Usuario insertado satisfactoriamente");

                databaseConnection2.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            goto borrar;


        salta:
            
            ;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    img_masco.Image = Image.FromFile(imagen);
                }
            }
            catch (Exception )
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void gen_masc_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void ingreso_Load(object sender, EventArgs e)
        {
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand("select * from servicios", databaseConnection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dtServicio = new DataTable();

            da.Fill(dtServicio);

            masc_servi.DataSource = dtServicio;
            masc_servi.DisplayMember = "nom_serv";
            masc_servi.ValueMember = "id_serv";

            


        }

        private void correo_dueno_TextChanged(object sender, EventArgs e)
        {

        }

        private void masc_servi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void vacmascno_CheckedChanged(object sender, EventArgs e)
        {
            vac_mascsi.Checked = false;
            
        }

        private void num_docsuenotext_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void num_docsuenotext_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Este campo solo permite numeros.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void num_docsuenotext_TextChanged(object sender, EventArgs e)
        {

        }

        private void text2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void nom_dueno_Click(object sender, EventArgs e)
        {

        }

        private void Guardarbtn_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void img_masco_Click(object sender, EventArgs e)
        {

        }
    }
}
