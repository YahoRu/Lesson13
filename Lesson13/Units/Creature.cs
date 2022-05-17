using Lesson13.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13.Units
{
    abstract public class Creature 
    {
        private const int MIN_ATTACK_SPEED = 50;
        private const int MAX_ATTACK_SPEED = 250;
        private string _name;
        private int _maxHP;
        private int _currentHP;
        private double _armor;
        private bool _isDead = false;
        private int[] _attackDamage = new int[2];
        private int _attackSpeed;
       
        protected readonly Random random = new Random();

        public virtual string Name
        {
            get { return _name; }
            protected set { if (value != null) _name = value; }
        }

        public virtual int MaxHP
        {
            get { return _maxHP; }
            protected set { if (value >= 100 && value <= 1000) _maxHP = value; }
        }

        public virtual int CurrentHP
        {
            get { return _currentHP; }
            set
            {
                if (value > 0 && value <= 1000) _currentHP = value;
                else if (value <= 0)
                {
                    _currentHP = 0;
                    IsDead = true;
                }
            }
        }

        public virtual double Armor
        {
            get { return _armor; }
            protected set { if (value >= 0 && value < 100) _armor = value; }
        }

        public bool IsDead
        {
            get { return _isDead; }
            protected set { if (value) _isDead = value; }
        }

        public virtual int[] AttackDamage
        {
            get { return _attackDamage; }
            set { if (value[0] > 0 && value[0] < value[1] && value[1] < 1000) _attackDamage = value; }
        }

        public virtual int AttackSpeed
        {
            get { return _attackSpeed; }
            protected set { if (value >= MIN_ATTACK_SPEED && value <= MAX_ATTACK_SPEED) _attackSpeed = value; }
        }

        protected Creature()
        {

        }

        protected Creature(string name, int maxHP, double armor, int[] attackDamage, int attackSpeed)
        {
            Name = name;
            MaxHP = maxHP;
            CurrentHP = MaxHP;
            Armor = armor;
            AttackDamage = attackDamage;
            AttackSpeed = attackSpeed;
        }

        public virtual int AmountOfDamageTaken(int incomingDamage)
        {
            return incomingDamage - (int)(((Armor * 0.7) / 100.0) * (double)incomingDamage);
            
        }

        public virtual void TakeDamage(int damageTaken)
        {
            CurrentHP -= damageTaken;
        }

        public virtual int DoDamage()
        {
            return random.Next(AttackDamage[0], AttackDamage[1] + 1);
        }
    }
}
