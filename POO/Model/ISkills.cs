using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlaJogo.Model
{
    public abstract class ISkills 
    {     
        public int LevelSkill {get;set;}
        public Personagem personagem;
        public int UparSkill(){
            return LevelSkill = LevelSkill +1;
        }
        public abstract void Skill(Personagem personagem);
        
    }
    public class ISkillQ:ISkills
    {      
        
        public override void Skill(Personagem outroPersonagem)
         {
            if (personagem.VerificaGrupo(outroPersonagem))
            {
                if (personagem.Vida <= 0)
                {
                    throw new PersonagemVidaException("Personagem Não Tem Vida Pra Ser Tirada");
                }
                outroPersonagem.Vida = outroPersonagem.Vida - personagem.fisico.DanoFisico;              
            }          
         }
        
    }
    public class ISkillW:ISkills{         
       
        public override void Skill(Personagem outroPersonagem)
         {
            if (personagem.VerificaGrupo(outroPersonagem))
            {
                if (personagem.Vida <= 0)
                {
                    throw new PersonagemVidaException("Personagem Não Tem Vida Pra Ser Tirada");
                }
                outroPersonagem.Vida = outroPersonagem.Vida - 200;                
            }
           
         }
      
    }
}
