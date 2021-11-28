using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetFy
{
    public partial class frmAgregarAnimal : Form
    {
        Consultas consultas = new Consultas();
        DataTable dt;
        public frmAgregarAnimal()
        {
            InitializeComponent();
            cargarElementos();
        }

        private void cargarElementos()
        {
            DataTable dt = consultas.obtenerTabla("SELECT nombreTipo FROM tipos");
            for (int i = 0; i < dt.Rows.Count; i++)
                cbTipo.Items.Add(dt.Rows[i].ItemArray[0].ToString());
            
            dt = consultas.obtenerTabla("SELECT nombreRaza FROM razas");
            for (int i = 0; i < dt.Rows.Count; i++)
                cbRaza.Items.Add(dt.Rows[i].ItemArray[0].ToString());
        }
        
        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            string genero = "", idTipo = "", idRaza = "";
            if (cmdAgregar.Text == "Modificar")
            {
                dt = consultas.obtenerTabla("SELECT idTipo FROM tipos WHERE nombreTipo = '" + cbTipo.Text + "'");
                idTipo = dt.Rows[0]["idTipo"].ToString().Trim();
                dt = consultas.obtenerTabla("SELECT idRaza FROM razas WHERE nombreRaza = '" + cbRaza.Text + "'");
                idRaza = dt.Rows[0]["idRaza"].ToString().Trim();

                if (rbMacho.Checked)
                    genero = "1";
                else if (rbHembra.Checked)
                    genero = "0";

                //                                                             NOMBRE                                    Caracteristicas                                Genero                    Raza            Tipo        Historial
                consultas.Consulta("UPDATE animales SET nombreAnimal = '" + txtNombre.Text + "', caracteristicas = '" + rtCaracteristicas.Text + "', generoAnimal = '" + genero + "', idRaza = '" + idRaza + "', idTipo = '" + idTipo + "' WHERE idAnimal = '" + cmdAgregar.Name + "';");
            }
            else if(cmdAgregar.Text == "Agregar")
            {
                dt = consultas.obtenerTabla("SELECT idTipo FROM tipos WHERE nombreTipo = '" + cbTipo.Text + "'");
                idTipo = dt.Rows[0]["idTipo"].ToString().Trim();
                dt = consultas.obtenerTabla("SELECT idRaza FROM razas WHERE nombreRaza = '" + cbRaza.Text + "'");
                idRaza = dt.Rows[0]["idRaza"].ToString().Trim();

                if (rbMacho.Checked)
                    genero = "1";
                else if (rbHembra.Checked)
                    genero = "0";

                //                                                       NOMBRE                       Caracteristicas               Genero      Fecha         Raza            Tipo        Historial
                consultas.Consulta("INSERT INTO animales VALUES('" + txtNombre.Text + "'," + "'" + rtCaracteristicas.Text + "'," + genero + ", GETDATE(), " + idRaza + ", " + idTipo + ", NULL);");
            }

        }
    }
}
