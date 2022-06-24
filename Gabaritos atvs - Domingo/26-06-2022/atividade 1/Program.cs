/*
    Faça um programa que peça os 3 lados de um triângulo. O programa deverá informar se os valores 
    podem ser um triângulo. Indique, caso os lados formem um triângulo, se o mesmo é: equilátero, 
    isósceles ou escaleno. 
    Dicas: 
    Três lados formam um triângulo quando a soma de quaisquer dos dois lados é maior que o terceiro.
    Triângulo Equilátero: três lados iguais;
    Triângulo Isósceles: quaisquer dois lados iguais;
    Triângulo Escaleno: três lados diferentes;
    Crie uma classe para essa atividade. Utilize um método para cada resposta e um para saber se é um triângulo.
*/
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos descobrir que tipo de triangulo se forma com tres retas?");

            /*================ Váriaveis ================*/

            Trian trian = new Trian();

            /*===========================================*/

            /*============ Entrada de Dados =============*/

            Console.WriteLine("Priemiro preciso que digite as tres retas");
            Console.WriteLine("Digite o primeiro valor:");
            trian.l1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            trian.l2 = float.Parse(Console.ReadLine());
            Console.WriteLine("E finalizando o ultimo valor:");
            trian.l3 = float.Parse(Console.ReadLine());

            /*===========================================*/

            /*========= Processamento de Dados ==========*/

            trian.menNegacao();
            trian.equi();
            trian.isoc();
            trian.esca();

            /*===========================================*/

            /*============= Saída de Dados ==============*/

            trian.mensagem();

            /*===========================================*/
            
            Console.ReadLine();
        }
    }
}
