/*
 * Faça uma calculadora para as operações básicas 
 * (soma, subtração, multiplicação e divisão), utilizando 
 * uma class calculadora e apenas métodos com o mesmo nome: 
 * “public void calculo()” e que retorne uma mensagem com o 
 * resultado da operação.
 */
using System;

class Calculadora
{
    string operacao;
    float n1, n2;


    /*Método construtor, não precisa ser iniciado, pois inicia junto com a
    instancia do objeto leva o nome da classe*/
    public Calculadora(string operacao)
    {
        this.operacao = operacao;
    
    //retorno do goto
    volt:

        Console.WriteLine("Qual os numero para tal operação?\n" +
            "Numero 1:");
        n1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Numero 2:");
        n2 = float.Parse(Console.ReadLine());

        //Condicional para a tomada de decisão
        switch (operacao)
        {
            case "soma":

                Console.WriteLine($"\nResultado: {n1 + n2}");

                break;


            case "subtração":

                Console.WriteLine($"\nResultado: {n1 - n2}");

                break;


            case "divisão":

                Console.WriteLine($"\nResultado: {n1 / n2}");

                break;


            case "multiplicação":

                Console.WriteLine($"\nResultado: {n1 * n2}");

                break;

            default:

                Console.WriteLine("Operação não encontrada, digite novamente");
                operacao = Console.ReadLine();

                //Instrução de salto para retornar após algum erro
                goto volt;

        }
    }
}
