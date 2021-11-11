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
    public partial class frmAgregarusuario : Form
    {
        public frmAgregarusuario()
        {
            InitializeComponent();
            cargarElementos();
        }

        Consultas consulta = new Consultas();
        DataTable dt;

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var idTipo = String.Empty;
            dt = consulta.obtenerTabla("SELECT idRango FROM rangos WHERE nombreRango = '" + cbRango.Text + "'");
            idTipo = dt.Rows[0]["idRango"].ToString().Trim();

            if (txtContraseña.Text == txtConfirmarContraseña.Text)
                consulta.Consulta("INSERT INTO usuarios VALUES('" + txtUsuario.Text + "','" + txtContraseña.Text + "','" + idTipo + "')");
        }

        private void cargarElementos()
        {
            DataTable dt = consulta.obtenerTabla("SELECT nombreRango FROM Rangos");
            for (int i = 0; i < dt.Rows.Count; i++)
                cbRango.Items.Add(dt.Rows[i].ItemArray[0].ToString());
        }
    }
}
