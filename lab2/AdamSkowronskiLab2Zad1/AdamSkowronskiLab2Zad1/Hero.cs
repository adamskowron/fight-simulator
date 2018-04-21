using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdamSkowronskiLab2Zad1
{
    /// <summary>
    /// klasa bohatera
    /// </summary>
    class Hero: Fightable
    {
        private int health;
        private int maxHealth;
        private int condition;
        private int damage;
        private int money;
        private int level;

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
            this.health = health;
            this.maxHealth = health;
            this.condition = contition;
            this.damage = damage;
            this.money = money;
            this.level = level;
        }
        /// <summary>
        /// implementacja metody ataku z interfejsu fightable
        /// </summary>
        /// <param name="opponent"></param>
        public void Attack(object opponent)
        {
            Creature temporaryCreature = (Creature)opponent; //tymczasowa zmienna a, rzutowanie opponent do obiektu klasy Creature
            temporaryCreature.ChangeHealth(-this.damage); // zmiana zycia
            opponent = temporaryCreature; //zmiana argumentu wejsciowego funkcji
        }
        /// <summary>
        /// implementacja 2 metody interfejsu do zmiany zycia
        /// </summary>
        /// <param name="value"></param>
        public void ChangeHealth(int value)
        {
            health += value;
        }

        public void ChangeCondition(int value)
        {
            condition += value;
        }

        public void ChangeAttack(int value)
        {
            damage += value;
        }

        public void ChangeMoney(int value)
        {
            money += value;
        }

        public void LevelUp()
        {
            level += 1;
            MessageBox.Show("LEVEL UP","Info");
        }

        public int GetMoney()
        {
            return money;
        }

        public int GetHealth()
        {
            return health;
        }

        public int GetMaxHealth()
        {
            return maxHealth;
        }

        public int GetCondition()
        {
            return condition;
        }

        internal int GetLevel()
        {
            return level;
        }

        public int GetDamage()
        {
            return damage;
        }
    }
}
