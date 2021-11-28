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
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            idElemento = this.Name;
            try
            {
                if (MessageBox.Show("¿Desea eliminar el elemento seleccionado?" + idElemento, "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes && idElemento != string.Empty)
                {
                    consulta.Consulta("DELETE FROM donaciones WHERE idDonacion='" + idElemento + "'");
                    idElemento = string.Empty;
                    MessageBox.Show("Se elimino");
                }
                else
                    MessageBox.Show("Rechazo la pregunta o quizas no selecciono nada.", "No se elimino");
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString(), "Mostrar mensaje al desarrollador"); }
        }

        private void ucProducto_Click(object sender, EventArgs e)
        {
            frmGestor.idElemento = this.Name;
        }
    }
}
