
namespace PetFy
{
    partial class frmGestor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestor));
            this.flpGestor = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnGestorAnimales = new System.Windows.Forms.Button();
            this.btnGestorHistorialClinico = new System.Windows.Forms.Button();
            this.btnGestorPersonal = new System.Windows.Forms.Button();
            this.btnGestorAlmacen = new System.Windows.Forms.Button();
            this.btnGestorAdopciones = new System.Windows.Forms.Button();
            this.btnGestorUsuarios = new System.Windows.Forms.Button();
            this.panelInteraccion = new System.Windows.Forms.Panel();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panelInteraccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpGestor
            // 
            this.flpGestor.AutoScroll = true;
            this.flpGestor.Location = new System.Drawing.Point(188, 72);
            this.flpGestor.Name = "flpGestor";
            this.flpGestor.Size = new System.Drawing.Size(586, 517);
            this.flpGestor.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTitulo.Location = new System.Drawing.Point(352, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(120, 17);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Titulo del modulo";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(288, 45);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(272, 20);
            this.txtBuscar.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(566, 43);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(3, 474);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(40, 40);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnGestorAnimales
            // 
            this.btnGestorAnimales.Location = new System.Drawing.Point(12, 72);
            this.btnGestorAnimales.Name = "btnGestorAnimales";
            this.btnGestorAnimales.Size = new System.Drawing.Size(170, 48);
            this.btnGestorAnimales.TabIndex = 7;
            this.btnGestorAnimales.Text = "Animales";
            this.btnGestorAnimales.UseVisualStyleBackColor = true;
            this.btnGestorAnimales.Click += new System.EventHandler(this.btnGestorAnimales_Click);
            // 
            // btnGestorHistorialClinico
            // 
            this.btnGestorHistorialClinico.Location = new System.Drawing.Point(12, 126);
            this.btnGestorHistorialClinico.Name = "btnGestorHistorialClinico";
            this.btnGestorHistorialClinico.Size = new System.Drawing.Size(170, 48);
            this.btnGestorHistorialClinico.TabIndex = 8;
            this.btnGestorHistorialClinico.Text = "Historial Clinico";
            this.btnGestorHistorialClinico.UseVisualStyleBackColor = true;
            this.btnGestorHistorialClinico.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnGestorPersonal
            // 
            this.btnGestorPersonal.Location = new System.Drawing.Point(12, 180);
            this.btnGestorPersonal.Name = "btnGestorPersonal";
            this.btnGestorPersonal.Size = new System.Drawing.Size(170, 48);
            this.btnGestorPersonal.TabIndex = 9;
            this.btnGestorPersonal.Text = "Personal";
            this.btnGestorPersonal.UseVisualStyleBackColor = true;
            this.btnGestorPersonal.Click += new System.EventHandler(this.btnPersonal_Click_1);
            // 
            // btnGestorAlmacen
            // 
            this.btnGestorAlmacen.Location = new System.Drawing.Point(12, 234);
            this.btnGestorAlmacen.Name = "btnGestorAlmacen";
            this.btnGestorAlmacen.Size = new System.Drawing.Size(170, 48);
            this.btnGestorAlmacen.TabIndex = 10;
            this.btnGestorAlmacen.Text = "Almacen";
            this.btnGestorAlmacen.UseVisualStyleBackColor = true;
            this.btnGestorAlmacen.Click += new System.EventHandler(this.btnGestorAlmacen_Click);
            // 
            // btnGestorAdopciones
            // 
            this.btnGestorAdopciones.Location = new System.Drawing.Point(12, 288);
            this.btnGestorAdopciones.Name = "btnGestorAdopciones";
            this.btnGestorAdopciones.Size = new System.Drawing.Size(170, 48);
            this.btnGestorAdopciones.TabIndex = 11;
            this.btnGestorAdopciones.Text = "Adopciones";
            this.btnGestorAdopciones.UseVisualStyleBackColor = true;
            this.btnGestorAdopciones.Click += new System.EventHandler(this.btnGestorAdopciones_Click);
            // 
            // btnGestorUsuarios
            // 
            this.btnGestorUsuarios.Location = new System.Drawing.Point(12, 342);
            this.btnGestorUsuarios.Name = "btnGestorUsuarios";
            this.btnGestorUsuarios.Size = new System.Drawing.Size(170, 48);
            this.btnGestorUsuarios.TabIndex = 12;
            this.btnGestorUsuarios.Text = "Usuarios";
            this.btnGestorUsuarios.UseVisualStyleBackColor = true;
            this.btnGestorUsuarios.Click += new System.EventHandler(this.btnRegistrousuarios_Click);
            // 
            // panelInteraccion
            // 
            this.panelInteraccion.Controls.Add(this.btnModificar);
            this.panelInteraccion.Controls.Add(this.btnEliminar);
            this.panelInteraccion.Controls.Add(this.btnAgregar);
            this.panelInteraccion.Location = new System.Drawing.Point(774, 72);
            this.panelInteraccion.Name = "panelInteraccion";
            this.panelInteraccion.Size = new System.Drawing.Size(46, 517);
            this.panelInteraccion.TabIndex = 0;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(3, 356);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(40, 40);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "e";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(3, 402);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(40, 40);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "-";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmGestor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(842, 640);
            this.Controls.Add(this.panelInteraccion);
            this.Controls.Add(this.btnGestorUsuarios);
            this.Controls.Add(this.btnGestorAdopciones);
            this.Controls.Add(this.btnGestorAlmacen);
            this.Controls.Add(this.btnGestorPersonal);
            this.Controls.Add(this.btnGestorHistorialClinico);
            this.Controls.Add(this.btnGestorAnimales);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.flpGestor);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestor";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(255)))), ((int)(((byte)(9)))));
            this.Load += new System.EventHandler(this.frmGestor_Load);
            this.panelInteraccion.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpGestor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnGestorAnimales;
        private System.Windows.Forms.Button btnGestorHistorialClinico;
        private System.Windows.Forms.Button btnGestorPersonal;
        private System.Windows.Forms.Button btnGestorAlmacen;
        private System.Windows.Forms.Button btnGestorAdopciones;
        private System.Windows.Forms.Button btnGestorUsuarios;
        private System.Windows.Forms.Panel panelInteraccion;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
    }
}