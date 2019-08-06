using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlaJogo.Model
{
    public class ControleDano
    {
      
        public void AdicionaDanoExtra(Personagem personagem)
        {
            personagem.AdicionaDanoExtra();
        }

        public void AdicionaDano(Personagem personagem, Itens item)
        {
            if (personagem.CompraItem(item))
            {
                item.AdicionaDano(item, personagem);
            }
        }

        

        public void DanoSkill(Personagem personagem, ISkills skills){
           skills.Skill(personagem);
        }

    }
}
    
