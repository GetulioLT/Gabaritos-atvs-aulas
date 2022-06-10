/*
   Faça um programa que receba um número e usando laços de repetição calcule e mostre a tabuada desse número. 
    Usar tabela de multiplicação e divisão até o número 10.
 */
using System;

namespace Avaliação
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("vamos mostrar uma tabuada de multiplicação e divisão de um numero?");
            Console.WriteLine();

            /*================ Váriaveis ================*/

            float numero;
            float multi;
            float divi;

            /*===========================================*/

            /*============ Entrada de Dados =============*/

            Console.WriteLine("Digite o numero:");
            Console.Write("");
            numero = float.Parse(Console.ReadLine());


            Console.WriteLine();

            /*===========================================*/

            /*========= Processamento de Dados ==========*/

            Console.WriteLine($"a tabuada de multiplicação do {numero} é:");
            
            for (int i = 1; i < 11; i++)
            {
                multi = numero * i;

                /*============= Saída de Dados ==============*/

                Console.WriteLine($"{numero} * {i} = {multi.ToString("0.00")}");

                /*===========================================*/

            }

            Console.WriteLine();
            Console.WriteLine($"a tabuada de divisão do {numero} é:");

            for (int i = 1; i < 11; i++)
            {
                divi = numero / i;

                /*============= Saída de Dados ==============*/

                Console.WriteLine($"{numero} * {i} = {divi.ToString("0.00")}");

                /*===========================================*/

            }
                   
            Console.ReadLine();

        }
    }
}