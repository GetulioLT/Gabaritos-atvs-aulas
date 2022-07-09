/*
 * Crie uma classe para representar um jogador de futebol, 
 * com os atributos nome, posição, data de nascimento, nacionalidade, 
 * altura e peso. Crie os métodos públicos necessários para sets e 
 * gets e também um método para imprimir todos os dados do jogador. 
 * Crie um método para calcular a idade do jogador e outro método
 * para mostrar quanto tempo falta para o jogador se aposentar. 
 * Para isso, considere que os jogadores da posição de defesa se 
 * aposentam em média aos 40 anos, os jogadores de meio-campo aos 
 * 38 e os atacantes aos 35.
 */


using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*================= Instancia ================*/

            Jogador jogador = new Jogador();

            /*============================================*/

            /*============= Entrada de dados =============*/

            Console.WriteLine("Bem vindo ao cadastro de jogadores:\n" +
                "Primeiramente digite o nome do jogador:");
            jogador.Nome = Console.ReadLine();

            Console.WriteLine("Qual a sua posição:");
            jogador.Posicao = Console.ReadLine();

            Console.WriteLine("Nacionalidade:");
            jogador.Nacionalidade = Console.ReadLine();

            Console.WriteLine("Ano de Nascimento:");
            jogador.AnoDeNascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o peso do jogador:");
            jogador.Peso = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual a sua altura:");
            jogador.Altura = float.Parse(Console.ReadLine());

            Console.Clear();

            /*============================================*/

            /*========== Iniciamento do Método ===========*/

            jogador.Menu();

            /*============================================*/

            Console.ReadLine();

        }
    }

}
