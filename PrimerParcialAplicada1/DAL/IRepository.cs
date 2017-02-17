using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace PrimerParcialAplicada1.DAL
{
    interface IRepository <TEntity> : IDisposable where TEntity : class
    {
        TEntity Guardar(TEntity nuevo);
        TEntity Modificar(TEntity modificado);
        bool Eliminar(TEntity id);
        TEntity Buscar(Expression<Func<TEntity, bool>> id);
        List<TEntity> GetList();
        List<TEntity> GetListNombres(Expression<Func<TEntity, bool>> nombres);
        List<TEntity> GetListFechas(Expression<Func<TEntity, bool>> fechas);
        List<TEntity> GetListNombresFechas(Expression<Func<TEntity, bool>> sentencia);
    }
}
