using RegistrodeLibrosBiblicos.DAL;
using RegistrodeLibrosBiblicos.ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace RegistrodeLibrosBiblicos.BLL
{
    public class LibrosBiblicosBLL
    {

        public static bool Guardar(LibrosBiblicos librosBiblicos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {

                if (contexto.Libros.Add(librosBiblicos) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();

            }
            catch (Exception) { throw; }

            return paso;
        }


        public static bool Eliminar(int id)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                LibrosBiblicos librosBiblicos = contexto.Libros.Find(id);

                if (librosBiblicos != null)
                {
                    contexto.Entry(librosBiblicos).State = EntityState.Deleted;
                }
                

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                    contexto.Dispose();
                }


            }
            catch (Exception) { throw; }

            return paso;
        }



        public static bool Editar(LibrosBiblicos librosBiblicos)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {


                contexto.Entry(librosBiblicos).State = EntityState.Modified;

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();

            }
            catch (Exception) { throw; }

            return paso;
        }



        public static LibrosBiblicos Buscar(int id)
        {

            LibrosBiblicos librosBiblicos = new LibrosBiblicos();
            Contexto contexto = new Contexto();

            try
            {
                librosBiblicos = contexto.Libros.Find(id);
                contexto.Dispose();
            }
            catch (Exception) { throw; }
            return librosBiblicos;

        }



        public static List<LibrosBiblicos> GetList(Expression<Func<LibrosBiblicos, bool>> expression)
        {
            List<LibrosBiblicos> librosBiblicos = new List<LibrosBiblicos>();
            Contexto contexto = new Contexto();

            try
            {
               librosBiblicos  = contexto.Libros.Where(expression).ToList();
                contexto.Dispose();

            }
            catch (Exception) { throw; }
            return librosBiblicos;
        }
    }
}
