using EspacioPersonaje;
using EspacioCombate;
using EspacioAscii;
using EspacioPersistencia;

namespace EspacioMenu
{
    public class Menu
    {
        private List<Personaje> ListaDePersonajes;

        public Menu(List<Personaje> listaDePersonajes)
        {
            ListaDePersonajes = listaDePersonajes;
        }

        Combate combate = new Combate();
        Ascii ascii = new Ascii();
        HistorialJson historial = new HistorialJson();
        string nombreArchivoHistorial = "Historial.json";
        
        public async Task MostrarMenu()
        {
            int opcion;

            do
            {
                Console.Clear();
                ascii.titulo();
                ascii.Menu();
                Console.WriteLine("1. Jugar Modo Torre");
                Console.WriteLine("2. Mostrar Personajes");
                Console.WriteLine("3. Mostrar Historial de ganadores");
                Console.WriteLine("4. Salir");
                Console.WriteLine("Seleccione una opción:");

                while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 4)
                {
                    Console.WriteLine("Selección no válida. Inténtelo de nuevo.");
                }

                List<Personaje> copiaDeLaLista = ClonarListaPersonajes(ListaDePersonajes);
                
                switch (opcion)
                {
                    case 1:
                        await JugarTorre(copiaDeLaLista);
                        break;
                    case 2:
                        MostrarPersonajes(ListaDePersonajes);
                        break;
                    case 3:
                        MostrarGanadoresHistoricos();
                        break;
                    case 4:
                        Console.WriteLine("Saliendo del juego...");
                        break;
                }

                if (opcion != 4)
                {
                    Console.WriteLine("Presione cualquier tecla para volver al menú...");
                    Console.ReadKey();
                }

            } while (opcion != 4);
        }

        //Opcion 1, Define la cant de rivales, Selecciona el personaje principal e Inicia el juego
        private async Task JugarTorre(List<Personaje> ListaDePersonajes)
        {
            Console.WriteLine("Selecciona dificultad de la torre: ");
            Console.WriteLine("1.Torre de 3 Personajes");
            Console.WriteLine("2.Torre de 6 Personajes");
            Console.WriteLine("3.Torre de 9 Personajes");

            int seleccion;

            while (!int.TryParse(Console.ReadLine(), out seleccion) || seleccion < 1 || seleccion > 3)
            {
                Console.WriteLine("Selección no válida. Inténtelo de nuevo.");
            }

            Personaje personaje1 = SeleccionarPersonaje(ListaDePersonajes);
            ListaDePersonajes.Remove(personaje1);

            switch (seleccion)
            {
                case 1:
                    BorrarPersonajesDeLista(ListaDePersonajes, 6);
                    break;
                case 2:
                    BorrarPersonajesDeLista(ListaDePersonajes, 3);
                    break;
                default:
                break;
            }

            //Inicio del juego
            await combate.IniciarTorre(ListaDePersonajes, personaje1);
        }

        //Metodo que clona la lista de personajes original para no perderla y jugar de nuevo
        public static List<Personaje> ClonarListaPersonajes(List<Personaje> listaOriginal)
        {
            List<Personaje> nuevaLista = new List<Personaje>();
            foreach (var personaje in listaOriginal)
            {
                // Creao una nueva instancia del personaje y copio sus propiedades
                Personaje nuevoPersonaje = new Personaje
                {
                    Datos = new Datos
                    {
                        Nombre = personaje.Datos.Nombre,
                        Tipo = personaje.Datos.Tipo,
                        Apodo = personaje.Datos.Apodo,
                        FechaNacimiento = personaje.Datos.FechaNacimiento,
                        Edad = personaje.Datos.Edad
                    },
                    Caracteristicas = new Caracteristicas
                    {
                        Velocidad = personaje.Caracteristicas.Velocidad,
                        Destreza = personaje.Caracteristicas.Destreza,
                        Fuerza = personaje.Caracteristicas.Fuerza,
                        Nivel = personaje.Caracteristicas.Nivel,
                        Armadura = personaje.Caracteristicas.Armadura,
                        Salud = personaje.Caracteristicas.Salud
                    }
                };
                nuevaLista.Add(nuevoPersonaje);
            }
            return nuevaLista;
        }

        //Metodo de seleccion del personaje principal
        private Personaje SeleccionarPersonaje(List<Personaje> listaDePersonajes)
        {
            Console.WriteLine($"Selecciona tu personaje para combatir en la torre:");
            for (int i = 0; i < listaDePersonajes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {listaDePersonajes[i].Datos.Nombre}");
            }

            int seleccion;

            while (!int.TryParse(Console.ReadLine(), out seleccion) || seleccion < 1 || seleccion > listaDePersonajes.Count)
            {
                Console.WriteLine("Selección no válida. Inténtelo de nuevo.");
            }

            return listaDePersonajes[seleccion - 1];
        }
        
        //Determino la cantidad de luchadores que tendra la torre
        private void BorrarPersonajesDeLista(List<Personaje> ListaDePersonajes, int cantidadABorrar)
        {
            Random random = new Random();

            for (int i=0; i<cantidadABorrar; i++)
            {
                int indiceAleatorio=random.Next(ListaDePersonajes.Count);
                ListaDePersonajes.RemoveAt(indiceAleatorio);
            }
        }

        //Opcion 2, Muestra de personajes
        private void MostrarPersonajes(List<Personaje> listaDePersonajes)
        {
            int seleccion;

            do
            {
                ascii.Personajes();
                
                for (int i = 0; i < listaDePersonajes.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {listaDePersonajes[i].Datos.Nombre}");
                }
                Console.WriteLine("11.Mostrar Datos y Caracteristicas de todos");
                Console.WriteLine("0.Volver");

                Console.WriteLine($"Selecciona personaje para mostrar sus datos y caracteristicas: ");

                while (!int.TryParse(Console.ReadLine(), out seleccion) || seleccion < 0 || seleccion > 11)
                {
                    Console.WriteLine("Selección no válida. Inténtelo de nuevo.");
                }

                if(seleccion!=0 && seleccion!=11)
                {
                    ascii.mostarPersonajeAscii(listaDePersonajes[seleccion-1].Datos.Nombre);
                    listaDePersonajes[seleccion-1].MostrarPersonaje();
                }

                if(seleccion==11)
                {
                    int j=0;

                    foreach (var personaje in ListaDePersonajes)
                    {
                        j ++;
                        ascii.EscribirCentrado($"PERSONAJE [{j}]");
                        personaje.MostrarPersonaje();
                    }
                }

            } while (seleccion!=0);
        }

        //Opcion 3, Muestra ganadores
        private void MostrarGanadoresHistoricos()
        {
            if (historial.Existe(nombreArchivoHistorial))
            {
                List<RegistroGanador> ganadores = historial.LeerGanadores(nombreArchivoHistorial);
                
                ascii.Historial();
                
                foreach (var ganador in ganadores)
                {
                    ganador.MostrarGanador(ganador.Ganador, ganador.CantidadOponentes, ganador.CantidadFatalitys, ganador.Fecha);
                }
            }
            else
            {
                Console.WriteLine("No hay ganadores históricos registrados.");
            }
        }

    }
}