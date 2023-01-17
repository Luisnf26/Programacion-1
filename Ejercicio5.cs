Console.WriteLine("Ingrese un número entero de tres dígitos: ");
int num = int.Parse(Console.ReadLine());
int digito1 = num / 100;
int digito2 = (num % 100) / 10;
int digito3 = (num % 100) % 10;
int mayor = digito1;
if (digito2 > mayor)
{
    mayor = digito2;
    Console.WriteLine("El mayor digito esta en la posicion 2");
}
else if (digito3 > mayor)
{
    mayor = digito3;
    Console.WriteLine("El mayor digito esta en la posicion 3");
}
else
    Console.WriteLine("El mayor digito esta en la posicion 1");


