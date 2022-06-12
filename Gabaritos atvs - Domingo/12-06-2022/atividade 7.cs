/*
    Em uma eleição presidencial existem quatro candidatos. Os votos são informados por meio de código. 
    Os códigos utilizados são:  
    1, 2, 3, 4   - Votos para os respectivos candidatos
    5 - Voto nulo
    6 - Voto em branco
    Faça um programa que calcule e mostre: 
    O total de votos para cada candidato, O total de votos nulos, O total de votos em branco, A percentagem 
    de votos nulos sobre o total de votos, A porcentagem de votos em branco sobre o total de votos. Para 
    finalizar o conjunto de votos, tem-se o valor zero. 

 */
using System;

namespace Avaliação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nessa eleição temos 4 candidatos:");
            Console.WriteLine("para votar digite seu respectivo numero");
            Console.WriteLine("se quiser votar nulo, digite 5 e para voto branco, 6.");


            /*================ Váriaveis ================*/

            float voto = 1;
            float totalVotos;
            int v1 = 0;
            int v2 = 0;
            int v3 = 0;
            int v4 = 0;
            int vN = 0;
            int vB = 0;

            /*===========================================*/

            /*========= Processamento de Dados ==========*/

            for (totalVotos = 1; voto != 0; totalVotos++)
            {

                /*============ Entrada de Dados =============*/

                volt:
                Console.WriteLine("Digite em quem irá votar:");
                Console.Write("");
                voto = float.Parse(Console.ReadLine());

                /*===========================================*/

                switch (voto)
                {
                    case 1:
                        v1++;
                        break;
                    case 2:
                        v2++;
                        break;
                    case 3:
                        v3++;
                        break;
                    case 4:
                        v4++;
                        break;
                    case 5:
                        vN++;
                        break;
                    case 6:
                        vB++;
                        break;
                    case 0:
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("erro!");
                        goto volt;
                }
            }

            float pVotosNulos = vN / totalVotos * 100;
            float pVotosBrancos = vB / totalVotos * 100;

            /*===========================================*/

            /*============= Saída de Dados ==============*/

            Console.WriteLine("==================================================");
            Console.WriteLine("Total de votos:");
            Console.WriteLine();
            Console.WriteLine($"Cadidato 1: {v1} votos");
            Console.WriteLine($"Cadidato 1: {v2} votos");
            Console.WriteLine($"Cadidato 1: {v3} votos");
            Console.WriteLine($"Cadidato 1: {v4} votos");
            Console.WriteLine($"Votos Nulos: {vN} votos");
            Console.WriteLine($"Votos em branco: {vB} votos");
            Console.WriteLine($"Porcetagem de votos nulos: {pVotosNulos.ToString("0.0")}% dos votos");
            Console.WriteLine($"Porcetagem de votos em Branco: {pVotosBrancos.ToString("0.0")}% dos votos");
            Console.WriteLine("==================================================");

            /*===========================================*/

            Console.ReadLine();
        }
    }
}