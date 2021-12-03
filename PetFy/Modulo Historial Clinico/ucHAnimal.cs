using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetFy.Modulo_Historial_Clinico
{
    public partial class ucHAnimal : UserControl
    {
        public ucHAnimal()
        {
            InitializeComponent();
        }

        private void historialAnimal_Click(object sender, EventArgs e)
        {
            frmAgregarHistorialClinico.idAnimal = Convert.ToInt32(Name);
            MessageBox.Show("Has seleccionado al animal " + lblNombre.Text);
        }

        private void txtAdicional_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
