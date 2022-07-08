using System;

//Herança da classe Figura, copiado todos os atributos dessa classe
class Triagulo : Figura
{

    /*================== Métodos =================*/

    /*Método estatico, não tem a necessidade de ter o objeto 
     *instanciado para ser iniciado*/
    public static double Calculo()
    {
        Console.WriteLine("Digite o valor da base:");
        bas = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor da altura:");
        alt = double.Parse(Console.ReadLine());


        return bas * alt / 2;
    }

    /*============================================*/

}