using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Guerreiro : Padrões
{
    public Guerreiro()
    {

        do
        {

            Console.WriteLine("Bem vindo guerreiro\n" +
                "Qual a sua proxima ação?\n" +
                "1 - Atacar\n" +
                "2 - Andar\n" +
                "3 - Defender\n" +
                "0 - voltar para a escolha de personagem");

            escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {

                case 1:

                    Ataque();

                    Console.Clear();

                    break;

                case 2:

                    Andar();

                    Console.Clear();

                    break;


                case 3:

                    Defender();

                    Console.Clear();

                    break;


                case 0:

                    goto sair;


                default:
                    break;
            }

        } while (true);

    sair: { }

    }

    protected override void Andar()
    {

        movimento = dado.Next(1, 3);

        Console.WriteLine($"O guerreiro andou {movimento} nesse turno\n" +
            $"Precione enter para continuar...");
        Console.ReadLine();

    }

    protected override void Ataque()
    {

        dano = dado.Next(1, 7);
        soma += dano;
        dano = dado.Next(1, 7);
        soma += dano;

        Console.WriteLine($"O dado acertado pelos dois golpes do guerreiro foi de {soma}\n" +
            $"Precione enter para continuar...");
        Console.ReadLine();
        soma = 0;
    }

    protected override void Defender()
    {

        defesa = dado.Next(1, 7);

        Console.WriteLine($"O guerreiro defendeu {defesa} de dano\n" +
            $"Precione enter para continuar...");
        Console.ReadLine();

    }
}