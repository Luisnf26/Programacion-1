using System;

class MainClass
{
    public static bool IsPrime(int number)
    {
        if (number < 2) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a two-digit number: ");
        int number = int.Parse(Console.ReadLine());
        int firstDigit = number / 10;
        int secondDigit = number % 10;
        if (IsPrime(firstDigit) && IsPrime(secondDigit))
        {
            Console.WriteLine("Both digits are prime.");
        }
        else
        {
            Console.WriteLine("Both digits are not prime.");
        }
    }
}

