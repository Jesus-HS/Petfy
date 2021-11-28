namespace PetFy
{
    partial class frmDependencias
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
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRango = new System.Windows.Forms.TextBox();
            this.rbTipo = new System.Windows.Forms.RadioButton();
            this.rbRaza = new System.Windows.Forms.RadioButton();
            this.rbRango = new System.Windows.Forms.RadioButton();
            this.btnSubir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(12, 29);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(100, 20);
            this.txtTipo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de animal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Raza de Animal:";
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(12, 75);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(100, 20);
            this.txtRaza.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rango:";
            // 
            // txtRango
            // 
            this.txtRango.Location = new System.Drawing.Point(12, 124);
            this.txtRango.Name = "txtRango";
            this.txtRango.Size = new System.Drawing.Size(100, 20);
            this.txtRango.TabIndex = 4;
            // 
            // rbTipo
            // 
            this.rbTipo.AutoSize = true;
            this.rbTipo.Location = new System.Drawing.Point(124, 32);
            this.rbTipo.Name = "rbTipo";
            this.rbTipo.Size = new System.Drawing.Size(14, 13);
            this.rbTipo.TabIndex = 6;
            this.rbTipo.TabStop = true;
            this.rbTipo.UseVisualStyleBackColor = true;
            // 
            // rbRaza
            // 
            this.rbRaza.AutoSize = true;
            this.rbRaza.Location = new System.Drawing.Point(124, 82);
            this.rbRaza.Name = "rbRaza";
            this.rbRaza.Size = new System.Drawing.Size(14, 13);
            this.rbRaza.TabIndex = 7;
            this.rbRaza.TabStop = true;
            this.rbRaza.UseVisualStyleBackColor = true;
            // 
            // rbRango
            // 
            this.rbRango.AutoSize = true;
            this.rbRango.Location = new System.Drawing.Point(124, 131);
            this.rbRango.Name = "rbRango";
            this.rbRango.Size = new System.Drawing.Size(14, 13);
            this.rbRango.TabIndex = 8;
            this.rbRango.TabStop = true;
            this.rbRango.UseVisualStyleBackColor = true;
            // 
            // btnSubir
            // 
            this.btnSubir.Location = new System.Drawing.Point(12, 163);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(138, 26);
            this.btnSubir.TabIndex = 9;
            this.btnSubir.Text = "Subir";
            this.btnSubir.UseVisualStyleBackColor = true;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // frmDependencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(164, 201);
            this.Controls.Add(this.btnSubir);
            this.Controls.Add(this.rbRango);
            this.Controls.Add(this.rbRaza);
            this.Controls.Add(this.rbTipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRango);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRaza);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTipo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDependencias";
            this.Text = "Dependencias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRaza;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRango;
        private System.Windows.Forms.RadioButton rbTipo;
        private System.Windows.Forms.RadioButton rbRaza;
        private System.Windows.Forms.RadioButton rbRango;
        private System.Windows.Forms.Button btnSubir;
    }
}