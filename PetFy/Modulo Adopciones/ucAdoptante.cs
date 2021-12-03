using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetFy.Modulo_Adopciones
{
    public partial class ucAdoptante : UserControl
    {
        public ucAdoptante()
        {
            InitializeComponent();
        }

        private void ucAdoptante_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha seleccionado a " + lblNombre.Text);
            frmAgregarAdopcion.idAdoptante = Convert.ToInt32(Name);
        }
    }
}
