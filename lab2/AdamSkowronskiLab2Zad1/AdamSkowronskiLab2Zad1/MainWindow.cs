using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AdamSkowronskiLab2Zad1
{
    public partial class MainWindow : Form
    {
        private Hero player;
        private int healthPotionCounter = 0;
        private int conditionPotionCounter = 0;
        private List<Creature> monsters; // lista obiektow abstrakcyjnej klasy Creature z przeciwnikami (beda do niej dodawane obiekty dziedziczace po tej klasie)
        private const int AttackAnimationLenght = 800; //stala - dlugosc gifa atakujacego bohatera trwa 800 ms
        private int timerIndex = 0; //index dla timera do odmierzania odcinkow czasu
        private const string About = "Program jest symulatorem walki gracza z 3 kolejno silniejszymi potworami" +
            ". Kazda rozgrywka powinna wygladac inaczej, poniewaz kazdy poziom potworow losuje sposrod 3 roznych animacji i roznych wartosci ataku i zycia." +
            "Walka odbywa sie turowo(naciskajac przycisk ATTACK). Aby wygrać trzeba pokonać wszystkie potwory " +
            "samemu przy tym nie ginac. Zycie mozna uzupelniac przez mikstury leczace, ktore sa do kupienia za " +
            "pieniadze dodawane za pokonanie przeciwnika. Za pieniadze mozna tez ulepszyc atak i kupic mikstury" +
            " przywracjace kondycje. Jest to wersja probna, mozna dowolnie przedluzyac rozgrywke dolaczajac do listy monsters " +
            "kolejne obiekty klas potworow dziedziczace po klasie Creature";

        public MainWindow()
        {
            InitializeComponent();

            //ustawienie jako rodzica obrazow obrazu otoczenia w celu możliwości ustawienia przezroczystego
            //tła wzgledem obrazu otoczenia
            pictureBoxBackground.Controls.Add(pictureBoxHero);
            pictureBoxBackground.Controls.Add(pictureBoxOpponent);
            pictureBoxBackground.Controls.Add(labelHealth);
            pictureBoxBackground.Controls.Add(labelCondition);
            pictureBoxBackground.Controls.Add(labelCash);
            pictureBoxBackground.Controls.Add(labelCashCounter);
            pictureBoxBackground.Controls.Add(labelConditionPotion);
            pictureBoxBackground.Controls.Add(labelConditionPotionCounter);
            pictureBoxBackground.Controls.Add(labelHealthPotion);
            pictureBoxBackground.Controls.Add(labelHealthPotionCounter);

            player = new Hero(1500, 100, 200, 250, 0); //inicjalicacja początkowych atrybutow gracza

            monsters = new List<Creature>(); //inicjalizacja listy przeciwnikow
            Random random = new Random(); // obiekt rnd do generowania wartosci losowych
            int draw =  random.Next(0, 100); //zmienna tymczasowa z wynikiem losowania od 0 do 100
            
            if (draw <= 33) 
            {
                monsters.Add(new MonsterLevel1(400, 250,Properties.Resources.opponentA));
            }
            else if (draw <= 66)
            {
                monsters.Add(new MonsterLevel1(450, 200, Properties.Resources.opponentB));
            }
            else
            {
                monsters.Add(new MonsterLevel1(420, 250, Properties.Resources.opponentC));
            }

            draw = random.Next(0, 100); // kolejne losowanie
            if (draw <= 33)
            {
                monsters.Add(new MonsterLevel2(580, 250, Properties.Resources.opponentD));
            }
            else if (draw <= 66)
            {
                monsters.Add(new MonsterLevel2(620, 250, Properties.Resources.opponentE));
            }
            else
            {
                monsters.Add(new MonsterLevel2(600, 200, Properties.Resources.opponentF));
            }

            draw = random.Next(0, 100); // kolejne losowanie

            if (draw <= 33)
            {
                monsters.Add(new MonsterLevel3(680, 250, Properties.Resources.opponentG));
            }
            else if (draw <= 66)
            {
                monsters.Add(new MonsterLevel3(700, 200, Properties.Resources.opponentH));
            }
            else
            {
                monsters.Add(new MonsterLevel3(650, 250, Properties.Resources.opponentI));
            }

            // w liscie monsters znajduja sie 3 elementy - od najslabszego przeciwnika do najmocniejszego
            //kazdy element ma wylosowane wartosci inicjalizujace oraz obrazki, wiec gra za kazda rozgrywka
            //powinna byc inna
            pictureBoxOpponent.Image = monsters[player.GetLevel()].GetImage(); //ustawienie obrazka 1 przeciwnika
            labelCashCounter.Text = player.GetMoney().ToString();
        }

        /// <summary>
        /// Wcisniecie przycisku attack
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAttack_Click(object sender, EventArgs e)
        {
            if (player.GetCondition() < 20)
            {
                MessageBox.Show("Not enaught condition");
            }
            else
            {
                    pictureBoxOpponent.Image = monsters[player.GetLevel()].GetImage(); // ustawienie gifa przeciwnika

                player.Attack(monsters[player.GetLevel()]); //atak gracza

                player.ChangeCondition(-20);    //zmiana kondycji po ataku

                progressBarCondition.Value = player.GetCondition(); //ustawienie paska kondycji

                //obliczenie procentowego zycia przeciwnika w zmiennej tymczasowej
                float monsterHealthPercent = ( 
                            (float)(monsters[player.GetLevel()].GetHealth()) /
                            (float)(monsters[player.GetLevel()].GetMaxHealth())) * (float)100;
                if (monsterHealthPercent < 0)
                {
                    monsterHealthPercent = 0;
                }
                progressBarMonsterHealth.Value = (int)monsterHealthPercent;   //Ustawienie wartosci paska zycia przeciwnika w %

                monsters[player.GetLevel()].Attack(player); //atak przeciwnika

                float heroHealthPercent = (float)player.GetHealth() / (float)player.GetMaxHealth() * (float)100;
                if (heroHealthPercent < 0)
                {
                    heroHealthPercent = 0;
                }
                progressBarHeroHealth.Value = (int)heroHealthPercent;   //ustawienie paska zycia gracza


                if ((monsters[player.GetLevel()].GetHealth() <= 0) && (player.GetLevel() != monsters.Count() - 1))
                {
                    //pokonanie przeciwnika
                    player.LevelUp();
                    progressBarMonsterHealth.Value = 100; //ustawienie paska zycia przeciwnika na 100

                    player.ChangeMoney(250);
                    labelCashCounter.Text = player.GetMoney().ToString(); //ustawienie licznika pieniedzy

                    pictureBoxOpponent.Image = monsters[player.GetLevel()].GetImage(); //ustawienie animacji nowego przeciwnika
                }
                else if (player.GetHealth() <= 0)
                {
                    //przegrana
                    DialogResult dr = MessageBox.Show("Defeat","Do you want to play again?", MessageBoxButtons.YesNo);
                    if(dr == DialogResult.Yes)
                    {
                        Application.Restart();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                else if (monsters[monsters.Count() - 1].GetHealth() <= 0)
                {
                    //wygrana
                    DialogResult dr = MessageBox.Show("Victory !!!", "Do you want to play again?", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        Application.Restart();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                
                pictureBoxHero.Image = Properties.Resources.AttackingHero;
                timerAttackAnimation.Start(); //start timera sluzacego odmierzenia czasu animacji ataku i przywrocenia animacji stojacego bohatera


            }
        }
        /// <summary>
        /// timer, ktory jesli odmierzy ilosc czasu rowna dlugosci animacji ataku przywraca animacje
        /// stojacego bohatera i sie zatrzymuje
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerAttackAnimation_Tick(object sender, EventArgs e)
        {

            if (timerAttackAnimation.Interval * timerIndex >= AttackAnimationLenght)
            {
                pictureBoxHero.Image = Properties.Resources.StandingHero; //przywrocenie animacji pierwotnej
                buttonAttack.Enabled = true; // odblokowanie ataku
                timerIndex = 0; // zerowanie indexu
                timerAttackAnimation.Stop(); //zatrzymanie timera
            }
            else
            {
                buttonAttack.Enabled = false; // na czas wykonywania ataku zablokowana mozliwosc ponownego ataku
                timerIndex++;
            }
        }

        /// <summary>
        /// wcisniecie przyisku upgrade attakck
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonUpgradeAttack_Click(object sender, EventArgs e)
        {
            if (player.GetMoney() >= 150) //sprawdzenie czy jest wystarczajca ilosc pieniedzy
            {
                player.ChangeAttack(150); 
                player.ChangeMoney(-150);
                MessageBox.Show("Attack upgraded", "Info");
                labelCashCounter.Text = player.GetMoney().ToString();
            }
            else
            {
                MessageBox.Show("Not enought money", "Info");
            }
        }

        /// <summary>
        /// wcisniecie przycisku buy health button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonBuyHealthPotion_Click(object sender, EventArgs e)
        {
            if(player.GetMoney() >= 50)
            {
                healthPotionCounter++; //inkrementacja licznika
                player.ChangeMoney(-50); //odjecie pieniedzy
                labelCashCounter.Text = player.GetMoney().ToString(); //ponowne ustawienie pola z pieniedzmi
                labelHealthPotionCounter.Text = healthPotionCounter.ToString(); //ponowne ustawienie pola z licznikiem mikstur leczacych
            }
            else
            {
                MessageBox.Show("Not enought money", "Info");
            }
        }

        /// <summary>
        /// wcisniecie przycisku buy condition button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonConditionPotion_Click(object sender, EventArgs e)
        {
            if (player.GetMoney() >= 25)
            {
                conditionPotionCounter++; //zwiekszenie licznika
                player.ChangeMoney(-25); //odjecie pieniedzy
                labelCashCounter.Text = player.GetMoney().ToString(); //ustawienie pola z pieniedzmi
                labelConditionPotionCounter.Text = conditionPotionCounter.ToString(); //ustawwienie pola z licznikiem
            }
            else
            {
                MessageBox.Show("Not enought money", "Info");
            }
        }

        /// <summary>
        /// wcisniecie przycisku use health potion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonUseHealthPotion_Click(object sender, EventArgs e)
        {
            if (healthPotionCounter > 0)
            {
                if ((player.GetHealth() + 200) <= player.GetMaxHealth())
                {
                    player.ChangeHealth(200); //uleczenie gracza
                    float healthPercent = (float)player.GetHealth() / (float)(player.GetMaxHealth()) * (float)100; //zmienna tymczasowa do obliczenia zycia bohatera w %
                    progressBarHeroHealth.Value = (int)healthPercent; //ustawinie paska zycia
                    healthPotionCounter--; //dekrementacja licznika
                    labelHealthPotionCounter.Text = healthPotionCounter.ToString(); //ponowne ustawienie pola z licznikiem mikstur leczacych
                }
                else
                {
                    MessageBox.Show(" You cannot have more healt than max value", "Info");
                }
            }
            else
            {
                MessageBox.Show("Buy Health potion first !!!", "Info");
            }
        }

        /// <summary>
        /// wcisniecie przycisku use condition potion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonUseConditionPotion_Click(object sender, EventArgs e)
        {
            if (conditionPotionCounter > 0)
            {
                if (player.GetCondition() + 35 <= 100) //sprzwdzenie czy po uzyciu kondycja nie przekroczy 100
                {
                    conditionPotionCounter--; //dekrementacja licznika
                    player.ChangeCondition(35); //dodanie kondycji
                    progressBarCondition.Value = player.GetCondition(); //aktualizacja paska kondycji
                    labelConditionPotionCounter.Text = conditionPotionCounter.ToString(); //ponowne ustawienie pola z licznikiem mikstur leczacych
                }
                else
                {
                    MessageBox.Show(" You cannot have more condition than max value", "Info");
                }
            }
            else
            {
                MessageBox.Show("Buy condition potion first !!!", "Info");
            }
        }

        /// <summary>
        /// reset
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RestartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        /// <summary>
        /// informacje o autorze
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adam Skowronski","Autor");
        }

        /// <summary>
        /// wyswietlenie informacji o programie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(About,"About");
        }
    }
}
