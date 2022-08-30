using Actividad_3;
using Actividad_3.CuerpoTecnico;
using Actividad_3.Equipos;
using Actividad_3.Jugadores;
using Actividad_3.Miembros;

Console.WriteLine("Condormacion de un equipo de fútbol");

//crear miembros:

ICuerpoTecnico miembros = new Entrenador();
ICuerpoTecnico miembros1 = new CuerpoMedico();
ICuerpoTecnico miembros2 = new Entrenador();

Equipo equipo = new Equipo(miembros,miembros2);

// crear jugadores:

Jugador jugador = new Delantero(equipo);
Jugador jugador1 = new Defensa(equipo);
Jugador jugador2 = new Mediocampista(equipo);
Jugador jugador3 = new Delantero(equipo);

// crear patrocinador:

Patrocinador patrocinador = new Patrocinador();