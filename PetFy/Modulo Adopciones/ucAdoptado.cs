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
    public partial class ucAdoptado : UserControl
    {
        public ucAdoptado()
        {
            InitializeComponent();
        }

        private void ucAdoptado_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha seleccionado a " + lblNombre.Text);
            frmAgregarAdopcion.idAdoptado = Convert.ToInt32(Name);
        }
    }
}
