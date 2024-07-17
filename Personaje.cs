namespace EspacioPersonaje
{
    public class Datos
    {
        string tipo;
        string nombre;
        string apodo;
        DateTime fechaNacimiento;
        int edad;

        public string Tipo { get => tipo; set => tipo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apodo { get => apodo; set => apodo = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int Edad { get => edad; set => edad = value; }

        // Constructor sin parámetros necesario para la deserialización
        public Datos() { }

        //Constructor
        public Datos(string nombre, string tipo, string apodo, DateTime fechaNacimiento, int edad)
        {
            this.tipo = tipo;
            this.nombre = nombre;
            this.apodo = apodo;
            this.fechaNacimiento = fechaNacimiento;
            this.edad = edad;
        }

    }
    
    public class Caracteristicas
    {
        int velocidad;
        int destreza;
        int fuerza;
        int nivel;
        int armadura;
        int salud;

        public int Velocidad { get => velocidad; set => velocidad = value; }
        public int Destreza { get => destreza; set => destreza = value; }
        public int Fuerza { get => fuerza; set => fuerza = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public int Armadura { get => armadura; set => armadura = value; }
        public int Salud { get => salud; set => salud = value; }

        // Constructor sin parámetros necesario para la deserialización
        public Caracteristicas() { }

        //Constructor
        public Caracteristicas(int velocidad, int destreza, int fuerza, int nivel, int armadura, int salud)
        {
            this.velocidad = velocidad;
            this.destreza = destreza;
            this.fuerza = fuerza;
            this.nivel = nivel;
            this.armadura = armadura;
            this.salud = salud;
        }
    }

    public class Personaje
    {
        Datos datos;
        Caracteristicas caracteristicas;

        public Datos Datos { get => datos; set => datos = value; }
        public Caracteristicas Caracteristicas { get => caracteristicas; set => caracteristicas = value; }

        // Constructor sin parámetros necesario para la deserialización
        public Personaje() { }

        //Constructor
        public Personaje(string nombre, string tipo, string apodo, DateTime fechaNacimiento, int edad, int velocidad, int destreza, int fuerza, int nivel, int armadura, int salud)
        {
            Datos = new Datos(nombre, tipo, apodo, fechaNacimiento, edad);
            Caracteristicas = new Caracteristicas(velocidad, destreza, fuerza, nivel, armadura, salud);
        }

        public void MostrarPersonaje()
        {
            Console.WriteLine("Datos del Personaje:");
            Console.WriteLine("Nombre: " + Datos.Nombre);
            Console.WriteLine("Tipo: " + Datos.Tipo);
            Console.WriteLine("Apodo: " + Datos.Apodo);
            Console.WriteLine("Fecha de Nacimiento: " + Datos.FechaNacimiento.ToShortDateString());
            Console.WriteLine("Edad: " + Datos.Edad);

            Console.WriteLine("\nCaracterísticas del Personaje:");
            Console.WriteLine("Velocidad: " + Caracteristicas.Velocidad);
            Console.WriteLine("Destreza: " + Caracteristicas.Destreza);
            Console.WriteLine("Fuerza: " + Caracteristicas.Fuerza);
            Console.WriteLine("Nivel: " + Caracteristicas.Nivel);
            Console.WriteLine("Armadura: " + Caracteristicas.Armadura);
            Console.WriteLine("Salud: " + Caracteristicas.Salud);
        }
    }
}