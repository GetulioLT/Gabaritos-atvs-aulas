using System;

class Figura
{
    /*================ Atributos =================*/

    public static double bas, alt, dia;
    int escolha;

    /*============================================*/

    /*================== Métodos =================*/

    public void Iniciar()
    {

        //Laço de repetição
        do
        {

            Console.WriteLine("Bem vindo ao calculo de area:\n" +
            "Primeiro escolha a figura geometrica:\n" +
            "1 - Quadrado\n" +
            "2 - Retangulo\n" +
            "3 - Triagulo\n" +
            "4 - Circulo\n" +
            "0 - Sair");

            error1:

            escolha = int.Parse(Console.ReadLine());

            //Condicional para a tomada decisão
            switch (escolha)
            {
                case 1:

                    Console.WriteLine($"\nValor do Quadrado é: {Quadrado.Calculo()}");
                    Console.ReadLine();
                    Console.Clear();

                    break;


                case 2:

                    Console.WriteLine($"\nValor do Retangulo é: {Retangulo.Calculo()}");
                    Console.ReadLine();
                    Console.Clear();

                    break;


                case 3:

                    Console.WriteLine($"\nValor do Triangulo é: {Triagulo.Calculo()}");
                    Console.ReadLine();
                    Console.Clear();

                    break;


                case 4:

                    Console.WriteLine($"\nValor do Circulo é: {(Circulo.Calculo()).ToString("0.00")}");
                    Console.ReadLine();
                    Console.Clear();

                    break;


                case 0:
                    break;


                default:

                    Console.WriteLine("Digite um numero da tabela");

                    goto error1;

            }


        } while (escolha != 0);

    }

    /*============================================*/

}