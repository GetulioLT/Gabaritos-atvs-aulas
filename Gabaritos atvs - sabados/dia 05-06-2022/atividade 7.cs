/*
    Avaliação Lógica de Programação em C#
    Atividade dia: 05/06/2022  Desvios Condicionais.
    Questão 7: Desenvolva um algoritmo que solicite o preço de três produtos e informe
    qual produto deve ser comprado, sabendo que a decisão é sempre pelo mais barato.
 */
using System;

namespace Avaliação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Comparação de preços e melhor escolha");
            Console.WriteLine();

            /*================ Váriaveis ================*/

            float preco1;
            float preco2;
            float preco3;

            /*===========================================*/

            /*============ Entrada de Dados =============*/

            Console.WriteLine("Preço do primeiro produto:");
            Console.Write("");
            preco1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Preço do segundo produto:");
            Console.Write("");
            preco2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Preço do terceiro produto:");
            Console.Write("");
            preco3 = float.Parse(Console.ReadLine());

            Console.WriteLine();

            /*===========================================*/

            /*========= Processamento de Dados ==========*/

            if (preco1 < preco2 && preco1 < preco3)
            {

                /*============= Saída de Dados ==============*/

                Console.WriteLine($"A melhor compra é o {preco1}");

                /*===========================================*/

            }
            else if (preco2 < preco1 && preco2 < preco3)
            {

                /*============= Saída de Dados ==============*/

                Console.WriteLine($"A melhor compra é o {preco2}");

                /*===========================================*/

            }
            else
            {

                /*============= Saída de Dados ==============*/

                Console.WriteLine($"A melhor compra é o {preco3}");

                /*===========================================*/

            }

            Console.ReadLine();
        }
    }
}