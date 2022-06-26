/*
    Faça um programa que receba a idade de 15 pessoas e que calcule e mostre:
    a) A quantidade de pessoas em cada faixa etária;
    b) A percentagem de pessoas na primeira e na última faixa etária, com relação ao total de pessoas: 
    Até 15 anos
    De 16 a 30 anos
    De 31 a 45 anos
    De 46 a 60 anos
    Acima de 61 anos
 */
using System;

namespace Avaliação
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Vamos fazer uma prática utilizando idades?");

            /*================ Váriaveis ================*/

            Idade idade = new Idade();

            /*===========================================*/

            /*============ Entrada de Dados =============*/

            idade.pessoa();

            /*===========================================*/

            /*============= Saída de Dados ==============*/

            idade.mensagem();

            /*===========================================*/

            Console.ReadLine();
        }

    }
}