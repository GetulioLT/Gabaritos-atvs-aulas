/*
   Declare uma lista de 10 posições e atribua valor 0 para todos os elementos que 
    possuírem valores negativos.

 */
using System;
using System.Collections.Generic;

namespace Avaliação
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*================ Váriaveis ================*/

            int[] listas = new int[10];
            int j = 0;


            /*===========================================*/

            /*============ Entrada de Dados =============*/

            listas[0] = 1;
            listas[1] = 2;
            listas[2] = -3;
            listas[3] = 4;
            listas[4] = -5;
            listas[5] = 6;
            listas[6] = -7;
            listas[7] = 8;
            listas[8] = -9;
            listas[9] = 10;

            /*===========================================*/

            /*========= Processamento de Dados ==========*/

            foreach (int i in listas)
            {
                
                if (i < 0)
                {
                    listas[j] = 0;
                }
                j++;
            }

            /*===========================================*/

            /*============= Saída de Dados ==============*/

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(listas[i]);
            }

            /*===========================================*/

            Console.ReadLine();
        }
    }
}