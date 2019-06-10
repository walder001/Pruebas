using RegistroEjemplos.DAL;
using RegistroEjemplos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace RegistroEjemplos.BILL
{
    public class PersonaBILL
    {


        public static bool Guardar(Persona persona)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Persona.Add(persona) != null)
                    paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }


        
        public static bool Modificar(Persona persona)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                //buscar las entidades que no estan para removerlas
                var Anterior = db.Persona.Find(persona.PersonaId);
            
                db.Entry(persona).State = EntityState.Modified;
                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }
       
        public static bool Eliminar(int id)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {

                Persona persona = contexto.Persona.Find(id);
                contexto.Persona.Remove(persona);
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static Persona Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Persona persona = new Persona();
            try
            {

                persona = contexto.Persona.Find(id);
                
            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                contexto.Dispose();
            }
            return persona;
        }

        public static List<Persona> GetList(Expression<Func<Persona, bool>> persona)
        {
            List<Persona> Lista = new List<Persona>();
            Contexto contexto = new Contexto();
            try
            {
                Lista = contexto.Persona.Where(persona).ToList();
            }
            catch
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return Lista;

        }
        
    }
}
