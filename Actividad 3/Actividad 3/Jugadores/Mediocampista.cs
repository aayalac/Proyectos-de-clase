using Actividad_3.Equipos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3.Jugadores
{
    internal class Mediocampista : Jugador
    {
        private Equipo equipo;

        public Mediocampista()
        {
        }

        public Mediocampista(Equipo equipo)
        {
            this.equipo = equipo;
        }

        public override void Jugar()
        {
            Console.WriteLine("Juega en mitad de la cancha");
            Console.WriteLine("Asiste a delanteros");
        }
    }
}
