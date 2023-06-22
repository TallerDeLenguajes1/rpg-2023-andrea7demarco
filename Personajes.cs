using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace EspacioPersonajes
{
    public class Personaje
    {
        private int velocidad;
        private int destreza;
        private int fuerza;
        private int nivel;
        private int armarudra;
        private int salud;

        private string? tipo;
        private string? nombre;
        private string?apodo;
        private DateTime fecha_nac;
        private int edad;

        public int Velocidad { get => velocidad; set => velocidad = value; }
        public int Destreza { get => destreza; set => destreza = value; }
        public int Fuerza { get => fuerza; set => fuerza = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public int Armarudra { get => armarudra; set => armarudra = value; }
        public int Salud { get => salud; set => salud = value; }
        public string? Nombre { get => nombre; set => nombre = value; }
        public string? Apodo { get => apodo; set => apodo = value; }
        public DateTime Fecha_nac { get => fecha_nac; set => fecha_nac = value; }
        public int Edad { get => edad; set => edad = value; }
        public string? Tipo { get => tipo; set => tipo = value; }
    }

    public class FabricaDePersonajes
    {
     Personaje NuevoPersonaje = new Personaje();
     public string[] Tipos = {"Habilidades mágicas" , "Luchador cuerpo a cuerpo", " Poderes Sobrenaturales",
     "Asesinos", "Temática especial"};
     public string[] Nombres = { //AGREGAR MAS
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

    public int CalcEdad()
    {
        var Hoy = DateTime.Now;
        return (int)((Hoy.Subtract(fecha_nac).TotalDays)/365);
    }

    public Personaje CrearPersonajeCaract()
    {
        NuevoPersonaje.Destreza = obtRandom(1,6);
        NuevoPersonaje.Nivel = obtRandom(1,11);
        NuevoPersonaje.Velocidad = obtRandom(1,6);
        NuevoPersonaje.Fuerza = obtRandom(1,11);
        NuevoPersonaje.Armarudra = obtRandom(1,6);
        NuevoPersonaje.Salud = obtRandom(1,11);
        NuevoPersonaje.Fecha_nac = new DateTime(obtRandom(1992,2000) , obtRandom(1,12), obtRandom(1,31));
        NuevoPersonaje.Edad = CalcEdad();
        NuevoPersonaje.Nombre = Nombres[obtRandom(0,10)];
        NuevoPersonaje.Tipo= Tipos[obtRandom(0,5)];
        return NuevoPersonaje;
    }




    public class PersonajesJson 
    {
        public void GuardarPersonajes(List<Personaje> personaje, string archivo)
        {
            //serializa
        }

        public List<Personaje> LeerPersonajes(string archivo)
        {
            //desearealización
            return listPer;
        }

        public bool Existe(string archivo)
        {
            //verifico que exista el archivo
            return;
        }
       }
}

}