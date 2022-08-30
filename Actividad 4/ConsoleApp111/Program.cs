using ConsoleApp111.Entities;
using ConsoleApp111.Fabricas;

IFactory factory = new Factory();

factory.BuildEscuela(19, "IED Ciudad Bolivar");

factory.BuildProfesor(1, "$ 2,500,000");

factory.BuildCoordinador(1, "$ 3,500,000");

var _est = (Estudiante) factory.BuildEstudiante(2);