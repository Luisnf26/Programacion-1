
using System;

Console.WriteLine("Ingrese un número entero de dos dígitos: ");
int num = int.Parse(Console.ReadLine());
if (num < 0)
    Console.WriteLine("El número es negativo.");
bool esPrimo = true;
for (int i = 2; i < num; i++)
{
    if (num % i == 0)
    {
        esPrimo = false;
        break;
    }
}
if (esPrimo)
    Console.WriteLine("El número es primo.");
else
    Console.WriteLine("El número no es primo.");
