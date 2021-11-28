using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetFy.Modulo_Almacen
{
    public partial class frmAgregarProducto : Form
    {
        public frmAgregarProducto()
        {
            InitializeComponent();
        }
        Consultas consultas = new Consultas();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(btnAgregar.Text == "Modificar")
            {
                consultas.Consulta("UPDATE productos SET nombreProducto='" + txtNombre.Text + "', cantidad='" + nudCantidad.Value + "'");
            }
            else
            {
                consultas.Consulta("INSERT INTO productos VALUES('" + txtNombre.Text + "'," + nudCantidad.Value + ")");
                if (checkDonacion.Checked)
                {
                    consultas.Consulta("INSERT INTO donaciones VALUES('" + txtNombre.Text + "'," + nudCantidad.Value + ")");
                }
            }
            
        }
    }
}
