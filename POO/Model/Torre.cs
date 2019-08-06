using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlaJogo.Model
{
    public class Torre
    {
        public Torre(int vida,int dano )
        {
            Vida = vida;
            Dano = dano;
        }
        public int Dano{ get; set; }
        public int Vida { get; set; }
        public void AtirarEmUmCampeao(Personagem personagem)
        {
            if (personagem.Vida <= 0)
            {
                throw new PersonagemVidaException("Personagem Não Tem Vida Pra Ser Tirada");
            }
            personagem.Vida = personagem.Vida - Dano;
            Dano = Dano + 100;
        }

        public bool ReceberDanoDeCampeao()
        {
            return true;
        }
    }
}
