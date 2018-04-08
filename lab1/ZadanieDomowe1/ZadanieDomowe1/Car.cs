namespace ZadanieDomowe1
{
    internal class Car
    {
        private int price; //wartosc samochodu

        private static int minPrice = 40000; //poczatkowa min i max wartosc ceny jednego samochodu
        private static int maxPrice = 50000;

        public Car(int price) 
        {
            this.price = price;
        }

        public static void IncraseMinPrice(int value)  //metoda do zwiekszania minimalnej ceny
        {
            minPrice += value;
        }

        public static void IncraseMaxPrice(int value)  //metoda do zwiekszania maxymalnej ceny
        {
            maxPrice += value;
        }

        public static int GetMinPrice()  // getter ceny minimalnej
        {
            return minPrice;
        }

        public static int GetMaxPrice()  //getter ceny maksymalnej
        {
            return maxPrice;
        }

        public override string ToString()  //przeladowanie ToString
        {
            return "Samochod o wartosci: " + this.price.ToString();
        }
    }
}