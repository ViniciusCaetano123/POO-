using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlaJogo.Model
{
    public class Diana : Personagem
    {
        public Diana(int grupo):base(grupo) { 

        }
        public override void AdicionaDanoExtra()
        {
            base.magico.DanoMagico = base.magico.DanoMagico + 100;
            
        }
        
    }
}
