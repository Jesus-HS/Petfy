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
    public partial class ucAdopciones : UserControl
    {
        public ucAdopciones()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ucAdopciones_Click(object sender, EventArgs e)
        {
            frmGestor.idElemento = lblIdAdoptante.Text;
            frmGestor.idElementoSecundario = lblIdAdoptado.Text;
            MessageBox.Show("Se ha seleccionado una nueva tarjetilla.");
        }
    }
}
