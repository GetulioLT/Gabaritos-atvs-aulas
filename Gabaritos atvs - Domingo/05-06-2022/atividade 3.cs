/*
    Avaliação Lógica de Programação em C#
    Atividade dia: 05/06/2022  Desvios Condicionais.
    Questão 3: Receber do usuário a quantidade de respiradores e a porcentagem de 
    ocupação de 5 hospitais em Fortaleza, caso algum desses hospitais tenham menos 
    que 50 respiradores e a taxa ocupacional esteja maior que 60%, serão adicionados mais 5. 
 */
using System;

namespace Avaliação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iremos fazer umas verificações de respiradores em 5 hospitais:");
            Console.WriteLine("Queremos que nos informe a quantidade de respiradores e sua taxa ocupacional:");
            Console.WriteLine();

            /*================ Váriaveis ================*/

            int quant1;
            int quant2;
            int quant3;
            int quant4;
            int quant5;
            int ocup1; 
            int ocup2;
            int ocup3;
            int ocup4;
            int ocup5;


            /*===========================================*/

            /*============ Entrada de Dados =============*/

            Console.WriteLine("Digite a quantidade do primeiro hospital:");
            Console.Write("");
            quant1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a taxa de ocupação do primeiro hospital:");
            Console.Write("");
            ocup1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade do segundo hospital:");
            Console.Write("");
            quant2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a taxa de ocupação do segundo hospital:");
            Console.Write("");
            ocup2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade do terceiro hospital:");
            Console.Write("");
            quant3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a taxa de ocupação do terceiro hospital:");
            Console.Write("");
            ocup3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade do quarto hospital:");
            Console.Write("");
            quant4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a taxa de ocupação do quarto hospital:");
            Console.Write("");
            ocup4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade do quinto hospital:");
            Console.Write("");
            quant5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a taxa de ocupação do quinto hospital:");
            Console.Write("");
            ocup5 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            /*===========================================*/

            /*========= Processamento de Dados ==========*/

            if (quant1 < 50 && ocup1 > 60)
            {

                /*============= Saída de Dados ==============*/

                Console.WriteLine($"Hospital 1 tem {quant1} de respiradores");
                Console.WriteLine($"E tem uma taxa de ocupação de {ocup1}°");
                Console.WriteLine($"Após a atualização ficará com {quant1 + 5} respiradores");
                Console.WriteLine();

                /*===========================================*/

            }
            else
            {

                /*============= Saída de Dados ==============*/

                Console.WriteLine($"Hospital 1 tem {quant1} de respiradores");
                Console.WriteLine($"E tem uma taxa de ocupação de {ocup1}°");
                Console.WriteLine("Não necessita de mais respiradores");
                Console.WriteLine();

                /*===========================================*/

            }

            if (quant2 < 50 && ocup2 > 60)
            {

                /*============= Saída de Dados ==============*/

                Console.WriteLine($"Hospital 2 tem {quant2} de respiradores");
                Console.WriteLine($"E tem uma taxa de ocupação de {ocup1}°");
                Console.WriteLine($"Após a atualização ficará com {quant2 + 5} respiradores");
                Console.WriteLine();

                /*===========================================*/

            }
            else
            {

                /*============= Saída de Dados ==============*/

                Console.WriteLine($"Hospital 2 tem {quant2} de respiradores");
                Console.WriteLine($"E tem uma taxa de ocupação de {ocup2}°");
                Console.WriteLine("Não necessita de mais respiradores");
                Console.WriteLine();

                /*===========================================*/

            }

            if (quant3 < 50 && ocup3 > 60)
            {

                /*============= Saída de Dados ==============*/

                Console.WriteLine($"Hospital 3 tem {quant3} de respiradores");
                Console.WriteLine($"E tem uma taxa de ocupação de {ocup3}°");
                Console.WriteLine($"Após a atualização ficará com {quant3 + 5} respiradores");
                Console.WriteLine();

                /*===========================================*/

            }
            else
            {

                /*============= Saída de Dados ==============*/

                Console.WriteLine($"Hospital 3 tem {quant3} de respiradores");
                Console.WriteLine($"E tem uma taxa de ocupação de {ocup3}°");
                Console.WriteLine("Não necessita de mais respiradores");
                Console.WriteLine();

                /*===========================================*/

            }

            if (quant4 < 50 && ocup4 > 60)
            {

                /*============= Saída de Dados ==============*/

                Console.WriteLine($"Hospital 4 tem {quant4} de respiradores");
                Console.WriteLine($"E tem uma taxa de ocupação de {ocup4}°");
                Console.WriteLine($"Após a atualização ficará com {quant4 + 5} respiradores");
                Console.WriteLine();

                /*===========================================*/

            }
            else
            {

                /*============= Saída de Dados ==============*/

                Console.WriteLine($"Hospital 4 tem {quant4} de respiradores");
                Console.WriteLine($"E tem uma taxa de ocupação de {ocup4}°");
                Console.WriteLine("Não necessita de mais respiradores");
                Console.WriteLine();

                /*===========================================*/

            }

            if (quant5 < 50 && ocup5 > 60)
            {

                /*============= Saída de Dados ==============*/

                Console.WriteLine($"Hospital 5 tem {quant5} de respiradores");
                Console.WriteLine($"E tem uma taxa de ocupação de {ocup5}°");
                Console.WriteLine($"Após a atualização ficará com {quant5 + 5} respiradores");
                Console.WriteLine();

                /*===========================================*/

            }
            else
            {

                /*============= Saída de Dados ==============*/

                Console.WriteLine($"Hospital 5 tem {quant5} de respiradores");
                Console.WriteLine($"E tem uma taxa de ocupação de {ocup5}°");
                Console.WriteLine("Não necessita de mais respiradores");

                /*===========================================*/

            }

            /*===========================================*/

            Console.ReadLine();
        }
    }
}