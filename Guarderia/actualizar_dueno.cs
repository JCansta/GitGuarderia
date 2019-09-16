using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Guarderia
{
    public partial class actualizar_dueno : Form
    {
        
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=guarderia;";

        string texto;
        public actualizar_dueno()
        {
            InitializeComponent();
            
        }
        public actualizar_dueno(string title)
        {
            
            texto = title;
            
        }

        

        private void actualizar_dueno_Load(object sender, EventArgs e)
        {

            texto = actualizar.valor;
            

            MySqlConnection mysqlCon = new MySqlConnection(connectionString);
            mysqlCon.Open();
            string select = "select * from dueno where num_doc='"+texto+"'";

            MySqlCommand cmd = new MySqlCommand(select, mysqlCon);
            MySqlDataReader reader = cmd.ExecuteReader();
            /*if (reader.NextResult())
            {
                string datox = reader["Nombre"].ToString();
                nombretext.Text = datox;
            }*/
            //string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Jaime Castro\Desktop\Universidad info\lenguaje de programacion\JC_1039474705repechaje_examen2.txt");










            mysqlCon.Close();
        }

        private void actualizarbtn_Click(object sender, EventArgs e)
        {
            string query = "UPDATE dueno SET Nombre='"+nombretext.Text+"', num_doc='"+documentotext.Text+"', Correo='"+correotext.Text+"',tel_dueno='"+
                telefonotext.Text+"' where num_doc='"+texto+"' ";


            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("Usuario actualizado Correctamente"+texto);

                databaseConnection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.Close();
        }
    }
}
