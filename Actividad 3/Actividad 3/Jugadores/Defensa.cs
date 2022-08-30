using Actividad_3.Equipos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3.Jugadores
{
    internal class Defensa : Jugador
    {
        private Equipo equipo;

        public Defensa()
        {
        }

        public Defensa(Equipo equipo)
        {
            this.equipo = equipo;
        }

        public override void Jugar()
        {
            Console.WriteLine("Defiende el campo propio");
        }
    }
}
