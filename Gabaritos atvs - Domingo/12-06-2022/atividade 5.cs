/*
    Faça um programa que receba várias idades e que calcule e mostre a média das 
    idades digitadas. Finalize digitando a idade igual a zero.
 */
using System;

namespace Avaliação
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Calculo de media de varias idade em seguida:");
            Console.WriteLine();

            /*================ Váriaveis ================*/

            float idade = 1;
            float idade2 = 0;
            float media;
            float i = 1;

            /*===========================================*/

            /*========= Processamento de Dados ==========*/

            while (idade != 0)
            {

                /*============ Entrada de Dados =============*/

                Console.Write("Digite a idade: ");
                idade = float.Parse(Console.ReadLine());

                /*===========================================*/

                media = (idade + idade2) / i;

                /*============= Saída de Dados ==============*/

                Console.WriteLine($"Media atual: {media.ToString("0.00")}");

                /*===========================================*/

                idade2 = media;
                i++;

            }
            
            /*===========================================*/

            Console.ReadLine();

        }     
        
    }
}
