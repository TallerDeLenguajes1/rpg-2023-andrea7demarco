using EspacioPersonajes;
using System.Text.Json;
public class PersonajesJson 
{
        public void GuardarPersonajes(List<Personaje> personaje, string archivo)
        {
            //serializa
            string json = JsonSerializer.Serialize(personaje);
            File.WriteAllText(archivo +".json", json);
            
        }

        public List<Personaje> LeerPersonajes(string archivo)
        {
            //desearealización
            string json = File.ReadAllText(archivo);
            List<Personaje> PersonajeDeserializado = JsonSerializer.Deserialize<List<Personaje>>(json);
            
            if(PersonajeDeserializado == null){

                throw new Exception("No se pudo leer el archivo JSON");
            }

            return PersonajeDeserializado;
        }

        public bool Existe(string archivo)
        {
            //verifico que exista el archivo
            return File.Exists(archivo);
        }
}