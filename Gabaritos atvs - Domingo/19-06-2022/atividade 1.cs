/*
   Declare uma lista com 6 posições e em seguida declare também dois valores X e Y 
    quaisquer correspondentes a duas posições na lista. Ao final, seu programa deverá 
    escrever a soma dos valores encontrados nas respectivas posições X e Y.
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

            int[] numeros = new int[6];
            int x = 0;
            int y = 0;

            /*===========================================*/

            /*============ Entrada de Dados =============*/

            Console.WriteLine("Digite duas posições de 0 até 5");
            Console.Write("");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero");
            Console.Write("");
            y = int.Parse(Console.ReadLine());

            numeros[0] = 1;
            numeros[1] = 2;
            numeros[2] = 3;
            numeros[3] = 4;
            numeros[4] = 5;
            numeros[5] = 6;

            /*===========================================*/

            /*========= Processamento de Dados ==========*/

            

            /*===========================================*/

            /*============= Saída de Dados ==============*/

            Console.WriteLine($"A soma das posições {x}({numeros[x]}) e {y}({numeros[y]}) é igual a {numeros[x] + numeros[y]}");

            /*===========================================*/

            Console.ReadLine();
        }
    }
}