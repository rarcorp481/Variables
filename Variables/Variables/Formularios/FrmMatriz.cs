﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Variables.Modelos;

namespace Variables.Formularios
{
    public partial class FrmMatriz : Form
    {
        Matriz mc = new Matriz();
        public FrmMatriz()
        {
            InitializeComponent();
        
        }

        private void FrmMatriz_Load(object sender, EventArgs e)
        {

        }

        private void dgvMatriz_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gbMatriz_Enter(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int dato = int.Parse(tbNumero.Text);
            mc.Agregar(dato);

            dgvMatriz.DataSource = null;
            dgvMatriz.DataSource = mc.getMatrizC();
            dgvMatriz.Refresh();
            MessageBox.Show("Agregado.");
        }
    }
}
