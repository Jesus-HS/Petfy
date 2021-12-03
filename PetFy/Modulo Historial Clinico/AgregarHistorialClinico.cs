using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetFy.Modulo_Historial_Clinico
{
    public partial class frmAgregarHistorialClinico : Form
    {
        static public string ruta;
        static public int idHistorial = 0;
        static public int idAnimal = 0;
        public frmAgregarHistorialClinico()
        {
            InitializeComponent();
        }
        Consultas consulta = new Consultas();
        OpenFileDialog ofd = new OpenFileDialog();
        private void frmAgregarHistorialClinico_Load(object sender, EventArgs e)
        {
            cargarHistoriales("SELECT *FROM historial");
            cargarAnimales("SELECT idAnimal, nombreAnimal, caracteristicas FROM animales");
        }

        private void cargarAnimales(string query)
        {
            //Obtenemos la tabla de los animales registrados
            DataTable dt = consulta.obtenerTabla(query);
            //Imprimimos todos los animales
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //Declaramos la tarjeta del perro
                //Asi no usamos uno solo para estar sobreescribiendo
                ucHAnimal uchanimal = new ucHAnimal();
                //Le asignamos el id del animal a la tarjeta para identificarla
                uchanimal.Name = dt.Rows[i]["idAnimal"].ToString();
                //Asignamos la información del animal en sus campos correspondientes
                uchanimal.lblNombre.Text = dt.Rows[i]["nombreAnimal"].ToString();
                //Asignamos la información adicional
                uchanimal.txtAdicional.Text = dt.Rows[i]["caracteristicas"].ToString();
                //Asignamos un margen al control de usuario para estetica
                //                            Ar  Iz Ab De
                uchanimal.Margin = new Padding(10, 10, 0, 0);
                //Agregar el control (comentario)
                flpGestor.Controls.Add(uchanimal);
                GC.Collect();
            }
        }

        private void btnAdjuntar_Click(object sender, EventArgs e)
        {
            //textodeformato(*.formato) | *.formato | otroformato(*.formato2 *) | *.formato2
            ofd.InitialDirectory = "C:\\";
            ofd.Filter = "Archivos PDF(*.pdf)|*.pdf";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ruta = ofd.FileName;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ruta != null && txtNombre.Text != "")
                {
                    byte[] file = null;
                    Stream myStream = ofd.OpenFile();
                    using (MemoryStream ms = new MemoryStream())
                    {
                        myStream.CopyTo(ms);
                        file = ms.GetBuffer();
                    }
                    using (PetfyDBEntities db = new PetfyDBEntities())
                    {
                        historial ht = new historial();
                        ht.contenidoHistorial = file;
                        ht.nombreHistorial = txtNombre.Text;
                        db.historial.Add(ht);
                        db.SaveChanges();
                    }
                }
                else { MessageBox.Show("No has introducido ningun nombre o ningun archivo."); }
                cargarHistoriales("SELECT *FROM historial");
                txtNombre.Text = String.Empty;
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
        }

        private void cargarHistoriales(string query)
        {
            flpHistoriales.Controls.Clear();
            //Obtenemos la tabla de los animales registrados
            DataTable dt = consulta.obtenerTabla(query);
            //Guardamos la cantidad de animales para poder imprimirlos
            int contador = dt.Rows.Count;
            //Imprimimos todos los animales
            for (int i = 0; i < contador; i++)
            {
                //Declaramos la tarjeta del perro
                //Asi no usamos uno solo para estar sobreescribiendo
                ucHClinico hc = new ucHClinico();
                hc.lblId.Text = dt.Rows[i]["idHistorial"].ToString();
                hc.lblNombre.Text = dt.Rows[i]["nombreHistorial"].ToString();
                //Agregar el control (comentario)
                flpHistoriales.Controls.Add(hc);
                GC.Collect();
            }
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if(idAnimal != 0 && idHistorial != 0)
            {
                consulta.Consulta("UPDATE animales SET idHistorial = '" + idHistorial + "' WHERE idAnimal = '" + idAnimal + "'");
            }
        }
        static public string nombrePDF = String.Empty;
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            nombrePDF = txtNombre.Text;
        }
    }
}
