using EspacioPersonajes;

public class FabricaDePersonajes
    {
        Dictionary<string, int> tipos = new Dictionary<string, int>(){
            ["Johnny Cage"] = 0,
            ["Sonya Blade"] = 0,
            ["Quan Chi"] = 1,
            ["Shang Tsung"] = 1,
            ["Raiden"] = 2,
            ["Sub-Zero"] = 2,
            ["Baraka"] = 3,
            ["Mileena"] = 3,
            ["Goro"] = 4,
            ["Cyrax"] = 4

        };
     
        public string[] nombres = { //AGREGAR MAS
            //Luchadores de combate cuerpo a cuerpo:
            "Johnny Cage" , "Sonya Blade" ,
            //Personajes con habilidades mágicas
            "Quan Chi", "Shang Tsung" ,
            //Personajes con poderes sobrenaturales
            "Raiden" ,"Sub-Zero" ,
            //Asesinos y guerreros letales
            "Baraka", "Mileena" ,
            //Temática especial
            "Goro" , "Cyrax"}; 

    

    public int obtRandom(int a, int b)
    {
        Random random = new Random();
        return random.Next(a,b);

    }

    public int CalcEdad(DateTime fechaNacimiento)
    {
        var Hoy = DateTime.Now;
        return (int)((Hoy.Subtract(fechaNacimiento).TotalDays)/365);
    }

    public List<Personaje> CrearPersonajeCaract()
    {
        List<Personaje> personajes = new List<Personaje>();

        for(int i = 0; i < 10; i++){

            Personaje NuevoPersonaje = new Personaje();

            NuevoPersonaje.Destreza = obtRandom(1,6);
            NuevoPersonaje.Nivel = obtRandom(1,11);
            NuevoPersonaje.Velocidad = obtRandom(1,11);
            NuevoPersonaje.Fuerza = obtRandom(1,11);
            NuevoPersonaje.Armadura = obtRandom(1,11);
            NuevoPersonaje.Salud = 100;
            NuevoPersonaje.Fecha_nac = new DateTime(obtRandom(1992,2000) , obtRandom(1,12), obtRandom(1,31));
            NuevoPersonaje.Edad = CalcEdad(NuevoPersonaje.Fecha_nac);
            NuevoPersonaje.Nombre = nombres[i];
            NuevoPersonaje.Tipo = (Tipos) tipos.GetValueOrDefault(NuevoPersonaje.Nombre);

            personajes.Add(NuevoPersonaje);
        }
        

        return personajes;

    }





  /* */
       
}

