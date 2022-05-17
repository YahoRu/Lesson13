using Lesson13.Interfaces;
using Lesson13.ItemsAndInventars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13.Units.Humanoid
{
    abstract public class Humanoid : Creature, ICombatan
    {
        protected RaceType Race { get; set; }
        protected int _intelligence;

        protected Inventar Inventar { get; set; }

        protected int Intelligence
        {
            get { return _intelligence; }
            set { if (value > 0 && value <= 50) _intelligence = value; }
        }

        protected Humanoid() { }

        protected Humanoid(string name, double armor, int[] attackDamage, int attackSpeed, int maxHP) 
            : base(name, maxHP, armor, attackDamage, attackSpeed)
        {

        }
    }
}
