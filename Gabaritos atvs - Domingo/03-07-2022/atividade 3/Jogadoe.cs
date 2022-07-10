using System;

class Jogador
{

    /*================ Atributos =================*/

    string nome, posicao, nacionalidade;
    int anoDeNascimento;
    float altura, peso;

    /*============================================*/

    /*======== Encapsulamento de informação ======*/
    //Utilizando apenas o get para que usuario apenas indique o
    //dado sem poder tem o retorno dele.

    public string Nome
    {
        set { nome = value; }
    }

    public string Posicao
    {
        set { posicao = value; }
    }

    public string Nacionalidade
    {
        set { nacionalidade = value; }
    }

    public int AnoDeNascimento
    {
        set { anoDeNascimento = value; }
    }

    public float Altura
    {
        set { altura = value; }
    }

    public float Peso
    {
        set { peso = value; }
    }

    /*============================================*/

    /*================== Métodos =================*/
    
    //Menu de controle para o usuario
    public void Menu()
    {
        int contador;

        //Laço principal para a movimentação entre os métodos
        do
        {
        
        //Volta da instrução de salto goto
        volta:
            Console.WriteLine("Menu de ações:\n" +
                "1 - Imprimir dados do jogador\n" +
                "2 - Calcular idade do jogador\n" +
                "3 - Tempo para aposentar\n" +
                "4 - Calcular IMC\n" +
                "0 - Sair");
            contador = int.Parse(Console.ReadLine());

            //condiçonais para o direcionamento
            switch (contador)
            {
                case 0:
                    break;


                case 1:

                    Console.Clear();
                    Console.WriteLine(Dados());
                    Console.ReadLine();

                    break;


                case 2:

                    Console.Clear();
                    Console.WriteLine(CalculoIdade());
                    Console.WriteLine("Precione enter para continuar...");
                    Console.ReadLine();
                    Console.Clear();

                    break;


                case 3:

                    Console.Clear();
                    Console.WriteLine(Aposentadoria());
                    Console.WriteLine("Precione enter para continuar...");
                    Console.ReadLine();
                    Console.Clear();

                    break;


                case 4:

                    Console.Clear();
                    Console.WriteLine(IMC());
                    Console.WriteLine("Precione enter para continuar...");
                    Console.ReadLine();
                    Console.Clear();

                    break;


                default:

                    Console.Clear();
                    Console.WriteLine("Numero não presente no menu, digite novamente\n");

                    //Caso de errro retornar para a indicação do numero novamente
                    goto volta;

            }

        } while (contador != 0);

    }

    string Dados()
    {
        Console.Clear();

        return $"Dados do jogador {nome}:\n" +
            $"Posição: {posicao}\n" +
            $"Nacionalidade: {nacionalidade}\n" +
            $"Ano de nascimento: {anoDeNascimento}\n" +
            $"Altura: {altura}\n" +
            $"Peso: {peso}\n" +
            $"\n" +
            $"Precione enter para continuar...";
    }

    int CalculoIdade()
    {

        Console.Clear();

        return DateTime.Now.Year - anoDeNascimento;

    }

    string Aposentadoria()
    {
        int idade = DateTime.Now.Year - anoDeNascimento;
        string pos = posicao.ToUpper();
        string men = "";

        if (pos == "DEFESA")
        {

            int apose = 40 - idade;

            if (apose >= 0)
            {
                men = $"Falta {apose} anos para se aposentar";

            }
            else
            {
                men = "O jogador já pode se aposentar";
            }

        }
        else if (pos == "MEIO-CAMPO")
        {

            int apose = 38 - idade;

            if (apose >= 0)
            {
                men = $"Falta {apose} anos para se aposentar";

            }
            else
            {
                men = "O jogador já pode se aposentar";
            }

        }
        else if (pos == "ATAQUE")
        {

            int apose = 35 - idade;

            if (apose >= 0)
            {
                men = $"Falta {apose} anos para se aposentar";

            }
            else
            {
                men = "O jogador já pode se aposentar";
            }

        }

        return men;

    }

    string IMC()
    {

        string men = "";
        double imc = peso / Math.Pow(altura, 2);

        if (imc < 18.5)
        {
            men = $"Valor do imc: {imc}\n" +
                $"Jogador abaixo do peso";
        }
        else if (imc >= 18.5 && imc < 24.9)
        {
            men = $"Valor do imc: {imc}\n" +
                $"Jogador peso ideal";
        }
        else if (imc >= 25 && imc < 29.9) 
        {
            men = $"Valor do imc: {imc}\n" +
            $"Jogador levemente acima do peso";
        }
        else if (imc >= 30 && imc <34.9)
        {
            men = $"Valor do imc: {imc}\n" +
                $"Jogador obsidade grau I";
        }
        else if (imc >= 35 && imc < 39.9)
        {
            men = $"Valor do imc: {imc}\n" +
                $"Jogador obsidade grau II";
        }
        else
        {
            men = $"Valor do imc: {imc}\n" +
                $"Jogador obsidade grau III";
        }

        return men;

    }

    /*============================================*/

}
