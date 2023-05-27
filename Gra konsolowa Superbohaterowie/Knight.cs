using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_konsolowa_Superbohaterowie
{
    class Knight : Hero
    {
        public Knight(string name, int fullHP, Colors color) : base(name, fullHP, color)
        {
        }

        public override void DefaultAttack(Hero hero)
        {
            int hp = rnd.Next(50, 201);
            hero.ActualHP -= hp;
            Console.WriteLine($"\nGracz {Name} zadał {hp} punktów obrażeń graczowie {hero.Name}.");
        }

        public override void Heal()
        {
            int hp = rnd.Next(50, 101);
            ActualHP += hp;
            Console.WriteLine($"\nGracz {Name} uzdrowił się za {hp} punktów życia.");
        }
    }
}
