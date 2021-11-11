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
            consultas.cmd.Connection = consultas.cn;
            MemoryStream ms = new MemoryStream();
            DataTable dt;
            string genero = "", idTipo = "", idRaza = "";

            dt = consultas.obtenerTabla("SELECT idTipo FROM tipos WHERE nombreTipo = '" + cbTipo.Text + "'");
            idTipo = dt.Rows[0]["idTipo"].ToString().Trim();
            dt = consultas.obtenerTabla("SELECT idRaza FROM razas WHERE nombreRaza = '" + cbRaza.Text + "'");
            idRaza = dt.Rows[0]["idRaza"].ToString().Trim();

            if (rbMacho.Checked)
                genero = "1";
            else if (rbHembra.Checked)
                genero = "0";

            //                                                               NOMBRE                       Caracteristicas               Genero      Fecha      FOTO         Raza            Tipo        Historial
            consultas.cmd.CommandText = "INSERT INTO animales VALUES('" + txtNombre.Text + "'," + "'" + rtCaracteristicas.Text + "'," + genero + ", GETDATE(), @portada, " + idRaza + ", " + idTipo + ", NULL);";
            pbFoto.Image.Save(ms, ImageFormat.Jpeg);
            consultas.cmd.Parameters.Add(new SqlParameter("@portada", ms.GetBuffer()));
            consultas.cn.Open();
            consultas.cmd.ExecuteNonQuery();
            consultas.cn.Close();
        }

        private void btnAdjuntar_Click(object sender, EventArgs e)
        {
            //textodeformato(*.formato) | *.formato | otroformato(*.formato2 *) | *.formato2
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "C:\\";
            ofd.Filter = "Archivos jpg(*.jpg)|*.jpg| Archivos png(*.png)|*.png";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbFoto.Image = Image.FromFile(ofd.FileName);
            }
        }
    }
}
