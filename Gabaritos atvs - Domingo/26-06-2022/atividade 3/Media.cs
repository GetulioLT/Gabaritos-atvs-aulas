using System;

class Media
{
    /*================ Váriaveis ================*/

    public string name;
    private float n1, n2, n3,medi, p1, p2, p3;

    /*===========================================*/

    public void mediaA()
    {
        /*============ Entrada de Dados =============*/

        Console.WriteLine("\nPara media aritmética temos que receber 2 notas sua:");
        Console.WriteLine("\ndigite nota 1");
        n1 = float.Parse(Console.ReadLine());

        Console.WriteLine("digite nota 2");
        n2 = float.Parse(Console.ReadLine());

        /*===========================================*/

        /*========= Processamento de Dados ==========*/

        medi = (n1 + n2) / 2;

        /*===========================================*/

    }

    public void mediaP()
    {
        /*============ Entrada de Dados =============*/

        Console.WriteLine("\nPara media ponderada temos que receber 3 notas e seus respectivos pesos:");
        Console.WriteLine("\ndigite nota 1");
        n1 = float.Parse(Console.ReadLine());
        Console.WriteLine("digite peso 1");
        p1 = float.Parse(Console.ReadLine());

        Console.WriteLine("digite nota 2");
        n2 = float.Parse(Console.ReadLine());
        Console.WriteLine("digite peso 2");
        p2 = float.Parse(Console.ReadLine());

        Console.WriteLine("digite nota 3");
        n3 = float.Parse(Console.ReadLine());
        Console.WriteLine("digite peso 3");
        p3 = float.Parse(Console.ReadLine());

        /*===========================================*/

        /*========= Processamento de Dados ==========*/

        medi = (p1 * n1 + p2 * n2 + p3 * n3) / (p1 + p2 + p3);

        /*===========================================*/

    }

    /*============= Saída de Dados ==============*/

    public void mensagem()
    {
        Console.WriteLine($"\n{name} sua média é: {medi.ToString("0.0")}");
    }

    /*===========================================*/

}