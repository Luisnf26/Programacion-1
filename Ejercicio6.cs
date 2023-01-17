int num;
Console.WriteLine("Ingrese un número entero de tres dígitos: ");
num = int.Parse(Console.ReadLine());

int firstDigit = num / 100;
int secondDigit = (num / 10) % 10;
int thirdDigit = num % 10;

if (firstDigit % secondDigit == 0 || firstDigit % thirdDigit == 0)
{
    Console.WriteLine("El primer dígito es múltiplo de algún otro dígito");
}
else if (secondDigit % firstDigit == 0 || secondDigit % thirdDigit == 0)
{
    Console.WriteLine("El segundo dígito es múltiplo de algún otro dígito");
}
else if (thirdDigit % firstDigit == 0 || thirdDigit % secondDigit == 0)
{
    Console.WriteLine("El tercer dígito es múltiplo de algún otro dígito");
}
else
{
    Console.WriteLine("Ningún dígito es múltiplo de algún otro dígito");
}


