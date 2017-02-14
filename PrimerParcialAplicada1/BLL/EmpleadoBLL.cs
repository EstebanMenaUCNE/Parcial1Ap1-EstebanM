using PrimerParcialAplicada1.DAL;
using PrimerParcialAplicada1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimerParcialAplicada1.BLL
{
    public class EmpleadoBLL
    {
        public static bool Guardar(Empleado empleado)
        {
            using (var db = new ParcialDb())
            {
                try
                {
                    if (Buscar(empleado.EmpleadoId) == null)
                    {
                        db.Empleados.Add(empleado);
                        db.SaveChanges();
                    }
                    else
                    {
                        db.Entry(empleado).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                    throw;
                }
            }
        }

        public static bool Eliminar(int id)
        {
            using (var db = new ParcialDb())
            {
                try
                {
                    db.Entry(Buscar(id)).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                    throw;
                }
            }
        }

        public static Empleado Buscar(int id)
        {
            using (var db = new ParcialDb())
            {
                try
                {
                    return db.Empleados.Find(id);
                }
                catch (Exception)
                {
                    return null;
                    throw;
                }
            }
        }

        public static List<Empleado> GetList()
        {
            using (var db = new ParcialDb())
            {
                try
                {
                    return db.Empleados.ToList();
                }
                catch (Exception)
                {
                    return new List<Empleado>();
                    throw;
                }
            }
        }
        public static List<Empleado> GetListNombres(string nombres)
        {
            using (var db = new ParcialDb())
            {
                try
                {
                    return db.Empleados.Where<Empleado>(P => P.Nombres == nombres).ToList();
                }
                catch (Exception)
                {
                    return new List<Empleado>();
                    throw;
                }
            }
        }

        public static List<Empleado> GetListFechas(DateTime desde, DateTime hasta)
        {
            using (var db = new ParcialDb())
            {
                try
                {
                    return db.Empleados.Where<Empleado>(P => P.FechaNacimiento >= desde && P.FechaNacimiento <= hasta).ToList();
                }
                catch (Exception)
                {
                    return new List<Empleado>();
                    throw;
                }
            }
        }

        public static List<Empleado> GetListNombresFechas(string nombres, DateTime desde, DateTime hasta)
        {
            using (var db = new ParcialDb())
            {
                try
                {
                    return db.Empleados.Where<Empleado>(P => P.Nombres == nombres).Where<Empleado>(P => P.FechaNacimiento >= desde && P.FechaNacimiento <= hasta).ToList();
                }
                catch (Exception)
                {
                    return new List<Empleado>();
                    throw;
                }
            }
        }
    }
}
