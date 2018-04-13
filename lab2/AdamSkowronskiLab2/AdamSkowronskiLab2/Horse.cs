using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamSkowronskiLab2
{
    class Horse :Creature, IMovable
    {
      //  int field; //pole
       // public int Filed { get;private set; } //properties metoda do przypisywanie lub dodania wartosci
       public string Name { get; set; }
       public string FavouriteColor { get; set; }

        /// <summary>
        /// konstruktor parametryczny
        /// </summary>
        /// <param name="newName">nowe imie dla konia</param>
        /// <param name="FavourteColor">ulubiony kolor</param>
        public Horse(string newName,string FavourteColor)
        {
            maxSpeed = 420;
            this.Name = newName;
            this.FavouriteColor = FavouriteColor;
        }

        public string DoSomething()
        {
            return "do something";
        }

        public override string ToString()
        {
            return $"My name is {Name} and my favourte color is {FavouriteColor}";
        }

        public string Go()
        {
            return $"Im going";
        }
    }
}
