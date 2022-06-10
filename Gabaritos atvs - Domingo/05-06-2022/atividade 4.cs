/*
    Avaliação Lógica de Programação em C#
    Atividade dia: 05/06/2022  Desvios Condicionais.
    Questão 4: A Secretaria de Meio Ambiente que controla o índice de poluição mantém 3 grupos 
    de indústrias que são altamente poluentes do meio ambiente. O índice de poluição aceitável 
    varia de 0,05 até 0,25. Se o índice sobe para 0,3 as indústrias do 1º grupo são intimadas a 
    suspenderem suas atividades, se o índice crescer para 0,4 as indústrias do 1º e 2º grupo são 
    intimadas a suspenderem suas atividades, se o índice atingir 0,5 todos os grupos devem ser 
    notificados a paralisarem suas atividades. Faça um algoritmo que leia o
    índice de poluição medido e emita a notificação adequada aos diferentes grupos de empresas
 
 */
using System;

namespace Avaliação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Medição de indice de poluição:");
            Console.WriteLine();

            /*================ Váriaveis ================*/

            float indice;


            /*===========================================*/

            /*============ Entrada de Dados =============*/

            Console.WriteLine("Digite qual o valor da medição atual:");
            Console.Write("");
            indice = float.Parse(Console.ReadLine());
            

            Console.WriteLine();

            /*===========================================*/

            /*========= Processamento de Dados ==========*/

            if (indice >= 0.05 && indice <= 0.25)
            {

                /*============= Saída de Dados ==============*/

                Console.WriteLine($"Valor da medição: {indice} dentro dos padõres");

                /*===========================================*/

            }
            else if (indice >= 0.3 && indice < 0.4)
            {

                /*============= Saída de Dados ==============*/

                Console.WriteLine($"Valor da medição: {indice} acima dos padões");
                Console.WriteLine("Fechar industrias do 1° grupo");

                /*===========================================*/

            }
            else if (indice >= 0.4 && indice < 0.5)
            {

                /*============= Saída de Dados ==============*/

                Console.WriteLine($"Valor da medição: {indice} acima dos padões");
                Console.WriteLine("Fechar industrias do 1° e 2° grupo");

                /*===========================================*/

            }
            else
            {

                /*============= Saída de Dados ==============*/

                Console.WriteLine($"Valor da medição: {indice} acima dos padões");
                Console.WriteLine("Fechar industrias de todos os 3 grupo");

                /*===========================================*/

            }

            Console.ReadLine();
        }
    }
}