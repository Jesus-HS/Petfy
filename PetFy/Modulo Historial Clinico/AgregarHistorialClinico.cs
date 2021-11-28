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
        private string ruta;
        public frmAgregarHistorialClinico()
        {
            InitializeComponent();
        }
        Consultas consulta = new Consultas();
        OpenFileDialog ofd = new OpenFileDialog();
        private void frmAgregarHistorialClinico_Load(object sender, EventArgs e)
        {
            cargarHistoriales("SELECT *FROM historial");
            //Obtenemos la tabla de los animales registrados
            DataTable dt = consulta.obtenerTabla("SELECT idAnimal, nombreAnimal, caracteristicas, generoAnimal, fechaAnimal, razas.nombreRaza, tipos.nombreTipo, fotoAnimal " +
                                                     "FROM animales " +
                                                     "JOIN Razas ON razas.idRaza = animales.idRaza " +
                                                     "JOIN tipos ON tipos.idTipo = animales.idTipo; ");
                //Guardamos la cantidad de animales para poder imprimirlos
                int contador = dt.Rows.Count;
                //Imprimimos todos los animales
                for (int i = 0; i < contador; i++)
                {
                    //Declaramos la tarjeta del perro
                    //Asi no usamos uno solo para estar sobreescribiendo
                    ucAnimal usanimal = new ucAnimal();
                    //Le asignamos el id del animal a la tarjeta para identificarla
                    usanimal.Name = dt.Rows[i]["idAnimal"].ToString();
                    //Asignamos la información del animal en sus campos correspondientes
                    usanimal.lblNombre.Text = dt.Rows[i]["nombreAnimal"].ToString();
                    usanimal.lblRaza.Text = dt.Rows[i]["nombreRaza"].ToString();
                    usanimal.lblTipo.Text = dt.Rows[i]["nombreTipo"].ToString();
                    usanimal.lblFecha.Text = dt.Rows[i]["fechaAnimal"].ToString();
                    //Si el valor de la columna genero animal es true significa que es macho, sino es hembra
                    //la información de dicha columna es guardada en bit
                    if (dt.Rows[i]["generoAnimal"].ToString() == "True")
                        usanimal.lblSexo.Text = "Macho";
                    else
                        usanimal.lblSexo.Text = "Hembra";
                    //Asignamos un margen al control de usuario para estetica
                    //                            Ar  Iz Ab De
                    usanimal.Margin = new Padding(10, 10, 0, 0);
                    //Agregar el control (comentario)
                    flpGestor.Controls.Add(usanimal);
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
                if (ruta != null)
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
                cargarHistoriales("SELECT *FROM historial");
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
        }

        private void cargarHistoriales(string query)
        {
            //Obtenemos la tabla de los animales registrados
            DataTable dt = consulta.obtenerTabla(query);
            //Guardamos la cantidad de animales para poder imprimirlos
            int contador = dt.Rows.Count;
            //Imprimimos todos los animales
            for (int i = 0; i < contador; i++)
            {
                //Declaramos la tarjeta del perro
                //Asi no usamos uno solo para estar sobreescribiendo
                historialClinico hc = new historialClinico();
                hc.lblId.Text = dt.Rows[i]["idHistorial"].ToString();
                hc.lblNombre.Text = dt.Rows[i]["nombreHistorial"].ToString();
                //Agregar el control (comentario)
                flpHistoriales.Controls.Add(hc);
                GC.Collect();
            }
        }
    }
}
