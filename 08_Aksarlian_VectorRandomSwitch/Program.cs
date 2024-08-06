
Console.WriteLine("Ingrese el tamaño del vector:");
int n = int.Parse(Console.ReadLine());

int[] vector = new int[n];
Random random = new Random();

for (int i = 0; i < n; i++)
{
    vector[i] = random.Next(1, 101); // Genera números aleatorios entre 1 y 100
}

bool continuar = true;

while (continuar)
{
    Console.WriteLine("\nSeleccione una opción:");
    Console.WriteLine("1. Imprimir todos los elementos del vector");
    Console.WriteLine("2. Buscar un número en el vector");
    Console.WriteLine("3. Ordenar el vector");
    Console.WriteLine("4. Terminar el programa");
    int opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.Clear();
            Console.WriteLine("Elementos del vector:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(vector[i]);
            }
            break;

        case 2:
            Console.Clear();
            Console.WriteLine("Ingrese el número a buscar:");
            int numeroBuscar = int.Parse(Console.ReadLine());
            bool encontrado = false;

            for (int i = 0; i < n; i++)
            {
                if (vector[i] == numeroBuscar)
                {
                    Console.WriteLine($"El número {numeroBuscar} se encuentra en la posición {i + 1}");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine($"El número {numeroBuscar} no se encuentra en el vector.");
            }
            break;

        case 3:
            Console.Clear();
            Console.WriteLine("Seleccione el orden:");
            Console.WriteLine("1. Ascendente");
            Console.WriteLine("2. Descendente");
            int orden = int.Parse(Console.ReadLine());

            if (orden == 1)
            {
                Array.Sort(vector);
                Console.WriteLine("Vector ordenado en forma ascendente.");
            }
            else if (orden == 2)
            {
                Array.Sort(vector);
                Array.Reverse(vector);
                Console.WriteLine("Vector ordenado en forma descendente.");
            }
            else
            {
                Console.WriteLine("Opción no válida.");
            }
            break;

        case 4:
            Console.Clear();
            continuar = false;
            Console.WriteLine("Terminando el programa.");
            break;

        default:
            Console.WriteLine("Opción no válida.");
            break;
    }
}
Console.ReadLine();