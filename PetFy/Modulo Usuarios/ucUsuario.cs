using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetFy.Modulo_Usuarios
{
    public partial class ucUsuario : UserControl
    {
        public ucUsuario()
        {
            InitializeComponent();
        }

        private void ucUsuario_Click(object sender, EventArgs e)
        {
            frmGestor.idElemento = this.Name;
        }
    }
}
