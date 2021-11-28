using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetFy
{
    public partial class ucAnimal : UserControl
    {
        public ucAnimal()
        {
            InitializeComponent();
        }
        private void ucAnimal_Click(object sender, EventArgs e)
        {
            frmGestor.idElemento = this.Name;
        }
    }
}