using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamSkowronskiLab2Zad1
{
    class MonsterLevel2 :Creature, Fightable
    {
        /// <summary>
        /// nadpisanie metody Attack
        /// </summary>
        /// <param name="opponent"></param>
        public override void Attack(object opponent)
        {
            Hero temporaryHero = (Hero)opponent; //kopia argumentu wejsciowgo i rzutowanie na Hero
            Random random = new Random();
            if (random.Next(0, 100) > 60) //szansa 60%
            {
                temporaryHero.ChangeHealth(-damage);
            }
            else
            {
                temporaryHero.ChangeHealth(-damage - 100); //szansa na dodatkowe obrazenia 
            }

            opponent = temporaryHero; //ustawienie argumentu wejsciowego
        }

        /// <summary>
        /// nadpisanie metody ChangeHealth
        /// </summary>
        /// <param name="value"></param>
        public override void ChangeHealth(int value)
        {
            health += value;
            Random rnd = new Random();
            if (rnd.Next(0,100) < 40 ) //szansa 40%
            {
                health += 100; //uzdrowienie 100 pkt zdrowia
            }
        }
        /// <summary>
        /// konstruktor z 3 parametrami
        /// </summary>
        /// <param name="health"></param>
        /// <param name="damage"></param>
        public MonsterLevel2(int health, int damage, System.Drawing.Bitmap image)
        {
            this.health = health;
            this.maxHealth = health;
            this.damage = damage;
            this.image = image;
        }
    }
}
