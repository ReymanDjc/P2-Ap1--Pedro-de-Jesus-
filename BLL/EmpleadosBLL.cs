using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL
{
    public class EmpleadosBLL
    {
        public static bool Guardar(Entidades.Empleados empleado)
        {
            using (var conec = new DAL.ParcialDb())
            {
                try
                {

                    conec.Empleado.Add(empleado);

                    foreach (var g in empleado.Retenciones)
                    {
                        conec.Entry(g).State = System.Data.Entity.EntityState.Unchanged;
                    }

                    conec.SaveChanges();
                    return true;
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return false;
        }

        public static bool Eliminar(Entidades.Empleados empleado)
        {
            using (var conec = new DAL.Respository<Entidades.Empleados>())
            {
                try
                {
                    return conec.Eliminar(empleado);
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return false;
        }

        public static bool Modificar(Entidades.Empleados empleado)
        {
            using (var conec = new DAL.Respository<Entidades.Empleados>())
            {
                try
                {
                    return conec.Modificar(empleado);
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return false;
        }

        public static Entidades.Empleados Buscar(Expression<Func<Entidades.Empleados, bool>> criterio)
        {
            var empleado = new Entidades.Empleados();

            using (var conec = new DAL.Respository<Entidades.Empleados>())
            {
                try
                {
                    empleado = conec.Buscar(criterio);

                    if (empleado != null)
                    {
                        empleado.Retenciones.Count();
                        empleado.Relacion.Count();
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return empleado;
        }

        public static List<Entidades.Empleados> GetList(Expression<Func<Entidades.Empleados, bool>> criterio)
        {
            using (var conec = new DAL.Respository<Entidades.Empleados>())
            {
                try
                {
                    return conec.GetList(criterio);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static List<Entidades.Empleados> GetListAll()
        {
            using (var conec = new DAL.Respository<Entidades.Empleados>())
            {
                try
                {
                    return conec.GetListAll();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
