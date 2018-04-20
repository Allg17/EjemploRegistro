using Ejemplo.Entidad;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Persona> People { get; set; }

        public Contexto() : base("ConStr")
        {
        }
    }
}
