using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    internal class Comisaria
    {
        ArrayList agentes = new ArrayList();

        readonly int cantidadIncidentes;
        public int CantidadIncidentes { get { return cantidadIncidentes; } }
        public Comisaria() { }

        public bool AsignarPolicia(Policia agente)
        {
            if (agentes.Count < 2)
            {
                agentes.Add(agente);
                return true;
            }
            return false;
        }

        public Policia VerAgente()
        {
            return;
        }

        public void RegistrarIncidente(Policia agente, Persona sujeto, string motivo, int hora, int minutos)
        {

        }

        public void AsignarGuardia(int numero, int hora1, int minutos1, int tiempoMinutos, Policia agente)
        {

        }

        public Incidente VerIncidente(int idx)
        {
            return;
        }

    }
}
