int numero;
Console.Write("Ingrese un número entero de cuatro dígitos: ");
numero = int.Parse(Console.ReadLine());

string numeroString = numero.ToString();
if (numeroString[1] == numeroString[3])
{
    Console.WriteLine("El segundo dígito es igual al penúltimo.");
}
else
{
    Console.WriteLine("El segundo dígito no es igual al penúltimo.");
}


