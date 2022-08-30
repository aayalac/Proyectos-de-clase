using Actividad_3.Equipos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3.Jugadores
{
    internal class Delantero : Jugador
    {
        private Equipo equipo;
        public Delantero()
        {
        }

        public Delantero(Equipo equipo)
        {
            this.equipo = equipo;
        }
        public override void Jugar()
        {
            Console.WriteLine("Encargado de la ofensiva del equipo");
        }        
    }
}
