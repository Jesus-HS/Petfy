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
    public partial class frmDonaciones : Form
    {
        public frmDonaciones()
        {
            InitializeComponent();
        }
        Consultas consulta = new Consultas();
        private void Donaciones_Load(object sender, EventArgs e)
        {
            //Obtenemos la tabla de los animales registrados
            DataTable dt = consulta.obtenerTabla("select * from donaciones;");
            //Guardamos la cantidad de animales para poder imprimirlos
            int contador = dt.Rows.Count;
            //Imprimimos todos los animales
            for (int i = 0; i < contador; i++)
            {
                ucProducto ucproducto = new ucProducto();
                ucproducto.Name = dt.Rows[i]["idDonacion"].ToString();
                ucproducto.lblNombre.Text = dt.Rows[i]["nombreDonacion"].ToString();
                ucproducto.lblCantidad.Text = dt.Rows[i]["cantidadDonacion"].ToString();

                //Agregar el control (comentario)
                flpDonaciones.Controls.Add(ucproducto);
            }
        }
    }
}
