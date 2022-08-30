using Actividad_3.Equipos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3.Jugadores
{
    internal class Portero : Jugador
    {
        private Equipo equipo;

        public Portero()
        {
        }

        public Portero(Equipo equipo)
        {
            this.equipo = equipo;
        }

        public override void Jugar() => Console.WriteLine("Encargado de cuidar el arco");
    }
}
