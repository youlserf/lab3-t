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

namespace Lab1
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            
            /*
            string connString = ("server=LAB707-06\\SQLEXPRESS; database=msdb; Integrated Security=True;");
            string query = "SELECT * FROM syscategories;";
            SqlConnection connection = new SqlConnection(connString);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            connection.Close();
            dataGridView2.DataSource = table;
            dataGridView2.Refresh();*/
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string server = txtServer.Text;
            string bd = txtBD.Text;
            string user = txtUser.Text;
            string pwd = txtPassword.Text;

            string str = "server=" + server + ";database=" + bd + ";";

            if (checkPreference.Checked)
            {
                str += "Integrated Security=True;";
            }
            else
            {
                str += "User Id=" + user + "; Password" + pwd + ";";
            }

            try
            {
                conn = new SqlConnection(str);
                conn.Open();
                MessageBox.Show("Conectado satisfactoriamente");
                btnClose.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar al servidor: \n" + ex.ToString());
            }
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            try {
                if (conn.State == ConnectionState.Open)
                    MessageBox.Show("Estado del servidor: " + conn.State
                        + "\nVersion del servidor: " + conn.ServerVersion
                        + "\nBase de datos: " + conn.Database);
            } catch(Exception ex)
            {
                MessageBox.Show("Imposible determinar el estado del servidor: \n" + ex.ToString());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                    MessageBox.Show("Conexion cerrada satisfactoriamente");
                }
                else
                    MessageBox.Show("La conexion ya esta cerrada");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al cerrar la conexion: \n" +
                    ex.ToString());
            }
        }

        private void checkPreference_CheckedChanged(object sender, EventArgs e)
        {
            if(checkPreference.Checked)
            {
                txtUser.Enabled = false;
                txtPassword.Enabled = false;
            }else
            {
                txtUser.Enabled = true;
                txtPassword.Enabled = true; 
            }
        }
    }
}
