using System;

//Herança da Classe Figura
class Circulo : Figura
{

    /*================== Métodos =================*/

    public static double Calculo()
    {
        Console.WriteLine("Digite o valor do raio:");
        dia = double.Parse(Console.ReadLine());

        double calc = Math.PI * Math.Pow(dia, 2);

        return calc;
    }

    /*============================================*/

}