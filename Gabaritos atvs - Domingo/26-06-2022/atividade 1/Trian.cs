using System;

class Trian
{
    /*================ Váriaveis ================*/

    public float l1, l2, l3;
    private bool neg, eq, iso, es;

    /*===========================================*/

    /*========= Processamento de Dados ==========*/

    public void menNegacao()
    {
        if (l1 + l2 < l3 || l2 + l3 < l1 || l1 + l3 < l2)
        {
            neg = true;
            
        }
    }

    public void equi()
    {
        if (l1 == l2 && l2 == l3 && l1 == l3)
        {
            eq = true;
        }
        
    }

    public void isoc()
    {
        if (l1 == l2 || l2 == l3 || l1 == l3 && eq == false)
        {
            iso = true;
        }
    }

    public void esca()
    {
        if (l1 != l2 && l2 != l3 && l1 != l3)
        {
            es = true;
        }
    }

    /*===========================================*/

    /*============= Saída de Dados ==============*/

    public void mensagem()
    {

        if (neg == true)
        {
            Console.WriteLine("As tres medidas não formam um triangulo.");
        }
        else if (eq == true)
        {
            Console.WriteLine($"As medidas: {l1}, {l2} e {l3}, equivalem a um trinagulo equilátero.");
        }
        else if (iso == true)
        {
            Console.WriteLine($"As medidas: {l1}, {l2} e {l3}, equivalem a um trinagulo isósceles.");
        }
        else if (es == true)
        {
            Console.WriteLine($"As medidas: {l1}, {l2} e {l3}, equivalem a um trinagulo escaleno.");
        }

    }

    /*===========================================*/

}