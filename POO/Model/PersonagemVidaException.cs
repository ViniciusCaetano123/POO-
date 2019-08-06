using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlaJogo.Model
{
   public class PersonagemVidaException : Exception
    {
        public Personagem Personagem { get; }
        public PersonagemVidaException()
        {

        }
        public PersonagemVidaException(Personagem personagem) : this("Tentativa Invalidade, Vida é < que Zero : "+personagem.Vida)
        {
            Personagem = personagem;
        }
        public PersonagemVidaException(string mensagem):base(mensagem)
        {

        }
    }
}
