/*
    Faça um programa que calcule as raízes de uma equação do segundo grau, na forma ax2 + bx + c. 
    O programa deverá pedir os valores de a, b e c e fazer as consistências, informando ao usuário 
    nas seguintes situações:  
    a. Se o usuário informar o valor de A igual a zero. A equação não é do segundo grau e o programa 
    deve solicitar um novo valor para A;
    b. Se o delta calculado for negativo, a equação não possui raízes reais. Informe ao usuário e 
    encerre o programa;
    c. Se o delta calculado for igual a zero a equação possui apenas uma raiz real; informe ao usuário;
    d. Se o delta for positivo, a equação possui duas raízes reais; informe-as ao usuário

    Crie uma classe para executar os cálculos e um método para cada cálculo.
    Use a classe Math e o método Sqrt() para encontrar a raiz quadrada. Math.Sqrt(25) = 5.

*/
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que tal fazemos um programa para fazer um calculo com um " +
                "equação do 2 grau?");

            /*================ Váriaveis ================*/

            Calculo calculo = new Calculo();

            /*===========================================*/

            /*============ Entrada de Dados =============*/

            Console.WriteLine("Prmeiramente nós passe os 3 valores referentes as icognitas a, b e c" +
                "\nDigite o valor de a:");
            err1:
            calculo.a = float.Parse(Console.ReadLine());

            if (calculo.a == 0)
            {
                Console.WriteLine("a não pode ser igual a 0 digite Novamente:");
                goto err1;
            }
            Console.WriteLine("Digite b:");
            calculo.b = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite c:");
            calculo.c = float.Parse(Console.ReadLine());

            /*===========================================*/

            /*========= Processamento de Dados ==========*/

            calculo.delta();

            /*===========================================*/

            /*============= Saída de Dados ==============*/

            calculo.mensagem();

            /*===========================================*/

            Console.ReadLine();
        }
    }
}
