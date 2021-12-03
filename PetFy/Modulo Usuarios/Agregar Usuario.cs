using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetFy
{
    public partial class frmAgregarusuario : Form
    {
        public frmAgregarusuario()
        {
            InitializeComponent();
            cargarElementos();
        }

        Consultas consulta = new Consultas();
        DataTable dt;

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text != "" && txtContraseña.Text != "")
            {
                var idTipo = String.Empty;
                if (btnAgregar.Text == "Modificar")
                {
                    dt = consulta.obtenerTabla("SELECT idRango FROM rangos WHERE nombreRango = '" + cbRango.Text + "'");
                    idTipo = dt.Rows[0]["idRango"].ToString().Trim();

                    if (txtContraseña.Text == txtConfirmarContraseña.Text)
                        consulta.Consulta("UPDATE usuarios SET nombreUsuario = '" + txtUsuario.Text + "', contraseñaUsuario = '" + txtContraseña.Text + "', idRango = '" + idTipo + "' WHERE idUsuario = '" + Name + "'");
                    else
                        MessageBox.Show("Verifique que las contraseñas sean iguales.");
                }
                else
                {
                    dt = consulta.obtenerTabla("SELECT idRango FROM rangos WHERE nombreRango = '" + cbRango.Text + "'");
                    idTipo = dt.Rows[0]["idRango"].ToString().Trim();

                    if (txtContraseña.Text == txtConfirmarContraseña.Text)
                        consulta.Consulta("INSERT INTO usuarios VALUES('" + txtUsuario.Text + "','" + txtContraseña.Text + "','" + idTipo + "')");
                    else
                        MessageBox.Show("Verifique que las contraseñas sean iguales.");
                }
            }
            
        }

        private void cargarElementos()
        {
            DataTable dt = consulta.obtenerTabla("SELECT nombreRango FROM Rangos");
            for (int i = 0; i < dt.Rows.Count; i++)
                cbRango.Items.Add(dt.Rows[i].ItemArray[0].ToString());
        }
    }
}
