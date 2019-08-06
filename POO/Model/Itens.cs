using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlaJogo.Model
{
    public abstract class Itens
    {
        public int Preco { set; get; }        
        public abstract void AdicionaDano(Itens item, Personagem personagem);
    }
}

