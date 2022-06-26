using System;

class Idade
{

    /*================ Váriaveis ================*/

    private float nIdade;
    private float a, b, c, d, e;
    private float perP, perS;

    /*===========================================*/

    public void pessoa()
    {
        Console.WriteLine("vamos começar passando as idades");

        /*============ Entrada de Dados =============*/

        for (int i = 1; i < 16; i++)
        {
            Console.WriteLine($"Digite a idade {i}");
            nIdade = float.Parse(Console.ReadLine());

            if (nIdade >= 0 && nIdade < 16)
            {
                a++;
            }
            else if (nIdade > 15 && nIdade < 31)
            {
                b++;
            }
            else if (nIdade > 30 && nIdade < 46)
            {
                c++;
            }
            else if (nIdade > 45 && nIdade < 61)
            {
                d++;
            }
            else
            {
                e++;
            }
        }

        /*===========================================*/

        primeiraF();
        segundaF();

    }

    /*========= Processamento de Dados ==========*/

    private float primeiraF()
    {
        perP = (a / 15) * 100;


        return perP;
    }

    private float segundaF()
    {
        perS = (e / 15) * 100;


        return perS;
    }

    /*===========================================*/

    /*============= Saída de Dados ==============*/

    public void mensagem()
    {
        Console.WriteLine($"\nTotal de pessoas 15:\n" +
            $"até 15 anos:      {a}\n" +
            $"de 16 a 30 anos:  {b}\n" +
            $"de 31 a 45 anos:  {c}\n" +
            $"de 46 a 60 anos:  {d}\n" +
            $"acima de 61 anos: {e}\n");
        Console.WriteLine($"Porcetagem de pessoas na primeira faixa etatia: {perP.ToString("0.00")}%\n" +
            $"Porcetagem se pessoas na segunda faixa etaria: {perS.ToString("0.00")}%");
    }

    /*===========================================*/
}