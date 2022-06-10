/*
   Faça um programa que verifique e mostre os números entre 1.000 e 2.000 (inclusive) 
    que, quando divididos por 11, produzam o resto igual a 2.
 */
using System;

namespace Avaliação
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Tabela de numeros divisiveis por 11 entre 1000-2000");
            Console.WriteLine();

            /*================ Váriaveis ================*/

            int m;
            float m2 = 2000;
            float resul;

            /*===========================================*/

            /*============ Entrada de Dados =============*/

            /*===========================================*/

            /*========= Processamento de Dados ==========*/

            for (m = 1000; m <= m2; m++)
            {
                resul = m % 11;

                if(resul == 2)
                {

                    /*============= Saída de Dados ==============*/

                    Console.WriteLine(m);

                    /*===========================================*/

                }
            }

            /*===========================================*/

            Console.ReadLine();

        }     
        
    }
}
