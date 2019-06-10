using System;
using System.Data.Entity;
using RegistroEjemplos.Entidades;

namespace RegistroEjemplos.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Persona> Persona { get; set; }
        public object Personas { get; internal set; }

        public Contexto() : base("ConStr")
        { }

       
    }

   
}
