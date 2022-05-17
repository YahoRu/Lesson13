using System;
using System.Collections;
using System.Collections.Generic;
using Lesson13.BattleInfoPrinter;
using Lesson13.Units;
using Lesson13.Units.Humanoid;
using Lesson13.BattleArenas;

namespace Lesson13
{
    class Program
    {

        static void Main(string[] args)
        {
            Barbarian barbarian = new Barbarian();
            Vampire vampire = new Vampire();
            Hero hero = new Hero();

            BattleArena.SingleBattle(vampire, BattleArena.SingleBattle(barbarian, hero));
        }
    }
}
