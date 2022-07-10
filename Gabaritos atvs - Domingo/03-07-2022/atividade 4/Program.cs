/*
 * Faça uma classe que represente uma partida de futebol, a cada objeto 
 * instanciado possa ser controlado uma partida, com nome dos times, 
 * quantidades de gols, cartões e faltas cometidas.
 * 
 * Obs: Utilize apenas o conceito de Abstração, e para cada de atributos, 
 * utilize um método para cada (ex.: Gol para o time 1: void Gol1()).
 * Obs2: A Cada modificação nos atributos, use a Classe Random para 
 * incrementar no tempo de partida (use como parâmetros de 1 a 5 min para 
 * ser acrescido no tempo: ex.:
 * Random rand = new Random()
 * tempo += rand.Next(1, 5)).
 */


using System;


namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*================= Instancia ================*/

            Partida partida = new Partida();

            /*============================================*/

            Console.ReadLine();

        }
    }
}
