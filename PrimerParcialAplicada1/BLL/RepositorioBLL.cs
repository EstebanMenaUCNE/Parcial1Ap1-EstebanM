using PrimerParcialAplicada1.DAL;
using PrimerParcialAplicada1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimerParcialAplicada1.BLL
{
    public class RepositorioBLL
    {
        public static bool Guardar(Empleado empleado)
        {
            using (var con = new Repositorio<Empleado>())
            {
                return con.Guardar(empleado) != null;
            }
        }

        public static bool Eliminar(Empleado empleado)
        {
            using (var con = new Repositorio<Empleado>())
            {
                return con.Eliminar(empleado);
            }
        }
        
    }
}
