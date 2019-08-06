using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlaJogo.Model
{
    class ItensFisico:Itens
    {       
        public Fisico fisicoItem = new Fisico();
        public override void AdicionaDano(Itens item, Personagem personagem) {          
             personagem.fisico.DanoFisico = personagem.fisico.DanoFisico + fisicoItem.DanoFisico;
             personagem.fisico.AtaqueVelocidade = personagem.fisico.AtaqueVelocidade + fisicoItem.AtaqueVelocidade;
             personagem.fisico.PenetracaoFisica = personagem.fisico.PenetracaoFisica + fisicoItem.PenetracaoFisica;            
        }
    }
}
