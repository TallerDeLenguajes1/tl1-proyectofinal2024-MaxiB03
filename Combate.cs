using System;
using System.Collections.Generic;
using EspacioPersonaje;
using EspacioAscii;

namespace EspacioCombate
{
    public class Combate
    {
        Random random = new Random();
        Ascii ascii = new Ascii();

        public void IniciarTorre(List<Personaje> ListaDePersonajes, Personaje personaje1)
        {

            Console.WriteLine($"\n=========== Iniciando Torre con {personaje1.Datos.Nombre} ===========");
            ascii.mostarPersonajeAscii(personaje1.Datos.Nombre);

            while (personaje1.Caracteristicas.Salud > 0 && ListaDePersonajes.Count > 0)
            {
                Personaje oponente = ListaDePersonajes[random.Next(ListaDePersonajes.Count)];

                Console.WriteLine($"\n====== Combate entre {personaje1.Datos.Nombre} y {oponente.Datos.Nombre} ======");
                RealizarCombate(personaje1, oponente);

                if (personaje1.Caracteristicas.Salud <= 0)
                {
                    Console.WriteLine($"Tu personaje {personaje1.Datos.Nombre} ha sido vencido. ¡El juego ha terminado!");
                    return;
                }

                RealizarFatality(personaje1);
                ListaDePersonajes.Remove(oponente);

                Console.WriteLine("Selecciona la mejora que creas conveniente y avanza en la torre.");
                MejorarHabilidades(personaje1);
                ascii.SubirTorre();
            }

            if(personaje1.Caracteristicas.Salud >0)
            {
                Console.WriteLine("¡Felicidades! ¡Ganaste el Mortal Kombat!");
            }
        }

        public Personaje SeleccionarPersonaje(List<Personaje> listaDePersonajes)
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
                Console.WriteLine($"====== ¡Ganaste el combate! {personaje2.Datos.Nombre} ha sido vencido ======");
            }
        }

        private void RealizarTurno(Personaje atacante, Personaje defensor)
        {
            int danio = CalcularDanio(atacante, defensor);
            defensor.Caracteristicas.Salud -= danio;
            Console.WriteLine($"{atacante.Datos.Nombre} ataca a {defensor.Datos.Nombre} y causa {danio} de daño. [Salud de {defensor.Datos.Nombre}]: {defensor.Caracteristicas.Salud}");
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
            Console.WriteLine($"Condicion Actual de {ganador.Datos.Nombre}, [Salud]: {ganador.Caracteristicas.Salud}, [Armadura]: {ganador.Caracteristicas.Armadura} ");
            Console.WriteLine("1.Mejorar +10 en Salud");
            Console.WriteLine("2.Mejorar +5 en Armadura");

            int seleccion;

            while (!int.TryParse(Console.ReadLine(), out seleccion) || seleccion < 1 || seleccion > 2)
            {
                Console.WriteLine("Selección no válida. Inténtelo de nuevo.");
            }

            if(seleccion == 1)
            {
                ganador.Caracteristicas.Salud += 10;
                Console.WriteLine($"{ganador.Datos.Nombre} recibe +10 en salud.");
            }else
            {
                ganador.Caracteristicas.Armadura += 5;
                Console.WriteLine($"{ganador.Datos.Nombre} recibe +5 en Armadura.");
            }
        }

        private void RealizarFatality(Personaje ganador)
        {
            string[] comandos = {"sdsa5", "fdfd8", "qwwq1"};
            string comandoSeleccionado = comandos[random.Next(comandos.Length)];

            ascii.fatality();
            Console.WriteLine("¡Realiza un Fatality para mejorar tu armadura!");
            Console.WriteLine($"Comando ({comandoSeleccionado}):");

            string? comandoUsuario = Console.ReadLine();

            if (comandoUsuario == comandoSeleccionado)
            {
                ganador.Caracteristicas.Armadura += 5;
                Console.WriteLine("¡Fatality Exitosa! Armadura mejorada en 5 puntos.");
            }
            else
            {
                Console.WriteLine("¡Fallaste! No se realizó la Fatality.");
            }
        }


    }
}