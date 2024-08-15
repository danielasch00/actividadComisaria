using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Incidente
    {
        readonly string motivo;
        readonly int hora, minutos, tipoIncidente;
        
        public string Motivo {  get { return motivo; } }
        public int Hora { get { return hora; } }
        public int Minutos { get { return minutos; } }
        public int TipoIncidente { get { return tipoIncidente; } }

        public Incidente(Policia oficial, string sujeto, int tipoIncidente, string motivo)
        {
           
        }
    }
}
