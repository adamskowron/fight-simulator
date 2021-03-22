using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamSkowronskiLab2Zad1
{
    class MonsterLevel1 : Creature, Fightable
    {
        /// <summary>
        /// nadpisanie metodu attack
        /// </summary>
        /// <param name="opponent"></param>
        public override void Attack(object opponent)
        {
            Hero temporaryHero = (Hero)opponent;
            temporaryHero.ChangeHealth(-damage);
            opponent = temporaryHero;
        }
        /// <summary>
        /// konstruktor z 3 parametrami
        /// </summary>
        /// <param name="health"></param>
        /// <param name="damage"></param>
        public MonsterLevel1(int health, int damage, System.Drawing.Bitmap image)
        {
            this.health = health;
            this.maxHealth = health;
            this.damage = damage;
            this.image = image;
        }
    }
}
