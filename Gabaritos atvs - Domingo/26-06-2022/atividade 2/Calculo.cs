using System;

class Calculo
{
    /*================ Váriaveis ================*/

    public float a, b, c;
    public double x0, x1;
    public float deltA;
    public bool dM0, d0, d1;

    /*===========================================*/

    /*========= Processamento de Dados ==========*/

    public float delta()
    {
        Calculo calculo = new Calculo();
        deltA = (b * b) - 4 * a * c;
        condD();
        return deltA;
    }

    private void condD()
    {
        if (deltA < 0)
        {
            dM0 = true;
        }
        else if (deltA == 0)
        {
            d0 = true;
            calculoX0();
        }
        else
        {
            d1 = true;
            calculoX1();
        }
    }
    
    private void calculoX0()
    {
        x0 = (b * -1 + Math.Sqrt(deltA)) / (2 * a);

    }

    private void calculoX1()
    {
        x0 = (b * -1 + Math.Sqrt(deltA)) / (2 * a);
        x1 = (b * -1 -  Math.Sqrt(deltA)) / (2 * a);


    }

    /*===========================================*/

    /*============= Saída de Dados ==============*/

    public void mensagem()
    {
        Console.WriteLine();

        if (d1 == true)
        {
            Console.WriteLine($"{a}x² + {b}x + {c}");
            Console.WriteLine($"D = {b}² * 4 * {a} * {c} \n");

            Console.WriteLine($"Como o delta ficou igual a {deltA} o resultado terá duas raizes. \n");

            Console.WriteLine($"x = -({b}) ± √D \n"+
                              $"     2 * {a} \n");

            Console.WriteLine($"calculo ficou com o resultado para x1: {x0.ToString("0.00")} e x2: {x1.ToString("0.00")}.");
        }
        else if(d0 == true)
        {
            Console.WriteLine($"{a}x² + {b}x + {c}");
            Console.WriteLine($"D = {b}² * 4 * {a} * {c}\n");

            Console.WriteLine($"Como o delta ficou igual a {deltA} o resultado terá apenas uma raiz.\n");

            Console.WriteLine($"x = -({b}) ± √D \n" +
                              $"     2 * {a} \n");

            Console.WriteLine($"calculo ficou com o resultado para x1: {x0.ToString("0.00")}.");
        }
        else if(dM0 == true)
        {
            Console.WriteLine($"{a}x² + {b}x + {c}");
            Console.WriteLine($"D = {b}² * 4 * {a} * {c} \n");

            Console.WriteLine($"Como o delta ficou igual a {deltA} terá resultado com raizes reais");
        }
        
    }

    /*===========================================*/

}