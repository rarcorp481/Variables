﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Variables.Formularios;

namespace Variables
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void edadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmArreglo frm = new FrmArreglo();
            frm.ShowDialog();
        }

        private void matrizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMatriz frm  = new FrmMatriz(); 
            frm.ShowDialog();
        }
    }
}
