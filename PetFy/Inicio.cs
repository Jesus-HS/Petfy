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

namespace PetFy
{
    public partial class frmInicioSesion : Form
    {
        Consultas consulta;
        public frmInicioSesion()
        {
            InitializeComponent();
            consulta = new Consultas();
        }
        private string id;
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string query = string.Format("SELECT *FROM usuarios WHERE nombre = '" + txtUsuario.Text.Trim() + "' AND contraseña = '" + txtContraseña.Text.Trim() + "'");

            //Aqui obtenemos la tabla de la consulta
            DataTable dt = consulta.obtenerTabla(query);

            //Sustraemos los datos de la consulta
            id = dt.Rows[0]["idUsuario"].ToString().Trim();
            string cuenta = dt.Rows[0]["nombre"].ToString().Trim();
            string clave = dt.Rows[0]["contraseña"].ToString().Trim();

            /* Si los datos almacenados en las variables corresponden a los mismo que los ingresados en
               las cajas de texto entonces nos lanza el formulario principal */
            if (cuenta == txtUsuario.Text.Trim() && clave == txtContraseña.Text.Trim())
            {
                frmGestor frmGestor = new frmGestor();
                frmGestor.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hubo un error, intentalo de nuevo más tarde.");
            }
        }
    }
}
