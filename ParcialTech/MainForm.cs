using ParcialTech.Consultas;
using ParcialTech.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ParcialTech
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tiposEmailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TiposEmailsRegistroForm().Show();
        }

        private void retencionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RetencionesRegistroForm().Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EmpleadosRegistroForm().Show();
        }

        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new EmpleadosConsultaForm().Show();
        }
    }
}
