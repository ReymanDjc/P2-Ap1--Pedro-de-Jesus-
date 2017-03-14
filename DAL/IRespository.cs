﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DAL
{
    public interface IRespository<TEntity> : IDisposable where TEntity : class
    {
        bool Guardar(TEntity laEntidad);
        bool Modificar(TEntity laEntidad);
        bool Eliminar(TEntity laEntidad);
        TEntity Buscar(Expression<Func<TEntity, bool>> criterioBusqueda);
        List<TEntity> GetList(Expression<Func<TEntity, bool>> criterioBusqueda);
        List<TEntity> GetListAll();
    }
}
