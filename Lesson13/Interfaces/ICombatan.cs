using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13.Interfaces
{
    public interface ICombatan
    {

        int[] AttackDamage { get; set; }

        int AmountOfDamageTaken(int incomingDamage);

        void TakeDamage(int damageTaken);

        int DoDamage();
    }
}
