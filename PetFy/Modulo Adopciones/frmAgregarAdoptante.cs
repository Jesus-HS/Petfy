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
    public partial class frmAgregarAdoptante : Form
    {
        public frmAgregarAdoptante()
        {
            InitializeComponent();
        }
        Consultas consulta = new Consultas();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(btnAgregar.Text == "Agregar")
            {
                if (txtNombre.Text != "" && txtNumero.Text != "" && txtDireccion.Text != "")
                {
                    consulta.Consulta("INSERT INTO adoptantes VALUES ('" + txtNombre.Text + "','" + txtNumero.Text + "','" + txtDireccion.Text + "')");
                    MessageBox.Show("Se ha insertado el adoptante");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor de rellenar todos los campos que se le piden.");
                }
            }
            else
            {
                consulta.Consulta("UPDATE adoptantes SET nombreAdoptante = '" + txtNombre.Text + "', numeroAdoptante = '" + txtNumero.Text + "', direccionAdoptante = '" + txtDireccion.Text + "' WHERE idAdoptante = '"+this.Name+"'");
                MessageBox.Show("Se ha actualizado la información de forma correcta.");
            }
            
        }
    }
}
