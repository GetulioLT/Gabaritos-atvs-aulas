using System;

class Quadrado : Figura
{
    public static double Calculo()
    {
        Console.WriteLine("Digite o valor do lado:");
        bas = double.Parse(Console.ReadLine());

        return Math.Pow(bas, 2);
    }
}