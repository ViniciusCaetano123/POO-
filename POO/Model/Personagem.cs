using System;

namespace OlaJogo.Model
{ 
    public abstract class Personagem
    {
        public static int Total{ get;}
        public Object[] Inventarios;
        public int _prox;
        public Magico magico = new Magico();
        public Fisico fisico = new Fisico();
        public int Dinheiro { get; set; }
       // public readonly int _grupo;
        public int Grupo { get;}
        public int Vida { get; set; }
        public int Soma{get;set;}
        public int UparKill{set;get;}
        public Personagem(int grupo)
        {        
            if(Grupo <=0 || Grupo >= 3)
            {
                ArgumentException exception = new ArgumentException("Grupo Nao Existenti, grupo deve ser entre 1 e 2");              
            }                       
            Grupo = grupo;            
           Total++;
           ISkillQ skillQ = new ISkillQ();
           ISkillW skillW = new ISkillW();
            Inventarios = new Object[5];
            this._prox = 0;
            fisico.DanoFisico = 75;
            magico.DanoMagico = 10;
            this.Vida = 600;
            fisico.AtaqueVelocidade = 0.67;
            this.Dinheiro = 900;
        }
        public bool VerificaQuantidaDeCampeoes()
        {
            return true;
        }
        public bool VerificaGrupo(Personagem outroPersonagem)
        {           
            if (outroPersonagem.Grupo != this.Grupo)
            {
                return true;
            }          
            return false;
        }
        public int AttackBasico(Personagem outroPersonagem)
        {            
            if (VerificaGrupo(outroPersonagem))
            {
                return outroPersonagem.Vida = outroPersonagem.Vida - fisico.DanoFisico;
            }           
            return 0;          
        }
        public bool CompraItem(Itens item)
        {          
            if (this.Dinheiro > item.Preco)
            {
                this.Dinheiro = this.Dinheiro - item.Preco;
                return true;
            }
            ArgumentException exception = new ArgumentException("Dinheiro Insuficiente");
            return false;
        }
        public abstract void AdicionaDanoExtra();       
    }
}
