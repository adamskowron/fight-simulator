using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamSkowronskiLab2Zad1
{
    /// <summary>
    /// klasa abstrakcyjna potwora
    /// </summary>
    abstract class Creature: Fightable
    {
       protected int health;
       protected int maxHealth;
       protected int damage;
       protected System.Drawing.Bitmap image; // zmienna do przechowania animacji



        abstract public void Attack(object opponent); //impelmentacja interfejsu Fightable
        virtual public void ChangeHealth(int value) //impelmentacja interfejsu Fightable
        {
            health += value; 
        }
         public int GetHealth()
        {
            return health;
        }
         public int GetMaxHealth()
        {
            return maxHealth;
        }
        public System.Drawing.Bitmap GetImage() //getter obrazka
        {
            return image;
        }
    }
}
