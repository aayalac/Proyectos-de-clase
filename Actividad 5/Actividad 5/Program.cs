using Actividad_5.Models;
using Actividad_5.Controllers;
using Actividad_5.Views.Vehicle;
using Actividad_5.Views.Driver;

Console.WriteLine("Programa de registro para el SITP de Bogota");
Console.WriteLine("----------------------------------------------");


// Ingresar bus al sistema

BusController nuevoBus = new BusController(new CrearBus());
nuevoBus.Crear("1", "SE14", Estacion.Build("1", "carrera30", "SE14"));
nuevoBus.Crear("2", "T25", Estacion.Build("2", "Carrera 7ma", "T25"));

//Ingresar conductor al sistema

ConductorController nuevoConductor = new ConductorController(new CrearConductor());
nuevoConductor.Crear("ID001", "1013659496", "jose gomez");
nuevoConductor.Crear("ID002", "1023456789", "Andres Perez");