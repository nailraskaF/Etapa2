
Console.WriteLine("cuantos hicieron el examen:");
int Candidatos = int.Parse(Console.ReadLine());

int[] puntajes = new int[Candidatos];

for (int i = 0; i < Candidatos; i++)
{
    Console.WriteLine($"que puntaje tuvo el candidato {i + 1}:");
    puntajes[i] = int.Parse(Console.ReadLine());
}

Array.Sort(puntajes);

Console.WriteLine("Ingrese un número entero para filtrar los puntajes múltiplos de ese número:");
int Filtro = int.Parse(Console.ReadLine());

int[] puntajesFiltrados = new int[Candidatos];
int contadorFiltrados = 0;

for (int i = 0; i < Candidatos; i++)
{
    if (puntajes[i] % Filtro == 0)
    {
        puntajesFiltrados[contadorFiltrados] = puntajes[i];
        contadorFiltrados++;
    }
}

Console.WriteLine("Puntajes ordenados de menor a mayor:");
for (int i = 0; i < Candidatos; i++)
{
    Console.WriteLine(puntajes[i]);
}

Console.WriteLine($"\nPuntajes que son múltiplos de {Filtro}:");
if (contadorFiltrados > 0)
{
    for (int i = 0; i < contadorFiltrados; i++)
    {
        Console.WriteLine(puntajesFiltrados[i]);
    }
}
else
{
    Console.WriteLine("No hay puntajes que sean múltiplos del número especificado.");
}

Console.ReadKey();

