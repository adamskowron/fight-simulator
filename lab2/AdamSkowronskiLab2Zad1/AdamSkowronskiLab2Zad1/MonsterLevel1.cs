using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamSkowronskiLab2Zad1
{
    class MonsterLevel1 : Creature, Fightable
    {
        public override void Attack(object opponent)
        {
            Hero a = (Hero)opponent;
            a.ChangeHealth(-Damage);
            opponent = a;
        }
        /// <summary>
        /// konstruktor z 3 parametrami
        /// </summary>
        /// <param name="health"></param>
        /// <param name="damage"></param>

        public MonsterLevel1(int health, int damage, System.Drawing.Bitmap image)
        {
            this.Health = health;
            this.MaxHealth = health;
            this.Damage = damage;
            this.Image = image;
        }
    }
}
