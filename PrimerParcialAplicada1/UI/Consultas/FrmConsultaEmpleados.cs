using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrimerParcialAplicada1.UI.Consultas
{
    public partial class FrmConsultaEmpleados : Form
    {
        public FrmConsultaEmpleados()
        {
            InitializeComponent();
        }

        private void FiltrarButton_Click(object sender, EventArgs e)
        {
            if (NombresCheckBox.Checked && FechaCheckBox.Checked)
            {
                    EmpleadosDataGridView.DataSource = BLL.EmpleadoBLL.GetListNombresFechas(NombresTextBox.Text, DesdeDateTimePicker.Value, HastaDateTimePicker.Value);
            }
            else
            {
                if (NombresCheckBox.Checked)
                {
                    EmpleadosDataGridView.DataSource = BLL.EmpleadoBLL.GetListNombres(NombresTextBox.Text);
                }
                else
                {
                    if (FechaCheckBox.Checked)
                    {
                        EmpleadosDataGridView.DataSource = BLL.EmpleadoBLL.GetListFechas(DesdeDateTimePicker.Value, HastaDateTimePicker.Value);
                    }
                    else
                    {
                        EmpleadosDataGridView.DataSource = BLL.EmpleadoBLL.GetList();
                    }
                }
            }
            
        }
    }
}
