using System;

class Partida
{

    /*================ Atributos =================*/

    string time1,time2;
    int quantGols1 = 0, quantGols2 = 0;
    int quantCartoes1 = 0, quantCartoes2 = 0;
    int quantFaltas1 = 0, quantFaltas2 = 0;
    int tempo = 0;

    //Objeto random, onde irá gerar um numero aleatorio.
    Random random = new Random();

    /*============================================*/

    /*================== Métodos =================*/
    //Utilizado metodos em cadeia, onde um metodo chama o outro e assim por diante.

    public Partida()
    {

        Console.WriteLine("Bem-vindo ao simulador de paridas de futebol:\n" +
            "Primeiramente digete o nome dos time.\n");

        Time1();

    }

    void Time1()
    {

        Console.WriteLine("Time 1:");
        time1 = Console.ReadLine();

        Time2();

    }

    void Time2()
    {

        Console.WriteLine("Time 2:");
        time2 = Console.ReadLine();

        InicioPartida();

    }

    void Gols1()
    {

        quantGols1 += random.Next(0, 2);

        Gols2();

    }

    void Gols2()
    {

        quantGols2 += random.Next(0, 2);

        Cartoes1();

    }

    void Cartoes1()
    {

        quantCartoes1 += random.Next(0, 2);

        Cartoes2();

    }

    void Cartoes2()
    {

        quantCartoes2 += random.Next(0, 2);

        Faltas1();

    }

    void Faltas1()
    {

        quantFaltas1 += random.Next(0, 2);

        Faltas2();

    }

    void Faltas2()
    {

        quantFaltas2 += random.Next(0, 2);

    }

    void InicioPartida()
    {

        tempo += random.Next(1, 5);

        //Laço de repetição onde irá repetir tudo até o tempo chegar
        //a 90 minutos ou mais que isso.
        do
        {

            Console.Clear();

            Console.WriteLine("$Dados da partida:\n" +
                $"{time1} {quantGols1}\n" +
                $"{time2} {quantGols2}\n" +
                $"-----------------------------------\n" +
                $"Tempo: {tempo}min\n" +
                $"-----------------------------------\n" +
                $"Total de Cartões: {quantCartoes1 + quantCartoes2}\n" +
                $"{time1}: {quantCartoes1}\n" +
                $"{time2}: {quantCartoes2}\n" +
                $"-----------------------------------\n" +
                $"Total de Faltas: {quantFaltas1 + quantFaltas2}\n" +
                $"{time1}: {quantFaltas1}\n" +
                $"{time2}: {quantFaltas2}\n" +
                $"------------------------------------\n" +
                $"Tempo para o fim da partida: {90 - tempo}\n" +
                $"------------------------------------\n" +
                $"Precione enter para continuar");
            tempo += random.Next(1, 5);
            Console.ReadLine();

            Gols1();

        } while (tempo <= 90);

    }

    /*============================================*/

}