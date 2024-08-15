using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Policia
    {
        readonly int dni;
        readonly string nombre;
        readonly int nroPlaca;

        public int Dni { get { return dni; } }
        public string Nombre { get { return nombre; } }
        public int NroPlaca { get { return nroPlaca; } }

        public Policia(int dni, string nombre, int nroPlaca)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.nroPlaca = nroPlaca;
        }

        public string VerDatos()
        {
            string respuesta = this.nombre + " " + this.dni;
            return respuesta;
        }
    }
}
