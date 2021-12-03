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
    public partial class ucProducto : UserControl
    {
        public ucProducto()
        {
            InitializeComponent();
        }
        string idElemento;
        Consultas consulta = new Consultas();
        DataTable dt = new DataTable();
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                dt = consulta.obtenerTabla("select idUsuario, nombreUsuario, contraseñaUsuario, rangos.nombreRango from usuarios JOIN rangos ON rangos.idRango = usuarios.idRango WHERE idUsuario = '" + frmGestor.idUsuario + "';");
                if (dt.Rows[0]["nombreRango"].ToString() == "Administrador")
                {
                    idElemento = this.Name;
                    if (MessageBox.Show("¿Desea eliminar el elemento seleccionado?" + idElemento, "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes && idElemento != string.Empty)
                    {
                        consulta.Consulta("DELETE FROM donaciones WHERE idDonacion='" + idElemento + "'");
                        idElemento = string.Empty;
                        MessageBox.Show("Se elimino");
                    }
                    else
                        MessageBox.Show("Rechazo la pregunta o quizas no selecciono nada.", "No se elimino");
                }
                else
                {
                    MessageBox.Show("Solo el administrador realizar esta accion.");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString(), "Mostrar mensaje al desarrollador"); }
        }

        private void ucProducto_Click(object sender, EventArgs e)
        {
            frmGestor.idElemento = this.Name;
        }
    }
}
