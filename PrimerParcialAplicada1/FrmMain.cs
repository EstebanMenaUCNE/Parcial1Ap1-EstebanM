using PrimerParcialAplicada1.UI.Consultas;
using PrimerParcialAplicada1.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrimerParcialAplicada1
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmRegistroEmpleados().Show();
        }

        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FrmConsultaEmpleados().Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
