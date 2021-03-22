using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamSkowronskiLab2Zad1
{
    /// <summary>
    /// Interfejs dla klasy, która może podejmowac walkę
    /// </summary>
    interface Fightable
    {
        void Attack(object opponent); //atak - jako argument przeciwnik, ktoremu zadaje sie obrazenia
        void ChangeHealth(int value); //metoda do zmiany zycia o wartosc value
    }
}
