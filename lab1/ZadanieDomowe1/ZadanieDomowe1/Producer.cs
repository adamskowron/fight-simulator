namespace ZadanieDomowe1
{

    

    internal class Producer
    {

        private int productionTime;

        public Producer(int value)
        {
            productionTime = value;
        }

        public void SetProductionTime(int value) //setter czasu producji
        {
            productionTime = value;
        }

        public int GetProductionTime() // getter czasu produkcji
        {
            return productionTime;
        }

        public void DecraseProductionTime(int value) //metoda do zmiejszenia czasu produkcji
        {
            productionTime -= value;
        }

    }
}