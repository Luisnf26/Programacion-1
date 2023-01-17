using System;

Console.WriteLine("Ingrese el primer número entero de dos dígitos: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo número entero de dos dígitos: ");
int num2 = int.Parse(Console.ReadLine());
int sum = num1 + num2;
if (sum % 2 == 0)
    Console.WriteLine("La suma es un número par.");
else
    Console.WriteLine("La suma no es un número par.");


