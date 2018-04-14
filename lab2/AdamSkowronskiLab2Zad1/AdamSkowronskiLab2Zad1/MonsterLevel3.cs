using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamSkowronskiLab2Zad1
{
    class MonsterLevel3: Creature, Fightable
    {
        public override void Attack(object opponent)
        {
            Hero a = (Hero)opponent; //kopia argumentu wejsciowgo i rzutowanie na Hero
            Random rnd = new Random();
            if (rnd.Next(0, 100) > 40) //szansa 40%
            {

                a.ChangeHealth(-Damage);

            }
            else
            {
                a.ChangeHealth(-Damage - 250); //szansa 60 % na duze dodatkowe obrazenia 
            }

            opponent = a; //ustawienie argumentu wejsciowego
        }

        public override void ChangeHealth(int value)
        {
            Health += value;
            Random rnd = new Random();
            if (rnd.Next(0, 100) < 60) //szansa 60%
            {
                Health += 100; //uzdrowienie 100 pkt zdrowia
            }
            else
            {
                Health += 300; //duze uzdrowienie
            }
        }
        /// <summary>
        /// konstruktor z 3 parametrami
        /// </summary>
        /// <param name="health"></param>
        /// <param name="damage"></param>
        public MonsterLevel3(int health, int damage, System.Drawing.Bitmap image)
        {
            this.Health = health;
            this.MaxHealth = health;
            this.Damage = damage;
            this.Image = image;
        }
    }
}
