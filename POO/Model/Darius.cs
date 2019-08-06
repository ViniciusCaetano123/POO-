using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlaJogo.Model
{
    public class Darius : Personagem
    {     
        public Darius(int grupo) : base(grupo)
        {
        }
        public override void AdicionaDanoExtra()
        {           
            base.fisico.DanoFisico = base.fisico.DanoFisico + 200;
        }
       
    }
}
