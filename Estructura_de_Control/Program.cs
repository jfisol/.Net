// See https://aka.ms/new-console-template for more information
Console.WriteLine("Estructuras de control!");


//Ejemplo de estructura de control condicional

int edad = 18;
Console.WriteLine("Estructuras de control condicional\n");

if (edad == 18)
{
    Console.WriteLine("Usted es mayor de edad");

}
else
{
    Console.WriteLine("Usted es menor de edad");

}
Console.WriteLine("-------------------------------------------");

//Operadores logicos


//int eda = 19;
Boolean inscrito = true;
Console.WriteLine("Estructuras de control logico\n");

if ((edad >= 18) && (inscrito == true))
{
    Console.WriteLine("El sujeto es mayor de edad y esta inscrito");
}
else if((edad < 18) && (inscrito == true))
{
    Console.WriteLine("El sujeto es menor de edad y esta inscrito");
}
else if((edad > 18) && (inscrito != true))
{
    Console.WriteLine("El sujeto es mayor de edad y no esta inscrito");
}
else
{
    Console.WriteLine("No cumple con ningun requisito");
}

Console.WriteLine("---------------------------------------------\n");

Console.WriteLine("Sentencia switch\n");

int menu = 2;
switch (menu)
{
    case 1:
        Console.WriteLine("Menu de amburguesas");
        break;
    case 2:
        Console.WriteLine("Combo de alitas");
        break ;
    case 3:
        Console.WriteLine("Combo de Pollo");
        break;

    default:
        Console.WriteLine("No existe esa opcion en el menu");
        break;
}

//While

Console.WriteLine("\nCiclo While\n");

int numero =0;

while(numero <= 3)
{
    if(numero == 3)
    {
        Console.WriteLine($"Numero cumplio con su condicion {numero}");

    }
    else
    {
        Console.WriteLine($"Numero con valor {numero}");

    }
    numero++;
}


Console.WriteLine("\n Ciclo Do While\n");
int numero1 = 0;
do
{
    if (numero1 >= 3)
    {
        Console.WriteLine($"el valor del numero esta excedido {numero1}");

    }
    else
    {
        Console.WriteLine($"Numero con valor {numero1}");

    }
    numero1++;
} while (numero1<=3);


Console.WriteLine("\n Bucle For\n");

int numero2 = 5;

for (int i = 0; i <= numero2; i++)
{
        Console.WriteLine($"indice [{i}] el valor del numero : {i+1}");

       
   
   // i++;

}


Console.ReadLine();












