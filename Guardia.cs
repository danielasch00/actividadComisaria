using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Guardia
    {
        readonly int horaDesde, minutoDesde, horaHasta, minutoHasta, cantidadMinutos;

        public int HoraDesde { get { return horaDesde; } }
        public int MinutoDesde { get { return minutoDesde; } }
        public int HoraHasta { get { return horaHasta; } }
        public int MinutoHasta { get { return minutoHasta; } }
        public int CantidadMinutos { get { return cantidadMinutos; } }

        public Guardia()
        {

        }

        public void AsignarPolicia(Policia policia, int hora, int minutos, int cantidadMinutos)
        {

        }

    }
}
