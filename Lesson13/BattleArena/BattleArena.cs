using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson13.Interfaces;
using Lesson13.Units;
using Lesson13.BattleInfoPrinter;

namespace Lesson13.BattleArenas
{
    public static class BattleArena
    {
        public static Creature SingleBattle(Creature creature1, Creature creature2)
        {
            int creature1AttackSpeedCounter = 300;
            int creature2AttackSpeedCounter = 300;

            while (!(creature1.IsDead) && !(creature2.IsDead))
            {
                if (creature1AttackSpeedCounter <= creature1.AttackSpeed)
                {
                    int tmpDoDamage = creature1.DoDamage();
                    InfoPrinter.PrintDamageDealt(creature1, tmpDoDamage);
                    int tmpTakingDamage = creature2.AmountOfDamageTaken(tmpDoDamage);
                    creature2.TakeDamage(tmpTakingDamage);
                    InfoPrinter.PrintDamageTaken(creature2, tmpTakingDamage);
                    creature1AttackSpeedCounter = 300;
                }

                if (creature2.IsDead) break;

                if (creature2AttackSpeedCounter <= creature2.AttackSpeed)
                {
                    int tmpDoDamage = creature2.DoDamage();
                    InfoPrinter.PrintDamageDealt(creature2, tmpDoDamage);
                    int tmpTakingDamage = creature2.AmountOfDamageTaken(tmpDoDamage);
                    creature1.TakeDamage(tmpTakingDamage);
                    InfoPrinter.PrintDamageTaken(creature1, tmpTakingDamage);
                    creature2AttackSpeedCounter = 300;
                }

                creature1AttackSpeedCounter -= 1;
                creature2AttackSpeedCounter -= 1;
            }

            if (creature1.IsDead)
            {
                Console.WriteLine($"{creature1.Name} пал! Победил {creature2.Name}!");
                creature2.CurrentHP = creature2.MaxHP;
                return creature2;
            }
            else
            {
                Console.WriteLine($"{creature2.Name} пал! Победил {creature1.Name}!");
                creature1.CurrentHP = creature1.MaxHP;
                return creature1;
            }
    }
    }
}
