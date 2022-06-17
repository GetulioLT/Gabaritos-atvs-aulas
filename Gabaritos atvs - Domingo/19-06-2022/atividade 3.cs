/*
    Leia uma matriz 3 x 3, conte e escreva quantos valores maiores que 10 ela possui.
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

            int[,] a = new int[3, 3];
            int k = 0;
            int j = 0;
            int num = 0;

            /*===========================================*/

            /*============ Entrada de Dados =============*/

            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("escreva um numero: ");
                Console.Write("");
                a[k,j] = int.Parse(Console.ReadLine());

                j++;
                if (j == 3)
                {
                    k++;
                    j = 0;
                }
            }

            /*===========================================*/

            /*========= Processamento de Dados ==========*/

            foreach (int l in a)
            {
                if (l > 10)
                {
                    num++;
                }
            }

            /*===========================================*/

            /*============= Saída de Dados ==============*/

            Console.WriteLine($"O total de numeros maior que 10 na matriz é: {num}");

            /*===========================================*/

            Console.ReadLine();
        }
    }
}