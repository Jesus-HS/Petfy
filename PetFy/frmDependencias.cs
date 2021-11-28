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
    public partial class frmDependencias : Form
    {
        public frmDependencias()
        {
            InitializeComponent();
        }
        Consultas consulta = new Consultas();
        private void btnSubir_Click(object sender, EventArgs e)
        {
            if(rbRango.Checked && txtRango.Text != "")
            {
                consulta.Consulta("INSERT INTO rangos VALUES ('" + txtRango.Text + "')");
            }
            else if (rbRaza.Checked && txtRaza.Text != "")
            {
                consulta.Consulta("INSERT INTO razas VALUES('" + txtRaza.Text + "')");
            }
            else if (rbTipo.Checked && txtTipo.Text != "")
            {
                consulta.Consulta("INSERT INTO tipos VALUES('" + txtTipo.Text + "')");
            }
            else
            {
                MessageBox.Show("Por favor selecciona una opción");
            }
        }
    }
}
