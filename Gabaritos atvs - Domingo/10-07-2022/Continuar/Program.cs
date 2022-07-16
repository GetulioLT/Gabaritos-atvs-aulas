/*
 * Crie um programa que controle um pequeno sistema de batalha de RPG, 
 * onde cada personagem presente tenha uma forma diferente de ataque, 
 * andar, defender. Use com classes abstratas e depois com interfaces. 
 * Ex.:
 * Guerreiro: Anda até dois espaços, ataca duas vezes no mesmo turno, 
 * defende com o escudo;
 * Mago: Anda até 3 espaços(correndo), ataca usando bolas elementos 
 * (fogo, terra, ar e água), defende com barreiro de ar.
 * Ranger: Anda até 5 casas (pulando), ataca com arco e flechas, esquiva. 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Guerreiro guerreiro = new Guerreiro();

            Console.Read();

        }
    }
}
