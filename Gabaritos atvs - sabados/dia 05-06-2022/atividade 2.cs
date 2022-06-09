/*
    Avaliação Lógica de Programação em C#
    Atividade dia: 05/06/2022  Desvios Condicionais.
    Questão 2: A cancela de um estabelecimento, em momento de pandemia, funciona 
    dependendo da temperatura aferida e registrada pelo recepcionista do local. 
    É preciso criar um algoritmo para liberar ou não a cancela dependendo da temperatura 
    corporal. Com um medidor o recepcionista irá aferir e registrar no sistema e o algoritmo 
    deverá liberar caso a temperatura seja <= 37 e não liberar caso a temperatura 
    seja maior que 37º.
    A cancela só recebe True ou False (True para liberar e False para bloquear). 
 */
using System;

namespace Avaliação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos fazer a medição da sua temperatura");
            Console.WriteLine();

            /*================ Váriaveis ================*/

            float temperatura;
            bool passagem;

            /*===========================================*/

            /*============ Entrada de Dados =============*/

            Console.WriteLine("Digite a temperatura");
            Console.Write("");
            temperatura = float.Parse(Console.ReadLine());
            Console.WriteLine();

            /*===========================================*/

            /*========= Processamento de Dados ==========*/

            if(temperatura <= 37)
            {
                
                passagem = true;

                /*============= Saída de Dados ==============*/

                Console.WriteLine($"{passagem}, Você esta liberado");


                /*===========================================*/

            }
            else
            {

                passagem = false;

                /*============= Saída de Dados ==============*/

                Console.WriteLine($"{passagem}, Você não pode passar");

                /*===========================================*/

            }

            /*===========================================*/

            Console.ReadLine();
        }
    }
}