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
    public partial class frmAgregarAdopcion : Form
    {
        public frmAgregarAdopcion()
        {
            InitializeComponent();
            imprimiradoptantes("SELECT *FROM adoptantes");
            imprimiradoptados("SELECT *FROM animales");
        }

        static public int idAdoptante;
        static public int idAdoptado;
        DataTable dt = new DataTable();
        Consultas consulta = new Consultas();
        private void imprimiradoptantes(string query)
        {
            flpAdoptantes.Controls.Clear();
            //Obtenemos la tabla de los animales registrados
            DataTable dt = consulta.obtenerTabla(query);
            //Guardamos la cantidad de animales para poder imprimirlos
            int contador = dt.Rows.Count;
            //Imprimimos todos los animales
            for (int i = 0; i < contador; i++)
            {
                ucAdoptante ucadoptante = new ucAdoptante();
                ucadoptante.Name = dt.Rows[i]["idAdoptante"].ToString();
                ucadoptante.lblNombre.Text = dt.Rows[i]["nombreAdoptante"].ToString();
                ucadoptante.lblNumero.Text = dt.Rows[i]["numeroAdoptante"].ToString();
                ucadoptante.lblDireccion.Text = dt.Rows[i]["direccionAdoptante"].ToString();
                ucadoptante.Margin = new Padding(5, 5, 5, 10);
                //Agregar el control (comentario)
                flpAdoptantes.Controls.Add(ucadoptante);
            }
        }
        private void imprimiradoptados(string query)
        {
            //Obtenemos la tabla de los animales registrados
            DataTable dt = consulta.obtenerTabla(query);
            //Imprimimos todos los animales
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //Declaramos la tarjeta del perro
                //Asi no usamos uno solo para estar sobreescribiendo
                ucAdoptado ucadoptado = new ucAdoptado();
                //Le asignamos el id del animal a la tarjeta para identificarla
                ucadoptado.Name = dt.Rows[i]["idAnimal"].ToString();
                //Asignamos la información del animal en sus campos correspondientes
                ucadoptado.lblNombre.Text = dt.Rows[i]["nombreAnimal"].ToString();
                //Asignamos la información adicional
                ucadoptado.txtAdicional.Text = dt.Rows[i]["caracteristicas"].ToString();
                //Asignamos un margen al control de usuario para estetica
                //                            Ar  Iz Ab De
                ucadoptado.Margin = new Padding(10, 10, 0, 0);
                //Agregar el control (comentario)
                flpAdoptados.Controls.Add(ucadoptado);
                GC.Collect();
            }
        }
        private void btnEmparejar_Click(object sender, EventArgs e)
        {                               //Adoptante y Adoptado
            if(idAdoptado != 0 && idAdoptante != 0)
            {
                consulta.Consulta("INSERT INTO adopciones VALUES(" + idAdoptante + "," + idAdoptado + ")");
                MessageBox.Show("Se ha asignado el adoptante el perro seleccionado");
            }
            else
            {
                MessageBox.Show("Debe seleccionar un adoptante y un animal");
            }
                
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar el elemento seleccionado?, Ten en cuenta que esto eliminara las adopciones ligadas a el", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes && idAdoptante != 0)
            {
                consulta.Consulta("DELETE FROM adopciones WHERE idAdoptante = '" + idAdoptante + "'");
                consulta.Consulta("DELETE FROM adoptantes WHERE idAdoptante = '" + idAdoptante + "'");
                MessageBox.Show("Se ha eliminado.");
            }
            else
            {
                MessageBox.Show("Por favor seleccione un adoptante antes de eliminar.");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarAdoptante frmagregaradoptante = new frmAgregarAdoptante();
            frmagregaradoptante.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmAgregarAdoptante frmagregaradoptante = new frmAgregarAdoptante();
            dt = consulta.obtenerTabla("SELECT *FROM adoptantes WHERE idAdoptante = '" + idAdoptante + "'");
            frmagregaradoptante.Name = dt.Rows[0]["idAdoptante"].ToString();
            frmagregaradoptante.txtNombre.Text = dt.Rows[0]["nombreAdoptante"].ToString();
            frmagregaradoptante.txtNumero.Text = dt.Rows[0]["numeroAdoptante"].ToString();
            frmagregaradoptante.txtDireccion.Text = dt.Rows[0]["direccionAdoptante"].ToString();
            frmagregaradoptante.btnAgregar.Text = "Modificar";
            frmagregaradoptante.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtBuscar.Text != "")
            {
                imprimiradoptantes("SELECT *FROM adoptantes WHERE nombreAdoptante = '" + txtBuscar.Text + "'");
            }
            else
            {
                MessageBox.Show("Por favor de colocar un nombre valido.");
            }
        }
    }
}
