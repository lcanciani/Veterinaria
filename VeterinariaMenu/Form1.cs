﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinariaMenu
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void menuStrip1_ItemClicked(object sebnder, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Veterinaria";
            lblhora.Text = DateTime.Today.ToString();
            this.BackColor = Color.Coral;
        }

        private void colorOscuroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void negroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void azulMarinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.BlanchedAlmond;
        }

        private void verdeOscuroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void blancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
        }

        private void azulClaroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.BlueViolet;
        }

        private void verdeAguaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LimeGreen;
        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMascota mta = new FrmMascota();
            mta.ShowDialog();
        }

        private void veterinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVeterinario vto = new FrmVeterinario();
            vto.ShowDialog();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmpleados emp = new FormEmpleados();
            emp.ShowDialog();
        }

        private void contactosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://Facebook.com");
        }

        private void lblhora_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro quiere salir?", "SALIENDO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void gatitoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void perritoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void caballitioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Aqua;
        }

        private void verTurnosAgendadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTurnos trn = new FrmTurnos();
            trn.ShowDialog();
        }

        private void veterinarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReporteVeterinarios reporte = new ReporteVeterinarios();
            reporte.ShowDialog();
        }

        private void mascotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReporteMascotas reporteMascotas = new FormReporteMascotas();
            reporteMascotas.ShowDialog();
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
              
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro quiere salir?", "SALIENDO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
