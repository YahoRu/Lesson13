using Lesson13.Interfaces;
using Lesson13.ItemsAndInventars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13.Units.Humanoid
{
    class Barbarian : Humanoid
    {

        public Barbarian()
        {
            Race = RaceType.Human;
            Name = "Варвар";
            MaxHP = 400;
            CurrentHP = MaxHP;
            Armor = 15;
            AttackDamage = new int[] { 90, 100 };
            AttackSpeed = 50;
            Intelligence = 10;
            Inventar inventar = new Inventar(this, 10, 5) { };
            inventar.AddItem(new Item("Меч", ItemType.Sword, 50, 7));
        }

        public Barbarian(string name, double armor, int[] attackDamage, int attackSpeed, int intelligence,
            RaceType race, int maxHP, Inventar inventar) : base(name, armor, attackDamage, attackSpeed, maxHP)
        {
            Race = race;
            Name = name;
            MaxHP = maxHP;
            CurrentHP = maxHP;
            AttackDamage = attackDamage;
            AttackSpeed = attackSpeed;
            Intelligence = intelligence;
            Race = race;
            Inventar = inventar;
        }

        public override void TakeDamage(int damageTaken)
        {
            base.TakeDamage(damageTaken);
            AttackSpeed = 50 + ((MaxHP - CurrentHP) / 2);
        }

        public override string ToString()
        {
            return $"";
        }
    }
}
