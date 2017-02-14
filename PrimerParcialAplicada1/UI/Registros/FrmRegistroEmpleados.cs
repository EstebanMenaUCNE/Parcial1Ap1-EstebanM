using PrimerParcialAplicada1.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrimerParcialAplicada1.UI.Registros
{
    public partial class FrmRegistroEmpleados : Form
    {
        public FrmRegistroEmpleados()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            empleadoIdTextBox.Clear();
            nombresTextBox.Clear();
            fechaNacimientoDateTimePicker.Value = DateTime.Today;
            sueldoTextBox.Clear();
            nombresTextBox.Focus();
        }

        private bool Validar()
        {
            bool retorno = true;
            if (string.IsNullOrWhiteSpace(nombresTextBox.Text))
            {
                NombresErrorProvider.SetError(nombresTextBox, "Por favor digite los nombres");
                retorno = false;
            }
            if (string.IsNullOrWhiteSpace(sueldoTextBox.Text))
            {
                NombresErrorProvider.SetError(sueldoTextBox, "Por favor digite el sueldo");
                retorno = false;
            }
            return retorno;
        }

        private void FrmRegistroEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if(Validar())
            {
                int id = 0;
                if (!string.IsNullOrWhiteSpace(empleadoIdTextBox.Text))
                    id = Utilidades.ToInt(empleadoIdTextBox.Text);
                float sueldo = 0;
                if (!string.IsNullOrWhiteSpace(sueldoTextBox.Text))
                    sueldo = Utilidades.ToFloat(sueldoTextBox.Text);

                if (BLL.EmpleadoBLL.Guardar(new Empleado(id, nombresTextBox.Text, fechaNacimientoDateTimePicker.Value, sueldo)))
                {
                    MessageBox.Show("Guardado con éxito!");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al guardar...");
                }
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(empleadoIdTextBox.Text))
            {
                if (BLL.EmpleadoBLL.Eliminar(Convert.ToInt32(empleadoIdTextBox.Text)))
                {
                    MessageBox.Show("Eliminado con éxito!");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al eliminar...");
                }
            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {

        }
    }
}
