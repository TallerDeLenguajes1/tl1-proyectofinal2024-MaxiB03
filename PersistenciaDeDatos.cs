using System.IO;
using System.Text.Json;
using EspacioPersonaje;

namespace EspacioPersistencia 
{
    public class PersonajesJson
    {
        public void GuardarPersonajes(List<Personaje> personajes, string nombreArchivo)
        {
            string jsonString = JsonSerializer.Serialize(personajes);
            File.WriteAllText(nombreArchivo, jsonString);
        }

        public List<Personaje> LeerPersonajes(string nombreArchivo)
        {
            string jsonString = File.ReadAllText(nombreArchivo);
            var ListaDePersonajes = JsonSerializer.Deserialize<List<Personaje>>(jsonString);
            return ListaDePersonajes;
        }

        public bool Existe(string nombreArchivo)
        {
            return File.Exists(nombreArchivo) && new FileInfo(nombreArchivo).Length > 0;
        }
    }

}