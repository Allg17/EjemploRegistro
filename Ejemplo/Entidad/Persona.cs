using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo.Entidad
{
    public class Persona
    {
        [Key]
        public int IdPersona { get; set; }
        public string Direccion { get; set; }
        public string  Cedula { get; set; }
        public string  Telefono { get; set; }
        public string  Nombre { get; set; }

        public Persona(int idPersona, string direccion, string cedula, string telefono, string nombre)
        {
            IdPersona = idPersona;
            Direccion = direccion;
            Cedula = cedula;
            Telefono = telefono;
            Nombre = nombre;
        }

        public Persona()
        {
            IdPersona = 0;
            Direccion = string.Empty;
            Cedula = string.Empty;
            Telefono = string.Empty;
            Nombre = string.Empty;
        }
    }
}
