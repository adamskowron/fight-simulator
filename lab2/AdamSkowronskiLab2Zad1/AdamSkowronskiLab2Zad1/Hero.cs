using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamSkowronskiLab2Zad1
{
    /// <summary>
    /// klasa bohatera
    /// </summary>
    class Hero: Fightable
    {
        private int Health;
        private int MaxHealth;
        private int Condition;
        private int Damage;
        private int Money;
        private int Level;

        /// <summary>
        /// konstruktor przypisujacy wszystkie atrybuty bohatera
        /// </summary>
        /// <param name="health"></param>
        /// <param name="maxHealth"></param>
        /// <param name="contition"></param>
        /// <param name="damage"></param>
        /// <param name="money"></param>
        /// <param name="level"></param>
        public Hero(int health,int contition,int damage,int money,int level)
        {
            this.Health = health;
            this.MaxHealth = health;
            this.Condition = contition;
            this.Damage = damage;
            this.Money = money;
            this.Level = level;
        }
        /// <summary>
        /// implementacja metody ataku z interfejsu fightable
        /// </summary>
        /// <param name="opponent"></param>
        public void Attack(object opponent)
        {
            Creature a = (Creature)opponent; //tymczasowa zmienna a, rzutowanie opponent do obiektu klasy Creature
            a.ChangeHealth(-this.Damage); // zmiana zycia
            opponent = a; //zmiana argumentu wejsciowego funkcji
        }
        /// <summary>
        /// implementacja 2 metody interfejsu do zmiany zycia
        /// </summary>
        /// <param name="value"></param>
        public void ChangeHealth(int value)
        {
            Health += value;
        }

        public void ChangeCondition(int value)
        {
            Condition += value;
        }

        public void ChangeAttack(int value)
        {
            Damage += value;
        }

        public void ChangeMoney(int value)
        {
            Money += value;
        }

        public void LevelUp()
        {
            Level += 1;
        }

        public int GetMoney()
        {
            return Money;
        }

        public int GetHealth()
        {
            return Health;
        }

        public int GetMaxHealth()
        {
            return MaxHealth;
        }

        public int GetCondition()
        {
            return Condition;
        }

        internal int GetLevel()
        {
            return Level;
        }

        public int GetDamage()
        {
            return Damage;
        }
    }
}
