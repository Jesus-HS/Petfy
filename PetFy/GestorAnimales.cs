﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetFy
{
    public partial class frmGestor : Form
    {
        public frmGestor()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarAnimal frmAgregarAnimal = new frmAgregarAnimal();
            frmAgregarAnimal.Show();
        }
    }
}
