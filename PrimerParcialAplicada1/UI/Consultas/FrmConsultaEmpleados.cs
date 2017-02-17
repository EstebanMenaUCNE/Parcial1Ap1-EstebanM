using PrimerParcialAplicada1.DAL;
using PrimerParcialAplicada1.Entidades;
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
            using (var con = new Repositorio<Empleado>())
            {
                if (NombresCheckBox.Checked && FechaCheckBox.Checked)
                {
                    EmpleadosDataGridView.DataSource = con.GetListNombresFechas(E => E.Nombres == NombresTextBox.Text && E.FechaNacimiento > DesdeDateTimePicker.Value && E.FechaNacimiento < HastaDateTimePicker.Value);
                }
                else
                {
                    if (NombresCheckBox.Checked)
                    {
                        EmpleadosDataGridView.DataSource = con.GetListNombres(E => E.Nombres == NombresTextBox.Text);
                    }
                    else
                    {
                        if (FechaCheckBox.Checked)
                        {
                            EmpleadosDataGridView.DataSource = con.GetListFechas(E => E.FechaNacimiento > DesdeDateTimePicker.Value && E.FechaNacimiento < HastaDateTimePicker.Value);
                        }
                        else
                        {
                            EmpleadosDataGridView.DataSource = con.GetList();
                        }
                    }
                }
            }
            
        }
    }
}
