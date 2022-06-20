/*
    Escreva um algoritmo que solicite ao usuário a entrada de 5 números, 
    e que exiba o somatório desses números na tela. Após exibir a soma, 
    o programa deve mostrar também os números que o usuário digitou, 
    um por linha.  
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

            Dictionary<int, int> dic = new Dictionary<int, int>();
            int i = 1;
            int soma = 0;
            int num;

            /*===========================================*/

            /*============ Entrada de Dados =============*/

            while (i < 6)
            {
                Console.WriteLine("Digite um numero");
                Console.Write("");
                num = int.Parse(Console.ReadLine());

                dic.Add(i, num);

                i++;
            }

            /*===========================================*/

            Console.WriteLine("numeros digitados:");

            /*========= Processamento de Dados ==========*/

            foreach (KeyValuePair<int, int> par in dic)
            {

                /*============= Saída de Dados ==============*/

                Console.WriteLine(par.Value);

                /*===========================================*/

                soma = soma + par.Value;
            }

            /*===========================================*/

            /*============= Saída de Dados ==============*/

            Console.WriteLine();
            Console.WriteLine($"soma dos numeros: {soma}");

            /*===========================================*/

            Console.ReadLine();
        }
    }
}