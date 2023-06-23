using EspacioPersonajes;

FabricaDePersonajes FabricarPj = new FabricaDePersonajes();
PersonajesJson json = new PersonajesJson();
Batalla pelea = new Batalla();
List<Personaje> personajesList;
int flag;

if(!json.Existe("Personajes.json")){ 
    personajesList = FabricarPj.CrearPersonajeCaract();
    json.GuardarPersonajes(personajesList, "Personajes");
}

Console.WriteLine("Quiere ver la lista de los personajes? SI[1] - NO[0]");  
flag = int.Parse(Console.ReadLine()); // Poner int.TryParse()

personajesList = json.LeerPersonajes("Personajes.json");

if(flag == 1){
    MostrarPersonajes(personajesList);
    Console.ReadKey();
    Console.Clear();
}

do{
    personajesList = json.LeerPersonajes("Personajes.json");
    if(personajesList.Count() == 1){
        MostrarGanador(personajesList[0]);

        Console.WriteLine("Quiere generar nuevamente los personajes? SI[1] - NO[0]");
        flag = int.Parse(Console.ReadLine());

        if(flag == 1){
            personajesList = FabricarPj.CrearPersonajeCaract();
            json.GuardarPersonajes(personajesList, "Personajes");
        }else{

            return;
        }

    }

    List<Personaje> listaActualizada = pelea.Pelea(personajesList);
    json.GuardarPersonajes(listaActualizada, "Personajes");

    Console.WriteLine("Quiere iniciar una nueva pelea? SI[1] - NO[0]");
    flag = int.Parse(Console.ReadLine());
    Console.Clear();

}while(flag == 1);

Console.Clear();

void MostrarPersonajes(List<Personaje> personajes){

    foreach (Personaje pj in personajes){
        Console.WriteLine($"El nombre del peronaje es {pj.Nombre}\n" +
            $"El tipo de personaje es {pj.Tipo.ToString()}\n " + 
            $"La velocidad del peronaje es {pj.Velocidad}\n" +
            $"El nivel del personaje es {pj.Nivel}\n"+
            $"La fuerza del personaje es {pj.Fuerza}\n"+
            $"La salud del personaje es {pj.Salud}\n");
    }

}

void MostrarGanador(Personaje pj){
    Console.WriteLine($"El personaje ganador es {pj.Nombre} WIIII");
}