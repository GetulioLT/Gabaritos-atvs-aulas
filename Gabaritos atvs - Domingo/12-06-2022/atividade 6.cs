/*
    Escreva um aplicativo que recebe inteiro e mostra os números pares e 
    ímpares (separados), de 1 até esse inteiro.
 */
using System;

namespace Avaliação
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um numero para mostrar os numeros impares e pares");

            /*================ Váriaveis ================*/

            int num;
            int i = 1;

            /*===========================================*/


            /*============ Entrada de Dados =============*/

            retu:

            Console.WriteLine("Digite um numero positivo");
            Console.Write("");
            num = int.Parse(Console.ReadLine());

            /*===========================================*/

            

            /*========= Processamento de Dados ==========*/

            if (num < 0)
            {
                goto retu;
            }
            else
            {

                Console.WriteLine("impar   par");

                while (i <= num)
                {
                    float x = i % 2;

                    if (x == 0)
                    {

                        /*============= Saída de Dados ==============*/

                        Console.Write($"       {i}");
                        Console.WriteLine();

                        /*===========================================*/

                    }
                    else
                    {

                        /*============= Saída de Dados ==============*/

                        Console.Write($"{i}");

                        /*===========================================*/

                    }
                    i++;
                }
            }
            
            /*===========================================*/

            Console.ReadLine();

        }

    }
}