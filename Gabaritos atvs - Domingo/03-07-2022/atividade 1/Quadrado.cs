using System;

//Herança da Classe Figura

class Quadrado : Figura
{

    /*================== Métodos =================*/

    public static double Calculo()
    {
        Console.WriteLine("Digite o valor do lado:");
        bas = double.Parse(Console.ReadLine());

        return Math.Pow(bas, 2);
    }

    /*============================================*/

}