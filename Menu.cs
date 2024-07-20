using EspacioPersonaje;
using EspacioPersistencia;
using GeneracionDePersonajes;
using EspacioCombate;
using EspacioAscii;

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
        
        public void MostrarMenu()
        {
            int opcion;

            do
            {
                Console.Clear();
                ascii.titulo();
                Console.WriteLine("========== Menú Principal ==========");
                Console.WriteLine("1. Jugar Modo Torre");
                Console.WriteLine("2. Mostrar Personajes");
                Console.WriteLine("3. Salir");
                Console.WriteLine("Seleccione una opción:");

                while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 3)
                {
                    Console.WriteLine("Selección no válida. Inténtelo de nuevo.");
                }

                switch (opcion)
                {
                    case 1:
                        JugarTorre(ListaDePersonajes);
                        break;
                    case 2:
                        MostrarPersonajes(ListaDePersonajes);
                        break;
                    case 3:
                        Console.WriteLine("Saliendo del juego...");
                        break;
                }

                if (opcion != 3)
                {
                    Console.WriteLine("Presione cualquier tecla para volver al menú...");
                    Console.ReadKey();
                }

            } while (opcion != 3);
        }

        private void JugarTorre(List<Personaje> ListaDePersonajes)
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

            Personaje personaje1 = combate.SeleccionarPersonaje(ListaDePersonajes);
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

            combate.IniciarTorre(ListaDePersonajes, personaje1);
        }

        private void BorrarPersonajesDeLista(List<Personaje> ListaDePersonajes, int cantidadABorrar)
        {
            Random random = new Random();

            for (int i=0; i<cantidadABorrar; i++)
            {
                int indiceAleatorio=random.Next(ListaDePersonajes.Count);
                ListaDePersonajes.RemoveAt(indiceAleatorio);
            }
        }

        private void MostrarPersonajes(List<Personaje> listaDePersonajes)
        {
            int seleccion;

            do
            {
                Console.WriteLine("\n========== Lista de Personajes ==========");
                Console.WriteLine("0.Volver");
                for (int i = 0; i < listaDePersonajes.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {listaDePersonajes[i].Datos.Nombre}");
                }
                Console.WriteLine("11.Mostrar Datos y Caracteristicas de todos");

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
                        j += 1;
                        Console.WriteLine($"======== PERSONAJE [{j}] ========");
                        personaje.MostrarPersonaje();
                        Console.WriteLine("-------------------------------");
                    }
                }

            } while (seleccion!=0);
        }

    }
}