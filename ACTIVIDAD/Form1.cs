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

namespace ACTIVIDAD
{ 
    public partial class Form1 : Form
    {
        private SqlConnection Conexion = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void BotonConectar_Click(object sender, EventArgs e)
        {
            string SConexion = @"Server=(LocalDB)\MSSQLLocalDB;Database= master;Trusted_Connection=True;";
            try
            {
                using (Conexion = new SqlConnection(SConexion))
                {
                    Conexion.Open();
                    MessageBox.Show("Servidor: " + Conexion.DataSource + 
                        "\nDatabase: " + Conexion.Database+
                        "\nEstado Conexion: "+Conexion.State.ToString()+
                        "\nVersion de servidor: "+Conexion.ServerVersion);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
            }
            finally { Conexion.Close(); }
        }
    }
}
