using Ejemplo.DAL;
using Ejemplo.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo.BLL
{
    public class PersonaBLL
    {
        public static bool Guardar(Persona persona)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if(db.People.Add(persona)!=null)
                {
                    db.SaveChanges();
                    paso = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
            db.Dispose();
            return paso;
        }

        public static bool Eliminar(int id)
        {
            Contexto db = new Contexto();
            bool paso = false;
            try
            {
                var eliminar = db.People.Find(id);
                if(eliminar!=null)
                {
                    
                    db.People.Remove(eliminar);
                    db.SaveChanges();
                    paso = true;
                    
                }

            }
            catch (Exception)
            {

                throw;
            }
            db.Dispose();
            return paso;
        }

        public static bool Modificar(Persona persona)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(persona).State = System.Data.Entity.EntityState.Modified;
                if (db.SaveChanges()>0)
                {
                    paso = true;
                }
               
            }
            catch (Exception)
            {

                throw;
            }
            db.Dispose();
            return paso;
        }

        public static Persona Buscar(int id)
        {
            Contexto db = new Contexto();
            Persona persona = new Persona();
            try
            {
                persona = db.People.Find(id);
            }
            catch (Exception)
            {

                throw;
            }

            return persona;
        }

        public static List<Persona> GetList(Expression<Func<Persona, bool >> persona)
        {
            Contexto db = new Contexto();
            List<Persona> people = new List<Persona>();

            try
            {
                people = db.People.Where(persona).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return people;
        }
    }
}
