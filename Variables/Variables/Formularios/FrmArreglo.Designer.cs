namespace Variables.Formularios
{
    partial class FrmArreglo
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
            this.gbEdades = new System.Windows.Forms.GroupBox();
            this.lblMenor = new System.Windows.Forms.Label();
            this.lblMayor = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lbEdades = new System.Windows.Forms.ListBox();
            this.tbEdad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMenoresEdad = new System.Windows.Forms.Label();
            this.lblMayoresEdad = new System.Windows.Forms.Label();
            this.gbEdades.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEdades
            // 
            this.gbEdades.Controls.Add(this.lblMayoresEdad);
            this.gbEdades.Controls.Add(this.lblMenoresEdad);
            this.gbEdades.Controls.Add(this.lblMenor);
            this.gbEdades.Controls.Add(this.lblMayor);
            this.gbEdades.Controls.Add(this.lblPromedio);
            this.gbEdades.Controls.Add(this.lbEdades);
            this.gbEdades.Controls.Add(this.tbEdad);
            this.gbEdades.Controls.Add(this.label1);
            this.gbEdades.Location = new System.Drawing.Point(24, 15);
            this.gbEdades.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbEdades.Name = "gbEdades";
            this.gbEdades.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbEdades.Size = new System.Drawing.Size(212, 576);
            this.gbEdades.TabIndex = 0;
            this.gbEdades.TabStop = false;
            this.gbEdades.Text = "Edades: 0";
            // 
            // lblMenor
            // 
            this.lblMenor.Location = new System.Drawing.Point(19, 424);
            this.lblMenor.Name = "lblMenor";
            this.lblMenor.Size = new System.Drawing.Size(174, 29);
            this.lblMenor.TabIndex = 5;
            this.lblMenor.Text = "Menor: 0";
            // 
            // lblMayor
            // 
            this.lblMayor.Location = new System.Drawing.Point(20, 382);
            this.lblMayor.Name = "lblMayor";
            this.lblMayor.Size = new System.Drawing.Size(174, 29);
            this.lblMayor.TabIndex = 4;
            this.lblMayor.Text = "Mayor: 0";
            // 
            // lblPromedio
            // 
            this.lblPromedio.Location = new System.Drawing.Point(20, 338);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(174, 29);
            this.lblPromedio.TabIndex = 3;
            this.lblPromedio.Text = "Promedio: 0";
            this.lblPromedio.Click += new System.EventHandler(this.lblPromedio_Click);
            // 
            // lbEdades
            // 
            this.lbEdades.FormattingEnabled = true;
            this.lbEdades.ItemHeight = 20;
            this.lbEdades.Location = new System.Drawing.Point(22, 95);
            this.lbEdades.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbEdades.Name = "lbEdades";
            this.lbEdades.Size = new System.Drawing.Size(172, 224);
            this.lbEdades.TabIndex = 2;
            // 
            // tbEdad
            // 
            this.tbEdad.Location = new System.Drawing.Point(22, 60);
            this.tbEdad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(174, 26);
            this.tbEdad.TabIndex = 1;
            this.tbEdad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbEdad_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la Edad";
            // 
            // lblMenoresEdad
            // 
            this.lblMenoresEdad.Location = new System.Drawing.Point(20, 465);
            this.lblMenoresEdad.Name = "lblMenoresEdad";
            this.lblMenoresEdad.Size = new System.Drawing.Size(174, 29);
            this.lblMenoresEdad.TabIndex = 6;
            this.lblMenoresEdad.Text = "Menores de edad: ";
            this.lblMenoresEdad.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblMayoresEdad
            // 
            this.lblMayoresEdad.Location = new System.Drawing.Point(20, 507);
            this.lblMayoresEdad.Name = "lblMayoresEdad";
            this.lblMayoresEdad.Size = new System.Drawing.Size(174, 29);
            this.lblMayoresEdad.TabIndex = 7;
            this.lblMayoresEdad.Text = "Mayores de edad: ";
            // 
            // FrmArreglo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 663);
            this.Controls.Add(this.gbEdades);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmArreglo";
            this.Text = "Arreglos";
            this.gbEdades.ResumeLayout(false);
            this.gbEdades.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEdades;
        private System.Windows.Forms.TextBox tbEdad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.ListBox lbEdades;
        private System.Windows.Forms.Label lblMayor;
        private System.Windows.Forms.Label lblMenor;
        private System.Windows.Forms.Label lblMayoresEdad;
        private System.Windows.Forms.Label lblMenoresEdad;
    }
}