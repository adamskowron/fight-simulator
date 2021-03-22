using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamSkowronskiLab2Zad1
{
    class MonsterLevel3: Creature, Fightable
    {
        /// <summary>
        /// Nadpisanie metody Attack
        /// </summary>
        /// <param name="opponent"></param>
        public override void Attack(object opponent)
        {
            Hero temporaryHero = (Hero)opponent; //kopia argumentu wejsciowgo i rzutowanie na Hero
            Random random = new Random();
            if (random.Next(0, 100) > 40)
            {
                temporaryHero.ChangeHealth(-damage);
            }
            else
            {
                temporaryHero.ChangeHealth(-damage - 250); //szansa 60 % na duze dodatkowe obrazenia 
            }

            opponent = temporaryHero; //ustawienie argumentu wejsciowego
        }

        /// <summary>
        /// nadpisanie metody ChngeHealth
        /// </summary>
        /// <param name="value"></param>
        public override void ChangeHealth(int value)
        {
            health += value;
            Random random = new Random();
            if (random.Next(0, 100) < 60) //szansa 60%
            {
                health += 100; //dodatkowe uzdrowienie 100 pkt zdrowia
            }
            else
            {
                health += 300; //dodatkowe duze uzdrowienie
            }
        }
        /// <summary>
        /// konstruktor z 3 parametrami
        /// </summary>
        /// <param name="health"></param>
        /// <param name="damage"></param>
        public MonsterLevel3(int health, int damage, System.Drawing.Bitmap image)
        {
            this.health = health;
            this.maxHealth = health;
            this.damage = damage;
            this.image = image;
        }
    }
}
