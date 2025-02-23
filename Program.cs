﻿// See https://aka.ms/new-console-template for more information
using EspacioPersonaje;
using EspacioPersistencia;
using GeneracionDePersonajes;
using EspacioMenu;

FabricaDePersonajes fabrica = new FabricaDePersonajes();
PersonajesJson personajesJson = new PersonajesJson();

string nombreArchivo="Personajes.json";
List<Personaje> ListaDePersonajes;

//Si existe archivo Json lo utiliza, sino genera 10 personajes y los guarda
if(personajesJson.Existe(nombreArchivo))
{
    ListaDePersonajes = personajesJson.LeerPersonajes("Personajes.json");

}else
{
    Console.WriteLine("No se encontro archivo, generando personajes...");
    ListaDePersonajes = new List<Personaje>();

    for (int i = 0; i < 10; i++)
    {
        Personaje personaje = fabrica.CrearPersonaje();
        ListaDePersonajes.Add(personaje);
    }

    personajesJson.GuardarPersonajes(ListaDePersonajes, nombreArchivo);
}

//Menu e Inicio del juego
Menu menu = new Menu(ListaDePersonajes);
await menu.MostrarMenu();
