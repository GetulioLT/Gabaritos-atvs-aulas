/*
   Escreva um programa que lê o tamanho do lado de um quadrado e imprime um quadrado daquele tamanho com 
    asteriscos. Seu programa deve usar laços de repetição e funcionar para quadrados com lados de todos 
    os tamanhos entre 1 e 20.
 */
using System;

namespace Avaliação
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Vamos fazer um quadrado de asteriscos?");
            Console.WriteLine();

            /*================ Váriaveis ================*/

            int lado;
            int i = 0;
            int j = 0;

            /*===========================================*/

            /*============ Entrada de Dados =============*/

            Console.WriteLine("Para isso digite o valor do lado do quadrado");
            Console.Write("");
            lado = int.Parse(Console.ReadLine());

            /*===========================================*/

            /*========= Processamento de Dados ==========*/

            while(j < lado)
            {

                /*============= Saída de Dados ==============*/

                while (i < lado)
                {
                    Console.Write("*");
                    i++;
                }
                Console.WriteLine();

                /*===========================================*/

                j++;

                i = 0;
            }

            /*===========================================*/

            Console.ReadLine();

        }     
        
    }
}
