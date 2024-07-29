using EspacioPersistencia;
using EspacioPersonaje;
using EspacioAscii;
using EspacioApi;
using System.Text.Json;

namespace EspacioCombate
{
    public class Combate
    {
        Random random = new Random();
        Ascii ascii = new Ascii();
        HistorialJson historial = new HistorialJson();
        RegistroGanador ganador = new RegistroGanador();
        string nombreArchivo="Historial.json";
        int cantidadFatalitys=0;

        public async Task IniciarTorre(List<Personaje> ListaDePersonajes, Personaje personaje1)
        {
            int cantidadOponentes=ListaDePersonajes.Count;
            int contadorCombates=1;
           
            ascii.TiempoDeTextoCentrado($"=============== Iniciando Torre con {personaje1.Datos.Nombre} ===============", 20);
            ascii.mostarPersonajeAscii(personaje1.Datos.Nombre);

            while (personaje1.Caracteristicas.Salud > 0 && ListaDePersonajes.Count > 0)
            {
                Pais salida = await GetCurrecyRateAsync();
                Personaje oponente = ListaDePersonajes[random.Next(ListaDePersonajes.Count)];

                ascii.TiempoDeTextoCentrado($"============= Rival Encontrado, {oponente.Datos.Nombre} =============", 20);
                ascii.mostarPersonajeAscii(oponente.Datos.Nombre);

                ascii.EscribirCentrado("===========================");
                ascii.EscribirCentrado($"Lugar de Combate: {salida.Name.Common}");
                ascii.EscribirCentrado($"Combate Numero {contadorCombates}");
                ascii.EscribirCentrado("===========================");
                Console.WriteLine();

                contadorCombates++;

                ascii.TiempoDeTextoCentrado($"{personaje1.Datos.Nombre} VS {oponente.Datos.Nombre}", 30);
                RealizarCombate(personaje1, oponente);

                if (personaje1.Caracteristicas.Salud <= 0)
                {
                    Console.WriteLine($"Tu personaje {personaje1.Datos.Nombre} ha sido vencido. ¡El juego ha terminado!");
                    return;
                }

                RealizarFatality(personaje1);
                ListaDePersonajes.Remove(oponente);

                if(contadorCombates==cantidadOponentes)
                {
                    ascii.TiempoDeTexto("El proximo rival es el mas fuerte, Gana tu ultimo combate y seras campeon del Mortal Kombat", 20);
                }

                if(ListaDePersonajes.Count != 0)
                {
                    Console.WriteLine("\nSelecciona la mejora que creas conveniente y avanza en la torre.");
                    MejorarHabilidades(personaje1);
                    ascii.TiempoDeTextoCentrado("Subiendo torre... cargando rival...", 20);
                }
            }

            ascii.Logo();

            Console.WriteLine($"\n=== ¡FELICIDADES! Ganaste Mortal kombat ===");
            ganador.MostrarGanador(personaje1, cantidadOponentes, cantidadFatalitys, DateTime.Now);
            Console.WriteLine("¡Demostraste ser el mejor y entras al Ranking historico de ganadores!");

            historial.GuardarGanador(personaje1, cantidadOponentes, cantidadFatalitys, nombreArchivo);
            return;
        }

        private void RealizarCombate(Personaje personaje1, Personaje personaje2)
        {
            while (personaje1.Caracteristicas.Salud > 0 && personaje2.Caracteristicas.Salud > 0)
            {
                RealizarTurno(personaje1, personaje2);
                if (personaje2.Caracteristicas.Salud > 0)
                {
                    RealizarTurno(personaje2, personaje1);
                }
            }

            if (personaje2.Caracteristicas.Salud <= 0)
            {
                Console.WriteLine();
                ascii.TiempoDeTextoCentrado($"¡Ganaste el combate! {personaje2.Datos.Nombre} ha sido vencido", 30);
            }
        }

        private void RealizarTurno(Personaje atacante, Personaje defensor)
        {
            int danio = CalcularDanio(atacante, defensor);
            defensor.Caracteristicas.Salud -= danio;
            ascii.TiempoDeTextoCentrado($"{atacante.Datos.Nombre} ataca a {defensor.Datos.Nombre} y causa {danio} de daño. [Salud de {defensor.Datos.Nombre}]: {defensor.Caracteristicas.Salud}", 5);
        }

        private int CalcularDanio(Personaje atacante, Personaje defensor)
        {
            int ataque = atacante.Caracteristicas.Fuerza * atacante.Caracteristicas.Destreza * atacante.Caracteristicas.Nivel;
            int efectividad = random.Next(1,101);
            int Defensa = defensor.Caracteristicas.Armadura * defensor.Caracteristicas.Velocidad;
            const int ajuste=500;

            int danioProvocado = ((ataque*efectividad)-Defensa) / ajuste;

            return Math.Max(danioProvocado, 0); //Aseguro que el daño no sea negativo
        }

        private void MejorarHabilidades(Personaje ganador)
        {
            Console.WriteLine($"Condicion Actual de {ganador.Datos.Nombre}, [Salud]: {ganador.Caracteristicas.Salud}, [Armadura]: {ganador.Caracteristicas.Armadura}");
            Console.WriteLine("1.Mejorar +15 en Salud");
            Console.WriteLine("2.Mejorar +5 en Armadura");

            int seleccion;

            while (!int.TryParse(Console.ReadLine(), out seleccion) || seleccion < 1 || seleccion > 2)
            {
                Console.WriteLine("Selección no válida. Inténtelo de nuevo.");
            }

            if(seleccion == 1)
            {
                ganador.Caracteristicas.Salud += 15;
                Console.WriteLine($"\n{ganador.Datos.Nombre} recibe +15 en salud.");
            }else
            {
                ganador.Caracteristicas.Armadura += 5;
                Console.WriteLine($"\n{ganador.Datos.Nombre} recibe +5 en Armadura.");
            }
        }

        private void RealizarFatality(Personaje ganador)
        {
            string[] comandos = {"sdsa5", "fdfd8", "qwwq1", "jklk0"};
            string comandoSeleccionado = comandos[random.Next(comandos.Length)];

            Console.WriteLine();
            ascii.fatality();
            Console.WriteLine("¡Realiza un Fatality para mejorar tu armadura!");
            Console.WriteLine($"Comando ({comandoSeleccionado}):");

            string? comandoUsuario = Console.ReadLine();

            if (comandoUsuario == comandoSeleccionado)
            {
                ganador.Caracteristicas.Armadura += 10;
                cantidadFatalitys++;
                ascii.TiempoDeTexto("¡Fatality Exitosa! Armadura mejorada en 10 puntos.", 30);
            }
            else
            {
                ascii.TiempoDeTexto("¡Fallaste! No se realizó la Fatality.", 30);
            }
        }

        static async Task<Pais> GetCurrecyRateAsync()
        {
            var paises = new List<string> {"Argentina", "Brazil", "Uruguay", "Mexico", "Colombia"};
            var random = new Random();
            var paisRandom = paises[random.Next(paises.Count)];

            var url = $"https://restcountries.com/v3.1/name/{paisRandom}";
            
            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                // Deserializar como una lista de Pais
                List<Pais>? pais = JsonSerializer.Deserialize<List<Pais>>(responseBody);

                // Toma el primer elemento de la lista
                return pais.FirstOrDefault();
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("Problemas de acceso a la API");
                Console.WriteLine("Message :{0} ", e.Message);
                return null;
            }
        }

    }
}