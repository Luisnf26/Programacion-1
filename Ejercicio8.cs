using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número de 5 dígitos: ");
        int num = int.Parse(Console.ReadLine());
        int numInvertido = int.Parse(new string(num.ToString().Reverse().ToArray()));
        if (num == numInvertido)
        {
            Console.WriteLine("El número es Capicúa");
        }
        else
        {
            Console.WriteLine("El número no es Capicúa");
        }
    }
}


