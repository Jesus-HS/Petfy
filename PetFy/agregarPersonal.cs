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
    public partial class frmAgregarPersonal : Form
    {
        Consultas consultas = new Consultas();
        public frmAgregarPersonal()
        {
            InitializeComponent();
            cargarElementos();
        }

        public void cargarElementos()
        {
            DataTable dt = consultas.obtenerTabla("SELECT nombreRango FROM rangos");
            for (int i = 0; i < dt.Rows.Count; i++)
                cbRango.Items.Add(dt.Rows[i].ItemArray[0].ToString());
        }
        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            if(txtContraseña.Text == txtConfirmarContraseña.Text)
                consultas.Consulta("INSERT INTO personal VALUES(DEFAULT," + txtNombre.Text + "," + txtContraseña.Text + ", 2)");
            else
            {
                MessageBox.Show("Error al insertar");
            }
        }
    }
}
