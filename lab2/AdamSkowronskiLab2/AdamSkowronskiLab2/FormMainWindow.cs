using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdamSkowronskiLab2
{
    public partial class FormMainWindow : Form
    {
        /// <summary>
        /// zmienna zliczajaca zdarzenia
        /// </summary>
        int counter;

        /// <summary>
        /// utworzenie obiektu nowego okna
        /// </summary>
        FormAbout formAbout = new FormAbout();
        /// <summary>
        /// konstruktor
        /// </summary>

        public FormMainWindow()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// Przycisk do tworzenia nowego okna
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNewWindow_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.nameTransfer = this.textBox1.Text;
            formAbout.ShowDialog(); // nie mozna wyjsc z okna
        }
        /// <summary>
        /// dodanie tekstu do 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShow_Click(object sender, EventArgs e)
        {
            Horse horse = new Horse("Adam","Black");
            
            textBoxConsol.Text += horse + Environment.NewLine;

            textBoxConsol.Text += horse.DoSomething() + Environment.NewLine;
        }
        /// <summary>
        /// przeladowanie ToString
        /// </summary>
        /// <returns>informacja o obiekcie</returns>
       
    }
}
