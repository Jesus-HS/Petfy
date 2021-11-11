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
        DataTable dt;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dt = consultas.obtenerTabla("SELECT *FROM productos");
            consultas.Consulta("INSERT INTO productos VALUES('" + txtNombre.Text + "'," + nudCantidad.Value + ")");
        }
    }
}
