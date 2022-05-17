using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13.Units
{
    public class Vampire : Monster
    {
        public Vampire()
        {
            Name = "Вампир";
            MaxHP = 600;
            CurrentHP = MaxHP;
            Armor = 10;
            AttackDamage = new int[] { 60, 120 };
            AttackSpeed = 100;
        }

        public override int DoDamage()
        {
            int tmpDamage = random.Next(AttackDamage[0], AttackDamage[1] + 1);
            if (random.Next(0, 101) <= 10)
            {
                CurrentHP += tmpDamage;
                Console.Write($"Вампир хилит себе {tmpDamage} хп ");
            }
            return tmpDamage;
        }
    }
}
