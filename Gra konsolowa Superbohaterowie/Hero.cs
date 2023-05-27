using System;

namespace Gra_konsolowa_Superbohaterowie
{
    enum Colors
    {
        red,
        green,
        yellow
    }

    interface ISpecialAttack
    {
        void SpecialAttack(Hero hero);
    }
    abstract class Hero
    {
        public string Name { get; }

        public int FullHP { get; }

        private int actualHP;

        public int ActualHP
        {
            get { return actualHP; }
            set
            {
                if (value < 0)
                    actualHP = 0;

                else if (value > FullHP)
                    actualHP = FullHP;

                else
                    actualHP = value;

            }
        }

        public Colors Color { get; set; }

        protected Random rnd = new Random();

        public bool UsedSpecialAttack { get; set; } = false;
        public Hero(string name, int fullhp, Colors color)
        {
            Name = name;
            FullHP = fullhp;
            ActualHP = FullHP;
            Color = color;

        }

        public abstract void DefaultAttack(Hero hero);
        public abstract void Heal();

        public override string ToString()
        {
            return $"{Name} _ {ActualHP}/{FullHP}HP";
        }
    }
}
