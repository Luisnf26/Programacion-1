int num1, num2, num3;

Console.Write("Ingrese el primer número: ");
num1 = int.Parse(Console.ReadLine());

Console.Write("Ingrese el segundo número: ");
num2 = int.Parse(Console.ReadLine());

Console.Write("Ingrese el tercer número: ");
num3 = int.Parse(Console.ReadLine());

if (num1 > num2 && num1 > num3)
{
    Console.WriteLine("El número mayor es: " + num1);
}
else if (num2 > num1 && num2 > num3)
{
    Console.WriteLine("El número mayor es: " + num2);
}
else
{
    Console.WriteLine("El número mayor es: " + num3);
}


