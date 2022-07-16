using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Padrões
{
    protected Random dado = new Random();
    protected int movimento, dano, defesa, escolha, soma = 0;

    abstract protected void Ataque();
    abstract protected void Andar();
    abstract protected void Defender();

}