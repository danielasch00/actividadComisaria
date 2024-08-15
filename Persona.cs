using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Persona
    {
        readonly int dni;
        readonly string nombre;

        public int Dni { get {return dni;} }
        public string Nombre { get { return nombre; } }

        public Persona(int dni, string nombre)
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public string VerDatos()
        {
            string respuesta = this.nombre + " " + this.dni;
            return respuesta;
        }
    }
}
