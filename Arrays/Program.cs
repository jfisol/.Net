Console.WriteLine("Arrays!");


int[] numeros = {0, 1, 2, 3, 4, 5};


//lectura de numeros
Console.WriteLine($"Numeros {numeros[5]}");

Console.WriteLine();

//LECTURA CON FOR

for ( int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"indice [{i}] valor : {numeros[i]}");
}

Console.Read();