using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class EmpleadosRetencionesBLL
    {
        public class EmpleadosDescuentosBLL
        {
            public static bool Guardar(Entidades.EmpleadosRetenciones relacion)
            {
                using (var conec = new DAL.Respository<Entidades.EmpleadosRetenciones>())
                {
                    try
                    {
                        return conec.Guardar(relacion);
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }

                return false;
            }

            public static bool Guardar(List<Entidades.EmpleadosRetenciones> lista)
            {
                try
                {
                    foreach (var relacion in lista)
                    {
                        Guardar(relacion);
                    }

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
}
