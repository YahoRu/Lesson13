using Lesson13.ItemsAndInventars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13.Units.Humanoid
{
    public class Hero : Humanoid
    {
        public Hero()
        {
            Race = RaceType.Human;
            Name = "Герой";
            MaxHP = 600;
            CurrentHP = MaxHP;
            Armor = 30;
            AttackDamage = new int[] { 40, 130 };
            AttackSpeed = 150;
            Intelligence = 30;
            Inventar inventar = new Inventar(this, 10, 5) { };
            inventar.AddItem(new Item("Меч", ItemType.Sword, 50, 7));
        }

        public Hero(string name, double armor, int[] attackDamage, int attackSpeed, int intelligence,
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
            damageTaken = damageTaken - this.Intelligence;
            base.TakeDamage(damageTaken);
        }
    }
}
