using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace PrimerParcialAplicada1.Entidades
{
    public class Empleado
    {
        [Key]
        public int EmpleadoId { get; set; }
        public string Nombres { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public float Sueldo { get; set; }

        public Empleado()
        {

        }

        public Empleado(int empleadoId, string nombres, DateTime fechaNacimiento, float sueldo )
        {
            EmpleadoId = empleadoId;
            Nombres = nombres;
            FechaNacimiento = fechaNacimiento;
            Sueldo = sueldo;
        }
    }
}
