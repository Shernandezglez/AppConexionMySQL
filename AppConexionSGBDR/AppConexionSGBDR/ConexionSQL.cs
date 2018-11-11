using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;

namespace AppConexionSGBDR
{
    public partial class ConexionSQL : Form
    {
        MySql.Data.MySqlClient.MySqlConnection connection;
        

        public ConexionSQL()
        {
            InitializeComponent();
        }
        
        List<string>[] list = new List<string>[1];


        private void button1_Click(object sender, EventArgs e)
        {

           string server = txtHost.Text;
           string port = txtPort.Text;
           string uid = txtUser.Text;
           string password = txtPass.Text;
           string bd = txtBD.Text;
           string connectionString;

            connectionString = "server=" + server + ";" + "uid=" +
            uid + ";" + "pwd=" + password + ";" + "port=" + port + ";" + "database=" + bd + ";";

            try
            {
                connection = new MySql.Data.MySqlClient.MySqlConnection();
                connection.ConnectionString = connectionString;
                connection.Open();
                MessageBox.Show("Conexion extiosa... presione OK para continuar");
                txtSentence.Focus();
                
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error de conexion");
               
            }

        }

        private void btnEjecutarSentencia_Click(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(txtSentence.Text, connection);
            try
            {
                MySql.Data.MySqlClient.MySqlDataReader rdr = cmd.ExecuteReader();
                /*while (rdr.Read())
                {
                    lstResultado.Items.Add(rdr["NoCuenta"].ToString());
                }
                rdr.Close();*/
                while (rdr.Read())
                {
                    for(int i = 0; i < rdr.FieldCount; i++)
                    {
                        string c = rdr.GetName(i);
                        lstResultado.Items.Add(c + ": " + rdr[c] + Environment.NewLine); 
                    }

                    lstResultado.Items.Add(Environment.NewLine);
                }
                rdr.Close();

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("no ha seleccionado ninguna BD");
                
            }
        }

        private void btnCerrarConexion_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Close();
                MessageBox.Show("Se cerró la conexión");
            }catch(MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("No se estableció una conexion");
            }
            
        }

       

        
    }
}
