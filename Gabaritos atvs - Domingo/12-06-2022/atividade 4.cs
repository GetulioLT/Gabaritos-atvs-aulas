/*
    Uma loja tem uma política de descontos de acordo com o valor da compra do cliente. 
    Os descontos começam acima dos R$500. A cada 100 reais acima dos R$500,00 o cliente 
    ganha 1% de desconto cumulativo até 25%.                            
    Faça um programa que exiba essa tabela de descontos no seguinte formato:                                                                    
    Valor da compra – porcentagem de desconto – valor final
 */
using System;

namespace Avaliação
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Tabela de preço de desconto da loja Infinity:");
            Console.WriteLine();

            /*================ Váriaveis ================*/

            float valor = 500;
            float valorDesc;
            float valorFinal;

            /*===========================================*/

            /*============ Entrada de Dados =============*/

            /*===========================================*/

            /*========= Processamento de Dados ==========*/

            for (int i = 1; i < 26; i++)
            {
                valorDesc = i * valor / 100;
                valorFinal = valor - valorDesc;

                /*============= Saída de Dados ==============*/

                Console.WriteLine("==============================================================================");

                Console.WriteLine($"Se a comprar for a partir de {valor} o desconto será de {i}% o valor final de {valorFinal}");
                
                /*===========================================*/

                valor += 100;
            }
            Console.WriteLine("==============================================================================");
            /*===========================================*/

            Console.ReadLine();

        }     
        
    }
}
