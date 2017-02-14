using PrimerParcialAplicada1.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace PrimerParcialAplicada1.DAL
{
    public class ParcialDb : DbContext
    {
        public DbSet<Empleado> Empleados { get; set; }

        public ParcialDb() : base("ConStr")
        {

        }

    }
}
