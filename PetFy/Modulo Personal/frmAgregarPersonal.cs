using System;
using System.Windows.Forms;

namespace PetFy
{
    public partial class frmAgregarPersonal : Form
    {
        Consultas consulta = new Consultas();

        public frmAgregarPersonal()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(btnAgregar.Text == "Agregar")
            {
                consulta.Consulta("INSERT INTO personal VALUES('" + txtNombre.Text + "','" + txtDireccion.Text + "','" + txtNumero.Text + "');");
            }
            else
            {
                consulta.Consulta("UPDATE personal SET nombrePersonal = '" + txtNombre.Text + "', direccionPersonal = '" + txtDireccion.Text + "', numeroPersonal = '" + txtNumero.Text + "' WHERE idPersonal = '" + Name + "';");
            }
            this.Close();
        }
    }
}
