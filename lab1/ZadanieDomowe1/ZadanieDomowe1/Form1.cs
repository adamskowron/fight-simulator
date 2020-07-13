using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZadanieDomowe1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private BindingList<string> strCars = new BindingList<string>(); // lista - bufor do przechowywania samochodow przed sprzedaz

        private Producer producer = new Producer(5000); // ustawienie poczatkowego czasu produkcji na 5 sekund
        private CarDealer carDealer = new CarDealer(8000);  // ustawienie pocztkowego czasu sprzedazy na 8 ssekund

        Random rnd = new Random(); // obiekt klasy radnom do losowania

        private string infoStr = "Program symuluje działanie fabryki, ktora produkuje nowe samochody o wartości z przedziału" +
            "min - max co 5 sekund, które sa umieszczane w magazynie przedstawionym jako lista po prawej stronie." +
            " Co 8 sekund losowy samochód z magazynu jest sprzedawany, a kwota jego sprzedaży jest przekazywana w pule pieniędzy," +
            "za która użytkownik może przyspieszyć czas produkcji,czas sprzedaży lub zwiekszyć wartość produkowanych samochodów.";
            

        private int tempProductionTime = 5000;  // zmienne tymczasowe do sprawdzenia czy uplynal odcinek czasu
        private int tempSellTime = 8000;

        private int cashCounter = 100000; //zmienna do przechowania ilosci gotowki - poczatkowo 100000

        private void productionPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(infoStr,"O programie"); //wiadomosc powitalna
            
            double tmp = (double)1000/(double)producer.GetProductionTime();  // zmienna tymczasowa do obliczenia wspolczynnika produkowanych samochodow / sekunde
            this.carPerSecTextBox.Text = tmp.ToString();

            this.minMaxTextBox.Text = Car.GetMinPrice().ToString() + "/" + Car.GetMaxPrice().ToString(); //ustawienie na poczatku wartosci pola

            tmp = (double)1000 / (double)carDealer.GetSellTime();
            this.sellPerSecTextBox.Text = tmp.ToString();

            this.cashTextBox.Text = cashCounter.ToString();  //ustawienie wartosci pieniedzy poczatkowych 
        }

        private void upgradeProductionButton_Click(object sender, EventArgs e)
        {
            if (producer.GetProductionTime() > 1000) // sprawdzenie czy produkcja nie osiagnela najwiekszej wartosci
            {
                if (cashCounter >= 150000)
                {
                    producer.DecraseProductionTime(1000);  //zmiejszenie czasu produkcji o sekunde
                    double tmp = (double)1000 / (double)producer.GetProductionTime();  // oblicznie wspolczynnika na nowo
                    this.carPerSecTextBox.Text = tmp.ToString();  // aktualizacja pola
                    cashCounter -= 150000;
                    cashTextBox.Text = cashCounter.ToString(); // aktualizacja wyswietlanych pieniedzy
                }
                else
                {
                    MessageBox.Show("Brak wystarczających funduszy na ulepszenie");
                }
            }
            else
            {
                MessageBox.Show("Produkcja osiągneła najwieksza wartość. Nie można bardziej przyśpieszyc");
            }
        }

        private void upgradeQualityButton_Click(object sender, EventArgs e)
        {
            if (Car.GetMaxPrice() < 500000)
            {
                if (cashCounter >= 100000)
                {
                    Car.IncraseMinPrice(10000); //zwiekszenie minimalnych i maksymalnych wartosci samochodow
                    Car.IncraseMaxPrice(10000);
                    cashCounter -= 100000; //odjecie kwoty zakupu
                    cashTextBox.Text = cashCounter.ToString(); //aktualizacja pola z pieniedzmi
                    minMaxTextBox.Text = Car.GetMinPrice().ToString() + "/" + Car.GetMaxPrice().ToString(); //aktualizacja pola z warotosciami min - max
                }
                else
                {
                    MessageBox.Show("Brak wystarczajacych funduszy na ulepszenie");
                }
            }
            else
            {
                MessageBox.Show("Osiagnieto najwyższą możliwa cenę. Nie można jej zwiekszyć");
            }
        }

        private void mainTableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simulatorTimer_Tick(object sender, EventArgs e)
        {
            

            if(tempProductionTime <= 0) // sprawdzenie czy uplynal odcinek czasu
            {
                tempProductionTime = producer.GetProductionTime(); // po uplywie czasu produkcji ustawiany jest nowy czas w zmiennej tymczasowego czasu
           
                Car car = new Car(rnd.Next(Car.GetMinPrice(), Car.GetMaxPrice())); //nowy samochod o wartosci z przedzialu min-max
                strCars.Add(car.ToString());  // dodanie do listy Stringa reprezentujacego ten samochod
                carsListBox.DataSource = strCars;  //ustawienie listy strCars jako zrodla dla listboxa
                tempProductionTime -= simulatorTimer.Interval;  //odjecie odcinka czasu
            }
            else
            {
                tempProductionTime -= simulatorTimer.Interval; // odjecie odcinka czasu
            }

            if (tempSellTime <= 0 && strCars.Count() > 0)  //akcja po uplynieciu czasu sprzedazy i jesli w magazynie sa jakies samochody
            {
                tempSellTime = carDealer.GetSellTime(); // po uplywie czasu produkcji ustawiany jest nowy czas

                int index = rnd.Next(0, strCars.Count() - 1); //wylosowanie losowego indeksu ze wszystkich samochodow

                string tmpStr = strCars[index];  //pobranie elementu z listy o wylosowanym indeksie do zmiennej tymczasowej
                StringBuilder sb = new StringBuilder();
                foreach (char c in tmpStr)  //petla foreach w celu stworzenia stringa o samych cyfrach
                {
                    if (c >= '0' && c <= '9')
                        sb.Append(c);
                }

                cashCounter += Int32.Parse(sb.ToString()); //zmiana string na int
                cashTextBox.Text = cashCounter.ToString(); //aktualizacja pola
                strCars.RemoveAt(index);  //usuniecie z listy sprzedanego samochodu
                
                tempSellTime -= simulatorTimer.Interval;
            }
            else
            {
                tempSellTime -= simulatorTimer.Interval;
            }


        }

        private void upgradeSellButton_Click(object sender, EventArgs e)
        {
            if (carDealer.GetSellTime() > 2000)  //sprawdzenie czy samochochody nie sprzedaja sie szybciej niz 2 sekundy
            {
                if (cashCounter >= 100000)// sprawdzenie czy kwota jest wystarczajacca
                {
                    carDealer.DecraseSellTime(1000);  //zmiejszenie czasu o sekunde
                    double tmp = (double)1000 / (double)carDealer.GetSellTime();  // ustawienie pol na poczatku dzialania programu
                    this.sellPerSecTextBox.Text = tmp.ToString();
                    cashCounter -= 100000;  // odjecie kwoty zakupu
                    cashTextBox.Text = cashCounter.ToString(); 
                }
                else
                {
                    MessageBox.Show("Brak wystarczajajacych funduszy na ulepszenie");
                }
            }
            else
            {
                MessageBox.Show("Sprzedaz osiągnela najwieksza wartosc. Nie mozna bardziej przyspieszyc");
            }
        }

        private void RestartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart(); //ponowne wlaczenie aplikacji
        }

        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(infoStr,"O programie");
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor: Adam Skowronski","Autor");
        }
    }
}
