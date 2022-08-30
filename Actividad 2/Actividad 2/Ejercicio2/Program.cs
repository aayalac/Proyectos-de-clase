using Ejercicio2.Entities;
using Ejercicio2.Entities1;
//___________________________________________________________________Entidades
//polimorfismo y caste (atributos)

Entity ve = new MotoElectrica(id: "1", marca: "Starker", modelo: "Reactor", placa: "HTV45F", cilindraje: "125C", horasCarga: 45);
var ve1 = (MotoElectrica)ve;
Entity1 moto = new MotoElectrica1();
moto.Arrancar();
Console.WriteLine("*******************");
Console.WriteLine("Marca: "+ve1.Marca);
Console.WriteLine("Horas de carga: "+ve1.HorasCarga);
Console.WriteLine("Modelo: " + ve1.Modelo);
Console.WriteLine("Cilindraje: " + ve1.Cilindraje);
Console.WriteLine("--------------------");

//polimorfismo y caste (metodo)

Entity vg = new MotoGasolina(id: "1",marca:"Yamaha",modelo:"FZ 2.0", placa: "RTA42G", cilindraje: "150CC");
var vg1 = (MotoGasolina)vg;
Entity1 moto2 = new MotoGasolina1();
moto2.Arrancar();
Console.WriteLine("--------------------");
vg1.ImprimirValores();
