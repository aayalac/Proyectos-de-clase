using console_app;
Manufacturer x = new Xbox(2001, "Microsoft", "classic", 32);
Manufacturer x360 = new Xbox(2005, "Microsoft", "360", 64);
Manufacturer N = new Nintendo(1985, "Nintendo", "NES", 8);
Manufacturer SN = new Nintendo(1990, "Nintendo", "SNES", 16);

Console.WriteLine("Xbox");
Console.WriteLine("***************************");
Console.WriteLine("Fecha fabricacion: " + x.Año);
Console.WriteLine("Fabricante: " + x.Fabricante);
Console.WriteLine("Modelo: " + x.Modelo);
Console.WriteLine("Arquitectura: " + x.Arquitectura + " Bits");
Console.WriteLine("---------------------");

Console.WriteLine("Xbox 360");
Console.WriteLine("***************************");
Console.WriteLine("Fecha fabricacion: " + x360.Año);
Console.WriteLine("Fabricante: " + x360.Fabricante);
Console.WriteLine("Modelo: " + x360.Modelo);
Console.WriteLine("Arquitectura: " + x360.Arquitectura + " Bits");
Console.WriteLine("---------------------");

Console.WriteLine("Nintendo");
Console.WriteLine("***************************");
Console.WriteLine("Fecha fabricacion: " + N.Año);
Console.WriteLine("Fabricante: " + N.Fabricante);
Console.WriteLine("Modelo: " + N.Modelo);
Console.WriteLine("Arquitectura: " + N.Arquitectura + " Bits");
Console.WriteLine("---------------------");

Console.WriteLine("Super Nintendo");
Console.WriteLine("***************************");
Console.WriteLine("Fecha fabricacion: " + SN.Año);
Console.WriteLine("Fabricante: " + SN.Fabricante);
Console.WriteLine("Modelo: " + SN.Modelo);
Console.WriteLine("Arquitectura: " + SN.Arquitectura + " Bits");
Console.WriteLine("---------------------");