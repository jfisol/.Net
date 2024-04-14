Console.WriteLine("Funciones");
int numeroA = 10;
int numeroB = 10;

int suma(int nA, int nB)
{
    return (nA + nB);
}

int resta(int nA, int nB)
{
    return (nA - nB);
}


int resultadoSuma = suma(numeroA, numeroB);
int resultadoResta = resta(numeroA, numeroB);

Console.WriteLine($"Rasultado Suma {resultadoSuma}\nResultado Resta: {resultadoResta}");