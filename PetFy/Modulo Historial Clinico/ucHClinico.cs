using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetFy.Modulo_Historial_Clinico
{
    public partial class ucHClinico : UserControl
    {
        public ucHClinico()
        {
            InitializeComponent();
        }
        Consultas consulta = new Consultas();
        private void btnVer_Click(object sender, EventArgs e)
        {
            using(PetfyDBEntities db = new PetfyDBEntities())
            {
                var tabla = db.historial.Find(Convert.ToInt16(lblId.Text));

                string direccion = AppDomain.CurrentDomain.BaseDirectory;
                string folder = direccion + "/temp/";
                string completo = folder + lblId.Text + ".pdf";

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
                if (File.Exists(completo))
                {
                    Directory.Delete(completo);
                }
                File.WriteAllBytes(completo, tabla.contenidoHistorial);

                Process.Start(completo);
            }
        }

        private void historialClinico_Click(object sender, EventArgs e)
        {
            frmAgregarHistorialClinico.idHistorial = Convert.ToInt32(lblId.Text);
            MessageBox.Show("Has Seleccionado el historial de " + lblNombre.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar el elemento seleccionado?" + lblNombre.Text, "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                consulta.Consulta("UPDATE animales SET idHistorial = NULL WHERE idHistorial = '" + lblId.Text + "'");
                consulta.Consulta("DELETE historial WHERE idHistorial = '" + lblId.Text + "'");
            }
            else
                MessageBox.Show("Rechazo la pregunta o quizas no selecciono nada.", "No se elimino");

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var nombre = frmAgregarHistorialClinico.nombrePDF;
            if ( nombre != "" && frmAgregarHistorialClinico.ruta != "")
            {
                consulta.Consulta("UPDATE historial SET nombreHistorial = '" + nombre + "' WHERE idHistorial = '" + lblId.Text + "'");
            }
        }
    }
}
