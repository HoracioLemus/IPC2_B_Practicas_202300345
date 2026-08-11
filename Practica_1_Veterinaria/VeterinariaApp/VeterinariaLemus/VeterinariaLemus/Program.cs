using VeterinariaLemus;

List<Mascota> mascotas = new List<Mascota>();
bool salir = false;

while (!salir)
{
    Console.WriteLine("Bienvenido a la Veterinaria Lemus");
    Console.WriteLine("1. Registrar Mascota");
    Console.WriteLine("2. Mostrar Información de Mascotas");
    Console.WriteLine("3. Calcular Dosis de Medicamento");
    Console.WriteLine("4. Salir");
    Console.Write("Seleccione una opción: ");
    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            RegistrarMascota(mascotas);
            break;
        case "2":
            MostrarInformacionMascotas(mascotas);
            break;
        case "3":
            CalcularDosisMedicamento(mascotas);
            break;
        case "4":
            salir = true;
            break;
        default:
            Console.WriteLine("Opción inválida. Intente nuevamente.");
            break;
    }
}

//Metodos del menu
void RegistrarMascota(List<Mascota> mascotas)
{
    Console.WriteLine("Seleccione el tipo de mascota a registrar:");
    Console.WriteLine("1. Perro");
    Console.WriteLine("2. Gato");
    Console.WriteLine("3. Ave");
    Console.WriteLine("4. Tortuga");
    Console.Write("Opción: ");
    string tipoMascota = Console.ReadLine();

    Console.Write("Ingrese el nombre: ");
    string nombre = Console.ReadLine();
    Console.Write("Ingrese el peso (kg): ");
    double peso = Convert.ToDouble(Console.ReadLine());
    Console.Write("Ingrese el sexo (M/F): ");
    string sexo = Console.ReadLine();
    Console.Write("Ingrese la edad (años): ");
    int edad = Convert.ToInt32(Console.ReadLine());
    Console.Write("Ingrese el nombre del propietario: ");
    string propietario = Console.ReadLine();

    switch (tipoMascota)
    {
        case "1":
            Console.Write("Ingrese la raza: ");
            string raza = Console.ReadLine();
            mascotas.Add(new Perro(nombre, peso, sexo, edad, propietario, raza));
            break;
        case "2":
            Console.Write("¿Está esterilizado? (S/N): ");
            bool esterilizado = Console.ReadLine().ToUpper() == "S";
            mascotas.Add(new Gato(nombre, peso, sexo, edad, propietario, esterilizado));
            break;
        case "3":
            Console.Write("¿Puede volar? (S/N): ");
            bool puedeVolar = Console.ReadLine().ToUpper() == "S";
            mascotas.Add(new Ave(nombre, peso, sexo, edad, propietario, puedeVolar));
            break;
        case "4":
            Console.Write("Ingrese el tipo de caparazón: ");
            string tipoCaparazon = Console.ReadLine();
            mascotas.Add(new Tortuga(nombre, peso, sexo, edad, propietario, tipoCaparazon));
            break;
        default:
            Console.WriteLine("Tipo de mascota inválido.");
            break;
    }
}

void MostrarInformacionMascotas(List<Mascota> mascotas)
{
    if (mascotas.Count == 0)
    {
        Console.WriteLine("No hay mascotas registradas.");
        Console.WriteLine("Presione Enter para regresar al menú...");
        Console.ReadLine();
        return;
    }

    foreach (var mascota in mascotas)
    {
        mascota.MostrarInfo();
        Console.WriteLine("---------------------------");
        Console.WriteLine("Presione Enter para continuar...");
        Console.ReadLine();
    }
}

void CalcularDosisMedicamento(List<Mascota> mascotas)
{
    if (mascotas.Count == 0)
    {
        Console.WriteLine("No hay mascotas registradas.");
        Console.WriteLine("Presione Enter para regresar al menú...");
        Console.ReadLine();
        return;
    }

    Console.WriteLine("Seleccione la mascota para calcular la dosis:");
    for (int i = 0; i < mascotas.Count; i++) Console.WriteLine($"{i + 1}. Código: {mascotas[i].Codigo} , Nombre: {mascotas[i].Nombre}");
    Console.Write("Opción: ");
    int opcion = Convert.ToInt32(Console.ReadLine()) - 1;

    if (opcion < 0 || opcion >= mascotas.Count)
    {
        Console.WriteLine("Opción inválida.");
        return;
    }

    Mascota mascotaSeleccionada = mascotas[opcion];
    Console.Write("Ingrese la dosis por kg: ");
    double dosisPorKg = Convert.ToDouble(Console.ReadLine());

    double dosisTotal = mascotaSeleccionada.CalcularDosis(dosisPorKg);
    Console.WriteLine($"La dosis total para {mascotaSeleccionada.Nombre} es: {dosisTotal} mg");
    Console.WriteLine("Presione Enter para regresar al menú...");
    Console.ReadLine();
}