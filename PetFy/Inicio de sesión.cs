using System;
using System.Data;
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
            try
            {
                string query = string.Format("SELECT *FROM usuarios WHERE nombreUsuario = '" + txtUsuario.Text.Trim() + "' AND contraseñaUsuario = '" + txtContraseña.Text.Trim() + "'");

                //Aqui obtenemos la tabla de la consulta
                DataTable dt = consulta.obtenerTabla(query);

                //Sustraemos los datos de la consulta
                id = dt.Rows[0]["idUsuario"].ToString().Trim();
                string cuenta = dt.Rows[0]["nombreUsuario"].ToString().Trim();
                string clave = dt.Rows[0]["contraseñaUsuario"].ToString().Trim();

                /* Si los datos almacenados en las variables corresponden a los mismo que los ingresados en
                   las cajas de texto entonces nos lanza el formulario principal */
                if (cuenta == txtUsuario.Text.Trim() && clave == txtContraseña.Text.Trim())
                {
                    frmGestor gestor = new frmGestor(id);
                    gestor.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Hubo un error, intentalo de nuevo más tarde.");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Usuario o contraseña son incorrectas, por favor de introducir información válida.");
            }
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
