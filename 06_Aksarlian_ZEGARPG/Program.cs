Console.WriteLine("Ingrese la cantidad de elementos que desea analizar:");
int cantidadElementos = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el valor mínimo que deben tener los objetos:");
int valorMinimo = int.Parse(Console.ReadLine());

int[] valoresObjetos = new int[cantidadElementos];

for (int i = 0; i < cantidadElementos; i++)
{
    Console.WriteLine($"Ingrese el valor del objeto {i + 1}:");
    valoresObjetos[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Las posiciones de los objetos con valor mayor al mínimo son:");
for (int i = 0; i < cantidadElementos; i++)
{
    if (valoresObjetos[i] > valorMinimo)
    {
        Console.WriteLine($"Objeto {i + 1} con valor {valoresObjetos[i]}");
    }
}

Console.ReadKey();

