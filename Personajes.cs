using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Personajes
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
        
    }

    public class FabricaDePersonajes
    {
     Personaje NuevoPersonaje = new Personaje();
     public string[] Tipos = {"Habilidades mágicas" , "Luchador cuerpo a cuerpo", " Poderes Sobrenaturales"
     "Asesinos", "Temática especial"};
     public string[] Nombres = { "Sub-Zero", "Scorpion", "Johnny Cage", "Sonya Blade"

     }

    }

    public int Aleatorio( int a , int b )
    {
        Random = Random = new Random();
        return(random.Next(a,b));

    }

    public int CalcEdad()
    {
        var Hoy = DateTime.Now;
        return (int)((Hoy.Subtract(fecha_nac).TotalDays)/365);
    }

    public Personaje CrearPersonaje()
    {
        NPersonaje.
    }
}