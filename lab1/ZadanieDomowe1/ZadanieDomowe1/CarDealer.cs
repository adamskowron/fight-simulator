using System;

namespace ZadanieDomowe1
{
    internal class CarDealer
    {
        private int sellTime;

        public CarDealer(int value)
        {
            sellTime = value;
        }

        public void SetSellTime(int value) //setter czasu sprzedazy
        {
            sellTime = value;
        }

        public int GetSellTime() //getter czasu sprzedazy
        {
            return sellTime;
        }

        public void DecraseSellTime(int value) // zmiejszenie czasu sprzedazy
        {
            sellTime -= value;
        }
    }
}