using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3.Jugadores
{
    internal abstract class Jugador
    {
        public void Entrenar()
        {
            Console.WriteLine("Miembro del equipo");
        }
        public abstract void Jugar();
    }
}
