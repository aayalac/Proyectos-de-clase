using Actividad_6.Educativos;
using Actividad_6.Entities;

Console.WriteLine("Hola mundo");

// Agregar trabajador a Escuela
IEscuela<Trabajador> escuela = new Escuela<Trabajador>();
escuela.Matricular (new Trabajador());

//Agregar estudiante a Escuela
IEscuela<Estudiante> escuela1 = new Escuela<Estudiante>();
escuela1.Matricular(new Estudiante());