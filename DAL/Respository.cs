﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DAL
{
    public class Respository<TEntity> : IRespository<TEntity> where TEntity : class
    {

        DAL.ParcialDb Context = null;

        public Respository()
        {
            Context = new ParcialDb();
        }

        private DbSet<TEntity> EntitySet
        {
            get
            {
                return Context.Set<TEntity>();
            }
        }



        public TEntity Buscar(Expression<Func<TEntity, bool>> criterioBusqueda)
        {
            try
            {
                return EntitySet.FirstOrDefault(criterioBusqueda);
            }
            catch (Exception)
            {

                throw;
            }
        }





        public void Dispose()
        {
            if (Context != null)
            {
                Context.Dispose();
            }
        }





        public bool Eliminar(TEntity laEntidad)
        {
            try
            {
                EntitySet.Attach(laEntidad);
                EntitySet.Remove(laEntidad);
                return Context.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
        }




        public List<TEntity> GetList(Expression<Func<TEntity, bool>> criterioBusqueda)
        {
            try
            {
                return EntitySet.Where(criterioBusqueda).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }





        public List<TEntity> GetListAll()
        {
            try
            {
                return EntitySet.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }




        public bool Guardar(TEntity laEntidad)
        {
            try
            {
                EntitySet.Add(laEntidad);
                Context.SaveChanges();
                return true;

            }
            catch (Exception)
            {

                throw;
            }

            return false;
        }




        public bool Modificar(TEntity laEntidad)
        {
            try
            {
                EntitySet.Attach(laEntidad);
                Context.Entry(laEntidad).State = EntityState.Modified;
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }

            return false;
        }



    }
}
