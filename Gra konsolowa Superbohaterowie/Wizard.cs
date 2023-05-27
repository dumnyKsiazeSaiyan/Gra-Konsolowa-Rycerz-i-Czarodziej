using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_konsolowa_Superbohaterowie
{
    class Wizard : Hero, ISpecialAttack
    {
        public Wizard(string name, int fullHP, Colors color) : base(name, fullHP, color)
        {
        }

        public override void DefaultAttack(Hero hero)
        {
            int hp = rnd.Next(100, 151);
            hero.ActualHP -= hp;
            Console.WriteLine($"\nGracz {Name} zadał {hp} punktów obrażeń graczowie {hero.Name}.");
        }

        public override void Heal()
        {
            int hp = rnd.Next(100, 201);
            ActualHP += hp;
            Console.WriteLine($"\nGracz {Name} uzdrowił się za {hp} punktów życia.");
        }

        public void SpecialAttack(Hero hero)
        {
            int hp = rnd.Next(200, 301);
            hero.ActualHP -= hp;
            Console.WriteLine($"\nAtak Specjalny: Gracz {Name} zadał {hp} punktów obrażeń graczowie {hero.Name}.");
        }
    }
}
