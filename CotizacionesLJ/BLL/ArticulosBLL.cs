using CotizacionesLJ.DAL;
using CotizacionesLJ.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace CotizacionesLJ.BLL
{
    public class ArticulosBLL
    {
        public static bool Guardar(Articulos a)
        {
            bool paso = false;
            try
            {
                Contexto Contex = new Contexto();
                Contex.Articulo.Add(a);
                Contex.SaveChanges();
                paso = true;
            }
            catch (Exception e)
            {
                throw e;
            }
            return paso;
        }

        public static bool Modificar(Articulos a)
        {
            bool paso = false;

            try
            {
                Contexto contex = new Contexto();

                contex.Entry(a).State = EntityState.Modified;
                if (contex.SaveChanges() > 0)
                {
                    paso = true;
                }

            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public static bool Eliminar(int estudianteID)
        {
            bool paso = false;

            try
            {
                Contexto contex = new Contexto();

                var estudiante = contex.Articulo.Find(estudianteID);

                contex.Articulo.Remove(estudiante);
                contex.SaveChanges();

                paso = true;
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public static Articulos Buscar(int EstudianteId)
        {
            Articulos estudiante = new Articulos();

            try
            {
                Contexto contex = new Contexto();
                estudiante = contex.Articulo.Find(EstudianteId);
            }
            catch (Exception)
            {
                throw;
            }

            return estudiante;
        }

        public static List<Articulos> GetList(Expression<Func<Articulos, bool>> criterioBusqueda)
        {
            List<Articulos> estudiante = new List<Articulos>();
            try
            {
                Contexto contex = new Contexto();
                estudiante = contex.Articulo.Where(criterioBusqueda).ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return estudiante;
        }
    }
}
