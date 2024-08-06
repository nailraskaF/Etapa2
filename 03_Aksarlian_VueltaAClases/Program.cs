
Console.WriteLine("Ingrese la cantidad de trabajos prácticos (TPs):");
int TPs = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad de exámenes:");
int Examenes = int.Parse(Console.ReadLine());

int[] NotasTP = new int[TPs];
int[] NotasExamenes = new int[Examenes];

for (int i = 0; i < TPs; i++)
{
    Console.WriteLine($"Ingrese la nota del TP {i + 1}:");
    NotasTP[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < Examenes; i++)
{
    Console.WriteLine($"Ingrese la nota del examen {i + 1}:");
    NotasExamenes[i] = int.Parse(Console.ReadLine());
}

double promedioExamenes = 0;
for (int i = 0; i < Examenes; i++)
{
    promedioExamenes += NotasExamenes[i];
}
promedioExamenes /= Examenes;

int tpsAprobados = 0;
for (int i = 0; i < TPs; i++)
{
    if (NotasTP[i] >= 6)
    {
        tpsAprobados++;
    }
}
double porcentajeTPsAprobados = (double)tpsAprobados / TPs * 100;

bool aprobarExamenes = promedioExamenes >= 6;
bool aprobarTPs = porcentajeTPsAprobados >= 75;

if (aprobarExamenes && aprobarTPs)
{
    Console.WriteLine("Phineas y Ferb pueden aprobar la materia.");
}
else
{
    Console.WriteLine("Phineas y Ferb no pueden aprobar la materia.");
}

Console.ReadKey();
