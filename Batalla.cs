public class Batalla{
    private readonly FabricaDePersonajes fabrica;
    private readonly PersonajesJson json;

    public Batalla()
    {
        json = new PersonajesJson();
        fabrica = new FabricaDePersonajes();
    }

    public List<EspacioPersonajes.Personaje> Pelea(List<EspacioPersonajes.Personaje> personajes){
   
        EspacioPersonajes.Personaje peleador1;
        EspacioPersonajes.Personaje peleador2;

        if(personajes.Count() == 1){
            
        }
        int nroPersonajes = personajes.Count();

        peleador1 = personajes[fabrica.obtRandom(0, nroPersonajes)];

        do{
            peleador2 = personajes[fabrica.obtRandom(0, nroPersonajes)];

        }while(peleador1.Nombre == peleador2.Nombre);


        int contador = 0;

        do{
            decimal daño1 = DañoAtaque(peleador1, peleador2.Velocidad);

            peleador2.Salud -= daño1;

            decimal daño2 = DañoAtaque(peleador2, peleador1.Velocidad);

            peleador1.Salud -= daño2;

            MostrarDatos(peleador1, peleador2);

            Console.WriteLine($"Ronda Numero {contador++}");
            Console.ReadKey();


            if(peleador1.Salud <= 0){
                Ganador(peleador2);
                personajes.Remove(peleador1);
                return personajes;
            }

            if(peleador2.Salud <= 0){
                Ganador(peleador1);
                personajes.Remove(peleador2);
                return personajes;
            }

            Console.Clear();

        }while(true);
    }

    public decimal DañoAtaque(EspacioPersonajes.Personaje pj, int velocidad){

        int ataque = pj.Destreza * pj.Fuerza * pj.Nivel;
        int efectividad = fabrica.obtRandom(1,101);
        int defensa = pj.Armadura * velocidad;
        int constanteAjuste = 500;

        decimal daño = ((ataque * efectividad) - defensa) / constanteAjuste;
        return daño;
    }

    public void Ganador(EspacioPersonajes.Personaje pj){
        pj.Fuerza += 5;
        pj.Salud += 10;
        pj.Nivel++;
    }

    public void MostrarDatos(EspacioPersonajes.Personaje pj1, EspacioPersonajes.Personaje pj2){

        Console.WriteLine($"El nombre del peronaje es Personaje 1: {pj1.Nombre} ------- Personaje 2: {pj2.Nombre}\n" +
            $"El tipo de personaje es Personaje 1: {pj1.Tipo.ToString()} ------- Personaje 2: {pj2.Tipo.ToString()}\n" + 
            $"La velocidad del peronaje es Personaje 1: {pj1.Velocidad} ------- Personaje 2: {pj2.Velocidad}\n" +
            $"El nivel del personaje es Personaje 1: {pj1.Nivel} ------- Personaje 2: {pj2.Nivel}\n"+
            $"La fuerza del personaje es Personaje 1: {pj1.Fuerza} ------- Personaje 2: {pj2.Fuerza}\n"+
            $"La salud del personaje es Personaje 1: {pj1.Salud} ------- Personaje 2: {pj2.Salud}\n");
    }

}