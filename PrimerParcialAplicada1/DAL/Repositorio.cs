using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace PrimerParcialAplicada1.DAL
{
    public class Repositorio<TEntity> : IRepository<TEntity> where TEntity : class
    {
        ParcialDb context = null;

        public Repositorio()
        {
            context = new ParcialDb();
        }

        public DbSet<TEntity> EntitySet
        {
            get
            {
                return context.Set<TEntity>();
            }
        }

        public TEntity Guardar(TEntity nuevo)
        {
            try
            {
                EntitySet.Add(nuevo);
                context.SaveChanges();
                return nuevo;
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        public TEntity Modificar(TEntity modificado)
        {
            try
            {
                EntitySet.Attach(modificado);
                context.Entry(modificado).State = EntityState.Modified;
                context.SaveChanges();
                return modificado;
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        public TEntity Buscar(Expression<Func<TEntity, bool>> id)
        {
            try
            {
                return EntitySet.FirstOrDefault(id);
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
        
        public bool Eliminar(TEntity id)
        {
            try
            {
                    EntitySet.Attach(id);
                    EntitySet.Remove(id);
                    return context.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public List<TEntity> GetList()
        {
            try
            {
                return EntitySet.ToList();
            }
            catch (Exception)
            {
                return new List<TEntity>();
                throw;
            }
        }

        public List<TEntity> GetListFechas(Expression<Func<TEntity, bool>> fechas)
        {
            try
            {
                return EntitySet.Where(fechas).ToList();
            }
            catch (Exception)
            {
                return new List<TEntity>();
                throw;
            }
        }

        public List<TEntity> GetListNombres(Expression<Func<TEntity, bool>> nombres)
        {
            try
            {
                return EntitySet.Where(nombres).ToList();
            }
            catch (Exception)
            {
                return new List<TEntity>();
                throw;
            }
        }

        public List<TEntity> GetListNombresFechas(Expression<Func<TEntity, bool>> sentencia)
        {
            try
            {
                return EntitySet.Where(sentencia).ToList();
            }
            catch (Exception)
            {
                return new List<TEntity>();
                throw;
            }
        }

        public void Dispose()
        {
            if (context != null)
            {
                context.Dispose();
            }
        }

    }
}
