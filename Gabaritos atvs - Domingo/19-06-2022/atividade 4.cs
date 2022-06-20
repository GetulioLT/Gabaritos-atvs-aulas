/*
    Declare uma lista de 5 posições e o preencha com os 5 primeiros 
    números ímpares e o escreva.
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

            List<int> list = new List<int>();
            list.Capacity = 5;
            int i = 0;
            int num = 0;

            /*===========================================*/

            

            while (i < 5)
            {

                /*============ Entrada de Dados =============*/

                Console.WriteLine("digite um numero:");
                Console.Write("");
                num = int.Parse(Console.ReadLine());

                /*===========================================*/

                /*========= Processamento de Dados ==========*/

                if (num % 2 != 0)
                {
                    list.Add(num);
                    i++;
                }

                /*===========================================*/

            }

            Console.WriteLine();

            /*============= Saída de Dados ==============*/

            Console.WriteLine("Primeiros 5 numeros impares escristos");

            foreach (int a in list)
            {
                Console.WriteLine(a);
            }

            /*===========================================*/

            Console.ReadLine();
        }
    }
}
