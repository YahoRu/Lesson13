using Lesson13.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson13.Interfaces;

namespace Lesson13.BattleInfoPrinter
{
    public static class InfoPrinter
    {
        public static void PrintDamageDealt(Creature creature, int damageDealt)
        {
            Console.Write($"{creature.Name} наносит {damageDealt} урона, ");
        }

        public static void PrintDamageTaken(Creature creature, int damageTaken)
        {
            Console.WriteLine($"{creature.Name} получает {damageTaken} урона и у {creature.Name} остается {creature.CurrentHP} HP.");
        }
    }
}
