/*
    Avaliação Lógica de Programação em C#
    Atividade dia: 05/06/2022  Desvios Condicionais.
    Questão 5: Ler o nome de 2 times e o número de gols marcados na partida (para cada time).
    Escrever o nome do vencedor. Caso não haja vencedor deverá ser impressa a palavra EMPATE.

 
 */
using System;

namespace Avaliação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Resultado de uma partida de futebol");
            Console.WriteLine();

            /*================ Váriaveis ================*/

            string timeA;
            string timeB;
            int golsA;
            int golsB;

            /*===========================================*/

            /*============ Entrada de Dados =============*/

            Console.WriteLine("nome do primeiro time:");
            Console.Write("");
            timeA = Console.ReadLine();

            Console.WriteLine("nome do segundo time:");
            Console.Write("");
            timeB = Console.ReadLine();

            Console.WriteLine($"Gols que o {timeA} fez:");
            Console.Write("");
            golsA = int.Parse(Console.ReadLine());

            Console.WriteLine($"Gols que o {timeB} fez:");
            Console.Write("");
            golsB = int.Parse(Console.ReadLine());

            Console.WriteLine();

            /*===========================================*/

            /*========= Processamento de Dados ==========*/

            if (golsA > golsB)
            {

                /*============= Saída de Dados ==============*/

                Console.WriteLine($"O Time {timeA} venceu o time {timeB} por {golsA} x {golsB}");

                /*===========================================*/

            }
            else if (golsB > golsA)
            {

                /*============= Saída de Dados ==============*/

                Console.WriteLine($"O Time {timeB} venceu o time {timeA} por {golsB} x {golsA}");

                /*===========================================*/

            }
            else
            {

                /*============= Saída de Dados ==============*/

                Console.WriteLine($"O Time {timeA} empatou com time {timeB} por {golsA} x {golsB}");

                /*===========================================*/

            }


            Console.ReadLine();
        }
    }
}