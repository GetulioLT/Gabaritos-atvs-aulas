/*
    Avaliação Lógica de Programação em C#
    Atividade dia: 05/06/2022  Desvios Condicionais.
    Questão 1: Solicite um número ao usuário e mostre se o número é positivo ou negativo. 
 */
using System;

namespace Avaliação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boa Vamos descobrir se um numero é positivo ou negativo");
            Console.WriteLine();

            /*================ Váriaveis ================*/

            float numero;

            /*===========================================*/

            /*============ Entrada de Dados =============*/

            Console.WriteLine("Digite um numero");
            Console.Write("");
            numero = float.Parse(Console.ReadLine());

            /*===========================================*/

            /*========= Processamento de Dados ==========*/

            if(numero > 0)
            {

                /*============= Saída de Dados ==============*/

                Console.WriteLine("O numero é positivo");

                /*===========================================*/

            }
            else
            {

                /*============= Saída de Dados ==============*/

                Console.WriteLine("O numero é negativo");

                /*===========================================*/

            }

            /*===========================================*/


            Console.ReadLine();
        }
    }
}