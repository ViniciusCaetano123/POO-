using OlaJogo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlaJogo
{
    class Program
    {
        static void Main(string[] args)
        {

            ItensMagico Cajado = new ItensMagico();
            Cajado.Preco = 900;
            Cajado.magicoItem.DanoMagico = 50;

            ItensMagico Vazio = new ItensMagico();
            Vazio.Preco = 200;
            Vazio.magicoItem.DanoMagico = 150;

            Darius darius = new Darius(1);
            Diana diana = new Diana(2);
            Torre torre = new Torre(300,100);
            Console.WriteLine(darius.Vida);
            try
            {
                torre.AtirarEmUmCampeao(darius);
                torre.AtirarEmUmCampeao(darius);
               // torre.AtirarEmUmCampeao(darius);
              //  torre.AtirarEmUmCampeao(darius);
            }
            catch (PersonagemVidaException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(darius.Vida);
            Console.WriteLine(diana.Vida);


            ISkillQ skillQDiana = new ISkillQ();
            ISkillW skillWDiana = new ISkillW();
            skillQDiana.UparSkill();
            skillQDiana.personagem = diana;
            skillWDiana.personagem = diana;

            ISkillQ skillQDarius = new ISkillQ();
            ISkillW skillWDarius = new ISkillW();
            skillQDarius.UparSkill();
            skillQDarius.personagem = darius;
            skillWDarius.personagem = darius;

            ControleDano controleDano = new ControleDano();
            controleDano.AdicionaDano(diana, Vazio);
            //try
           // {
                controleDano.DanoSkill(diana, skillWDarius);
                controleDano.DanoSkill(diana, skillQDarius);
                controleDano.DanoSkill(diana, skillQDarius);
           // }catch(PersonagemVidaException ex)
           // {
                //Console.WriteLine(ex.Message);
//}

            //Console.WriteLine("Vida da Daina "+diana.Vida);
            Console.WriteLine("Daiana------------");
            Console.WriteLine("Vida da Diana :"+diana.Vida);
            Console.WriteLine("Dano da diana é " + diana.magico.DanoMagico);
            darius.AttackBasico(diana);
            Console.WriteLine(diana.Vida);
            controleDano.AdicionaDanoExtra(diana);
            Console.WriteLine("Dano da diana é " + diana.magico.DanoMagico);
            Console.WriteLine("Dinheiro da diana é" + diana.Dinheiro);

          
         
            Console.WriteLine("Darius----------");
            Console.WriteLine("Vida Do Darius " + darius.Vida);
            Console.WriteLine("Dano do darius é " + darius.fisico.DanoFisico);
            controleDano.AdicionaDanoExtra(darius);
            controleDano.AdicionaDano(darius, Vazio);
            Console.WriteLine("Dano do darius é "+ darius.fisico.DanoFisico);
            Console.WriteLine("Dano do darius é " + darius.magico.DanoMagico);


            Console.ReadLine();
        }
    }
}
