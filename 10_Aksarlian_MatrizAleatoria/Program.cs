Console.WriteLine("Ingrese el número de filas:");
int Filas = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el número de columnas:");
int Columnas = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el valor mínimo:");
int valorMinimo = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el valor máximo:");
int valorMaximo = int.Parse(Console.ReadLine());

if (valorMaximo <= valorMinimo)
{
    Console.WriteLine("El valor máximo debe ser mayor que el valor mínimo");
    return;
}

int[,] matriz = new int[Filas, Columnas];
Random random = new Random();

for (int i = 0; i < Filas; i++)
{
    for (int j = 0; j < Columnas; j++)
    {
        matriz[i, j] = random.Next(valorMinimo, valorMaximo + 1);
    }
}

Console.WriteLine("Matriz con valores aleatorios entre {0} y {1}:", valorMinimo, valorMaximo);
for (int i = 0; i < Filas; i++)
{
    for (int j = 0; j < Columnas; j++)
    {
        Console.Write(matriz[i, j] + " ");
    }
    Console.WriteLine();
}
Console.ReadLine();
