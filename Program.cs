using EspacioPersonajes;

FabricaDePersonajes FabricarPj = new FabricaDePersonajes();
Personaje Pj = new Personaje();

Pj = FabricarPj.CrearPersonajeCaract();
Console.WriteLine($"el nombre del personaje es {Pj.Nombre}");
