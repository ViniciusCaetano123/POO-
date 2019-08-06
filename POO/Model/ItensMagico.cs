using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlaJogo.Model
{
    class ItensMagico : Itens
    {
        public Magico magicoItem = new Magico();
        public override void AdicionaDano(Itens item, Personagem personagem) {         
            personagem.magico.DanoMagico = personagem.magico.DanoMagico + magicoItem.DanoMagico;
            personagem.magico.PenetracaoMagica = personagem.magico.PenetracaoMagica + magicoItem.PenetracaoMagica;           
        }
    }
}
