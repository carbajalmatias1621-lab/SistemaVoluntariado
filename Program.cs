  class Program
    {
        private static List<Persona> personas = new List<Persona>();

        static void Main(string[] args)
        {
            while (true)
            {
                MostrarMenuPrincipal();
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        RegistrarVoluntario();
                        break;
                    case "2":
                        RegistrarCoordinador();
                        break;
                    case "3":
                        MostrarTodosLasPersonas();
                        break;
                    case "4":
                        MostrarVoluntarios();
                        break;
                    case "5":
                        MostrarCoordinadores();
                        break;
                    case "6":
                        running = false;
                        Console.WriteLine("novimo");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }

                if (running && opcion != "6")
                {
                    Console.WriteLine("Presione cualquier tecla para continuar");
                    Console.ReadKey();
                }
            }
        }

        static void MostrarMenuPrincipal()
        {
            Console.WriteLine("1. Registrar Voluntario");
            Console.WriteLine("2. Registrar Coordinador");
            Console.WriteLine("4. Mostrar Voluntarios");
            Console.WriteLine("5. Mostrar Coordinadores");
            Console.WriteLine("6. Salir");
            Console.Write("Seleccione una opción: ");
        }

        static void RegistrarVoluntario()
        {
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Apellido: ");
            string apellido = Console.ReadLine();

            Console.Write("DNI: ");
            string documento = Console.ReadLine();


            Voluntario voluntario = new Voluntario(nombre, apellido, documento);

            personas.Add(voluntario);
            Console.WriteLine($"Voluntario registrado exitosamente");
        }

        static void RegistrarCoordinador()
        {
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Apellido: ");
            string apellido = Console.ReadLine();

            Console.Write("DNI: ");
            string documento = Console.ReadLine();

            Coordinador coordinador = new Coordinador(nombre,apellido,documento);
            personas.Add(coordinador);
            Console.WriteLine($"Coordinador registrado exitosamente ");
        }

        static void MostrarVoluntarios()
        {

             List<Voluntario> voluntarios = new List<Voluntario>();

            if (voluntarios.Count == 0)
            {
                Console.WriteLine("No hay voluntarios registrados.");
                return;
            }

            foreach (var voluntario in voluntarios)
            {
                voluntario.MostrarInformacion();
                Console.WriteLine();
            }
        }

        static void MostrarCoordinadores()
        { 

            List<Coordinador> coordinadores = new List<Coordinador>();

            if (coordinadores.Count == 0)
            {
                Console.WriteLine("No hay coordinadores registrados.");
                return;
            }

            foreach (var coordinador in coordinadores)
            {
                coordinador.MostrarInformacion();
                Console.WriteLine();
            }

        }
    }