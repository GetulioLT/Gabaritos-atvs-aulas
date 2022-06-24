using System;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos descobrir que tipo de triangulo se forma com tres retas?");

            Trian trian = new Trian();

            Console.WriteLine("Priemiro preciso que digite as tres retas");
            Console.WriteLine("Digite o primeiro valor:");
            trian.l1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digete o segundo valor:");
            trian.l2 = float.Parse(Console.ReadLine());
            Console.WriteLine("E finalizando o ultimo valor:");
            trian.l3 = float.Parse(Console.ReadLine());

            trian.menNegacao();
            trian.equi();
            trian.isoc();
            trian.esca();


            trian.mensagem();

            Console.ReadLine();
        }
    }
}
