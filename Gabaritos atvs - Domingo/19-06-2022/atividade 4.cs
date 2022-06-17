/*
    Leia uma matriz 5 x 5. Leia também um valor X. O programa deverá fazer uma busca 
    desse valor na matriz e, ao final escrever a localização (linha e coluna) ou uma 
    mensagem de “não encontrado”
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

            int[,] b = new int[,]
            {
                {1, 2, 3, 4, 5},
                {6, 7, 8, 9, 10},
                {11, 12, 13, 14, 15},
                {16, 17, 18, 19, 20},
                {21, 22, 23, 24, 25},
            };
            int k = 0;
            int j = 0;
            int x = 0;

            /*===========================================*/

            /*============ Entrada de Dados =============*/

            Console.WriteLine("Digite um numero para localizar na matriz:");
            Console.Write("");
            x = int.Parse(Console.ReadLine());

            /*===========================================*/

            /*========= Processamento de Dados ==========*/

            foreach  (int i in b)
            {
                if (i == x)
                {

                    /*============= Saída de Dados ==============*/

                    Console.WriteLine($"O numero: {x} está na posição: [{j},{k}]");

                    /*===========================================*/

                    goto to;

                }
                if (k == 5)
                {
                    j++;
                    k = 0;
                }
                k++;
            }

            /*===========================================*/

            Console.WriteLine("Numero não encontrado");

            to:
            Console.ReadLine();
        }
    }
}