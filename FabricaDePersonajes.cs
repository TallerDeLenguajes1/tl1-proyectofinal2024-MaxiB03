using EspacioPersonaje;

namespace GeneracionDePersonajes
{
    public class FabricaDePersonajes
    {
        Random random = new Random();
        List<string> nombresUsados = new List<string>();

        public Personaje CrearPersonaje()
        {
            string nombre = GenerarNombre();
            string tipo = GenerarTipo(nombre);
            string apodo = GenerarApodo(nombre);
            int edad = random.Next(20, 300);
            var fechaNacimiento = DateTime.Now.AddYears(-edad);
            int velocidad = random.Next(1, 11);
            int destreza = random.Next(1, 6);
            int fuerza = random.Next(1, 11);
            int nivel = random.Next(1, 11);
            int armadura = random.Next(1, 11);
            int salud = 100;

            return new Personaje(nombre, tipo, apodo, fechaNacimiento, edad, velocidad, destreza, fuerza, nivel, armadura, salud);
        }

        private string GenerarNombre()
        {
            string[] nombres = {"Liu Kang", "Kung Lao", "Johnny Cage", "Cyrax", "Sektor", "Scorpion", "Sub-Zero", "Raiden", "Fujin", "Shinnok"};
            string nombre;

            do
            {
                nombre = nombres[random.Next(nombres.Length)];
            } while (nombresUsados.Contains(nombre));

            nombresUsados.Add(nombre);
            return nombre;
        }

        private string GenerarTipo(string nombre)
        {
            string tipo="";

            switch (nombre)
            {
                case "Liu Kang":
                case "Kung Lao":
                case "Johnny Cage":
                    tipo = "Humano";
                    break;
                case "Cyrax":
                case "Sektor":
                    tipo = "Cyborg";
                    break;
                case "Scorpion":
                case "Sub-Zero":
                    tipo = "Criatura";
                    break;
                case "Raiden":
                case "Fujin":
                case "Shinnok":
                    tipo = "Dios";
                    break;
            }

            return tipo;
        }

        private string GenerarApodo(string nombre)
        {
            string apodo="";

            switch (nombre)
            {
                case "Liu Kang":
                    apodo = "El Campeon";
                    break;
                case "Kung Lao":
                    apodo = "Guerrero Shaolin";
                    break;
                case "Johnny Cage":
                    apodo = "Estrella de Hollywood";
                    break;
                case "Cyrax":
                    apodo = "Destructor";
                    break;
                case "Sektor":
                    apodo = "Exterminador";
                    break;
                case "Scorpion":
                    apodo = "Espectro Vengador";
                    break;
                case "Sub-Zero":
                    apodo = "Maestro Lin Kuei";
                    break;
                case "Raiden":
                    apodo = "Dios del Trueno";
                    break;
                case "Fujin":
                    apodo = "Maestro del Aire";
                    break;
                case "Shinnok":
                    apodo = "Dios Oscuro";
                    break;
            }

            return apodo;
        }

    }
}