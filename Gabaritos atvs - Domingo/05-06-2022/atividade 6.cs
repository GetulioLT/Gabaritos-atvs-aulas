/*
    Avaliação Lógica de Programação em C#
    Atividade dia: 05/06/2022  Desvios Condicionais.
    Questão 6: Uma empresa quer verificar se um empregado está qualificado para a  
    aposentadoria ou não. Para estar em condições, um dos seguintes requisitos deve 
    ser satisfeito: 
    1) Ter no mínimo 65 anos de idade. 
    2) Ter trabalhado no mínimo 30 anos. 
    3) Ter no mínimo 60 anos e ter trabalhado no mínimo 25 anos. 
    Com base nas informações acima, faça um algoritmo que leia: o número do 
    empregado (código), o ano de seu nascimento e o ano de seu ingresso na empresa. 
    O programa deverá escrever a idade e o tempo de trabalho do
    empregado e a mensagem 'Requerer aposentadoria' ou 'Não requerer'. 
 */
using System;

namespace Avaliação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verificação para aposentadoria");
            Console.WriteLine();

            /*================ Váriaveis ================*/

            int numEmpregado;
            int anoNascimento;
            int idade;
            int anoEmpresa;
            int tempoEmpresa;

            /*===========================================*/

            /*============ Entrada de Dados =============*/

            Console.WriteLine("Digite o numero do empregado:");
            Console.Write("");
            numEmpregado = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o ano de nascimento do empregado:");
            Console.Write("");
            anoNascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o ano que o empregado adentrou na empresa:");
            Console.Write("");
            anoEmpresa = int.Parse(Console.ReadLine());

            Console.WriteLine();

            /*===========================================*/

            /*========= Processamento de Dados ==========*/

            idade = 2022 - anoNascimento;

            tempoEmpresa = 2022 - anoEmpresa;



            /*============= Saída de Dados ==============*/

            if (idade >= 60 && tempoEmpresa >= 25)
            {
                Console.WriteLine($"Empregado de numero {numEmpregado} com {idade} anos e {tempoEmpresa} anos de empresa, está apto a se aposentar");
            }
            else if (idade >= 65)
            {
                Console.WriteLine($"Empregado de numero {numEmpregado} com {idade} anos e {tempoEmpresa} anos de empresa, está apto a se aposentar");
            }
            else if (tempoEmpresa > 30)
            {
                Console.WriteLine($"Empregado de numero {numEmpregado} com {idade} anos e {tempoEmpresa} anos de empresa, está apto a se aposentar");
            }
            else
            {
                Console.WriteLine($"Empregado de numero {numEmpregado} com {idade} anos e {tempoEmpresa} anos de empresa, não está apto a se aposentar");
            }


            /*===========================================*/            
            
            Console.ReadLine();
        }
    }
}