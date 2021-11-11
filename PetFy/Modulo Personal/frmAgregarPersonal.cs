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
    public partial class frmAgregarPersonal : Form
    {
        public frmAgregarPersonal()
        {
            InitializeComponent();
        }
        Consultas consulta = new Consultas();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            consulta.cmd.Connection = consulta.cn;
            MemoryStream ms = new MemoryStream();
            //
            consulta.cmd.CommandText = "INSERT INTO personal VALUES('"+txtNombre.Text+"','"+txtDireccion.Text+"','"+txtNumero.Text+"','@portada');";
            pbFoto.Image.Save(ms, ImageFormat.Jpeg);
            consulta.cmd.Parameters.Add(new SqlParameter("@portada", ms.GetBuffer()));
            consulta.cn.Open();
            consulta.cmd.ExecuteNonQuery();
            consulta.cn.Close();
        }

        private void cmdAdjuntar_Click(object sender, EventArgs e)
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
