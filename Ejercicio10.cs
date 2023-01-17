int num1, num2, menor, mayor;
Console.Write("Ingrese el primer número entero: ");
num1 = int.Parse(Console.ReadLine());
Console.Write("Ingrese el segundo número entero: ");
num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
{
    mayor = num1;
    menor = num2;
}
else
{
    mayor = num2;
    menor = num1;
}

if ((mayor - menor) <= 10)
{
    Console.Write("Los números comprendidos entre {0} y {1} son: ", menor, mayor);
    for (int i = menor; i <= mayor; i++)
    {
        Console.Write("{0} ", i);
    }
}
else
{
    Console.WriteLine("La diferencia entre los números es mayor a 10.");
}
