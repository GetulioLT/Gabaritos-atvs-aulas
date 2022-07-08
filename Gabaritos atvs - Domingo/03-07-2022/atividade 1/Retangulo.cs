using System;

//Herança da classe Figura, copiado todos os atributos dessa classe
class Retangulo : Figura
{

    /*================== Métodos =================*/

    public static double Calculo()
    {
        Console.WriteLine("Digite o valor da base:");
        bas = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor da altura:");
        alt = double.Parse(Console.ReadLine());

        return bas * alt;
    }

    /*============================================*/

}