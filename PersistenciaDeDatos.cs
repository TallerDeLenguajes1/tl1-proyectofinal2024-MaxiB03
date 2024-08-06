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
            if (File.Exists(nombreArchivo))
            {
                string jsonString = File.ReadAllText(nombreArchivo);
                var ListaDePersonajes = JsonSerializer.Deserialize<List<Personaje>>(jsonString);
                return ListaDePersonajes;
            }
            return new List<Personaje>(); //Si no existe el archivo retorna la lista vacia
        }

        public bool Existe(string nombreArchivo)
        {
            return File.Exists(nombreArchivo) && new FileInfo(nombreArchivo).Length > 0;
        }
    }

     public class HistorialJson
    {
        public void GuardarGanador(Personaje ganador, int oponentes, int fatalitys, string nombreArchivo)
        {
            List<RegistroGanador> listaDeGanadores;

            if (Existe(nombreArchivo))
            {
                listaDeGanadores = LeerGanadores(nombreArchivo);
            }
            else
            {
                listaDeGanadores = new List<RegistroGanador>();
            }

            RegistroGanador registro = new RegistroGanador(ganador, oponentes, fatalitys, DateTime.Now);
            listaDeGanadores.Add(registro);

            string jsonString = JsonSerializer.Serialize(listaDeGanadores);
            File.WriteAllText(nombreArchivo, jsonString);
        }

        public List<RegistroGanador> LeerGanadores(string nombreArchivo)
        {
            if (File.Exists(nombreArchivo))
            {
                string jsonString = File.ReadAllText(nombreArchivo);
                var ListaDeGanadores = JsonSerializer.Deserialize<List<RegistroGanador>>(jsonString);
                return ListaDeGanadores;
            }
            return new List<RegistroGanador>(); //Si no existe el archivo retorna la lista vacia
        }

        public bool Existe(string nombreArchivo)
        {
            return File.Exists(nombreArchivo) && new FileInfo(nombreArchivo).Length > 0;
        }
    }

    public class RegistroGanador
    {
        Personaje ganador;
        int cantidadOponentes;
        int cantidadFatalitys;
        DateTime fecha;

        public Personaje Ganador { get => ganador; set => ganador = value; }
        public int CantidadOponentes { get => cantidadOponentes; set => cantidadOponentes = value; }
        public int CantidadFatalitys { get => cantidadFatalitys; set => cantidadFatalitys = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }

        // Constructor sin parámetros necesario para la deserialización
        public RegistroGanador() { }

        //Constructor
        public RegistroGanador(Personaje ganador, int cantidadOponentes, int cantidadFatalitys, DateTime fecha)
        {
            this.ganador=ganador;
            this.cantidadOponentes=cantidadOponentes;
            this.cantidadFatalitys=cantidadFatalitys;
            this.fecha=fecha;
        }

        public void MostrarGanador(Personaje ganador, int oponentes, int fatalitys, DateTime fecha)
        {
            Console.WriteLine("==========================");
            Console.WriteLine($"NOMBRE: {ganador.Datos.Nombre}");
            Console.WriteLine("-DETALLES DEL CAMPEON");
            Console.WriteLine($"Tipo: {ganador.Datos.Tipo}");
            Console.WriteLine($"Apodo: {ganador.Datos.Apodo}");
            Console.WriteLine($"Edad: {ganador.Datos.Edad}");
            Console.WriteLine("-DETALLES DE LA PARTIDA");
            Console.WriteLine($"Rivales derrotados: {oponentes}");
            Console.WriteLine($"Fatalitys logradas: {fatalitys}");
            Console.WriteLine($"Fecha: {fecha}");
            Console.WriteLine("==========================\n");
        }
    }

}

