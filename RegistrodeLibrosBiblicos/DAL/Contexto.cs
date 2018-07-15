using RegistrodeLibrosBiblicos.ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace RegistrodeLibrosBiblicos.DAL
{
    public class Contexto : DbContext
    {

        public DbSet<LibrosBiblicos> Libros{ get; set; }

        public Contexto() : base("ConStr")
        {
        }
    }
}
