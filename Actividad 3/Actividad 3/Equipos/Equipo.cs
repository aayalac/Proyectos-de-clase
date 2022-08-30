using Actividad_3.CuerpoTecnico;
using Actividad_3.Jugadores;
using Actividad_3.Miembros;

namespace Actividad_3.Equipos
{
    internal class Equipo
    {
        private ICuerpoTecnico CuerpoTecnico;
        private ICuerpoTecnico Miembros;
        private Jugador Portero;
        private Jugador Defensa;
        private Jugador Mediocampista;
        private Jugador Delantero;        

        public Equipo(ICuerpoTecnico cuerpoTecnico, ICuerpoTecnico cuerpoTecnico1)
        {
            CuerpoTecnico = cuerpoTecnico;

            //composición:

            this.Portero = new Portero();
            this.Defensa = new Defensa();
            this.Mediocampista = new Mediocampista();
            this.Delantero = new Delantero();
        }
    }
}