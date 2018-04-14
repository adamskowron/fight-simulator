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
       protected int Health;
       protected int MaxHealth;
       protected int Damage;
       protected System.Drawing.Bitmap Image; // zmienna do przechowania animacji



        abstract public void Attack(object opponent); //impelmentacja interfejsu Fightable
        virtual public void ChangeHealth(int value) //impelmentacja interfejsu Fightable
        {
            Health += value; 
        }
         public int GetHealth()
        {
            return Health;
        }
         public int GetMaxHealth()
        {
            return MaxHealth;
        }
        public System.Drawing.Bitmap GetImage() //getter obrazka
        {
            return Image;
        }
    }
}
