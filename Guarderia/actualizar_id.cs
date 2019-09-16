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
    public partial class actualizar_id : Form
    {
        string texto;
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=guarderia;";
        public actualizar_id()
        {
            InitializeComponent();
        }

        public void actualizar_id_Load(object sender, EventArgs e)
        {
            texto = actualizar.valor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    img_masco.Image = Image.FromFile(imagen);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }*/
        }
        string vacuna;
        private void actualizarbtn_Click(object sender, EventArgs e)
        {
            if (vac_mascsi.Checked==true)
            {
                vacuna = "Si";
            }
            if (vacmascno.Checked == true)
            {
                vacuna = "No";
            }
            string query = "UPDATE mascota SET Nom_masc='" + nom_masctext.Text + "', raza='" + raza_masco.Text + "', Tamaño='" + lista_tamano.Text + "',Vacunas='" +
                vacuna + "',Genero='"+gen_masc.Text+"' where ID_masco='" + texto + "' ";


            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("Usuario actualizado Correctamente" + texto);

                databaseConnection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.Close();
        }

        private void vac_mascsi_CheckedChanged(object sender, EventArgs e)
        {
            if (vacmascno.Checked == true)
            {
                vacmascno.Checked = false;
            }
        }

        private void vacmascno_CheckedChanged(object sender, EventArgs e)
        {
            if (vac_mascsi.Checked==true)
            {
                vac_mascsi.Checked = true;
            }
        }
    }
}
