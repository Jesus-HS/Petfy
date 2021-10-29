using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace PetFy
{
    public partial class frmGestor : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, 
            int nTopRect, 
            int nRightRect, 
            int nBottomRect, 
            int nWidthEllipse, 
            int nHeightEllipse
        );
        public frmGestor()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarAnimal frmAgregarAnimal = new frmAgregarAnimal();
            frmAgregarAnimal.Show();
        }

        private void frmGestor_Load(object sender, EventArgs e)
        {
            Animal animal = new Animal();
            animal.Size = new Size(184, 294);
            animal.Margin = new Padding(10, 10, 0, 0);
            flpAnimales.Controls.Add(animal);
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {

        }
    }
}
