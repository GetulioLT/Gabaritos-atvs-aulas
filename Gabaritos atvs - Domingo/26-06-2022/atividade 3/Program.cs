/*
    Faça um programa que apresente o menu de opções a seguir:
    Menu de opções:
    1 - Média aritmética
    2 - Média ponderada
    0 - Sair
    Digite a opção desejada:
    Na opção 1: receber duas notas, calcular e mostrar a média aritmética.
    Na opção 2: receber três notas e seus respectivos pesos, calcular e mostrar a média ponderada.
    Na opção 3: sair do programa.  

    Verifique a possibilidade de opção inválida, mostrando uma mensagem.
*/
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que tal fazermos um calculo de média?");

            /*================ Váriaveis ================*/

            Media media = new Media();
            int num;

            /*===========================================*/

            /*============ Entrada de Dados =============*/

            Console.WriteLine("Digite seu nome:");
            media.name = Console.ReadLine();

            re:
            Console.WriteLine("\nQue tipo de media você quer:" +
                "\n1 - Média aritmética" +
                "\n2 - Média ponderada" +
                "\n0 - Sair");
            num = int.Parse(Console.ReadLine());

            /*===========================================*/

            /*========= Processamento de Dados ==========*/

            if (num == 1)
            {
                media.mediaA();
            }
            else if (num == 2)
            {
                media.mediaP();
            }
            else if (num == 0)
            {
                
                goto fin;
            }

            /*===========================================*/

            /*============= Saída de Dados ==============*/

            media.mensagem();

            Console.WriteLine("\nQuer mais alguma coisa?" +
                "\n1 - sim" +
                "\n2 - não");
            num = int.Parse(Console.ReadLine());

            if (num == 1)
            {
                goto re;
            }

            fin:

            Console.WriteLine("\nObrigado por usar nosso sistema, até logo.");

            /*===========================================*/

            Console.ReadLine();
        }
    }
}
