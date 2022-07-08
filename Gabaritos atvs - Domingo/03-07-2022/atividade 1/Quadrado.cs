using System;

//Herança da classe Figura, copiado todos os atributos dessa classe
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