/*
 * Faça uma calculadora para as operações básicas 
 * (soma, subtração, multiplicação e divisão), utilizando 
 * uma class calculadora e apenas métodos com o mesmo nome: 
 * “public void calculo()” e que retorne uma mensagem com o 
 * resultado da operação.
 */

using System;

namespace Avaliação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string operacao;

            Console.WriteLine("Calculadora de operações basicas: soma, subtração, multiplicação e divisão\n" +
                "Qual a operação desejada?");
            operacao = Console.ReadLine();

            //Intancia do objeto da classe Calculadora
            Calculadora calculadora = new Calculadora(operacao);

            Console.ReadLine();
        }
    }
}