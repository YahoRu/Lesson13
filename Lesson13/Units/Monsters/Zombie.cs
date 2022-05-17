using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13.Units
{
    public class Zombie : Monster
    {
        public Zombie()
        {
            Name = "Зомби";
            MaxHP = 500;
            Armor = 0;
            AttackDamage = new int[] { 30, 70 };
            AttackSpeed = 70;
        }
    }
}
