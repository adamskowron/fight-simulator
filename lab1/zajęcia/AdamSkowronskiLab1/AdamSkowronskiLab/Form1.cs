using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdamSkowronskiLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void collorButton_Click(object sender, EventArgs e)
        {
            

            for (int i = 0 ; i < 10 ; i++)
            {
                
                NameLabel.BackColor = Color.Brown;
                Application.DoEvents();
                Thread.Sleep(100);
                NameLabel.BackColor = Color.Blue;
                Application.DoEvents();
                timerColor.Start();
                CollorButton.BackColor = Color.Cyan;
                Application.DoEvents();
                Thread.Sleep(100);
                CollorButton.BackColor = Color.Red;
                Application.DoEvents();
                Thread.Sleep(100);
                this.BackColor = Color.Cyan;
                Application.DoEvents();
                Thread.Sleep(100);
                this.BackColor = Color.Yellow;
                Application.DoEvents();
            }

            MessageBox.Show("zakonczono migawke");
        }

        private void timerColor_Tick(object sender, EventArgs e)
        {
         
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void arg1TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void charComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            string outstr;
            int retint;

            if (charComboBox.Text == "+") 
            {
                string arg1str = arg1TextBox1.Text;
                int arg1int = Int32.Parse(arg1str);

                string arg2str = arg2TextBox.Text;
                int arg2int = Int32.Parse(arg2str);

                retint = arg1int + arg2int;
                outstr = retint.ToString();
                retTextBox.Text = outstr;
            }
           else if (charComboBox.Text == "-")
            {
                string arg1str = arg1TextBox1.Text;
                int arg1int = Int32.Parse(arg1str);

                string arg2str = arg2TextBox.Text;
                int arg2int = Int32.Parse(arg2str);

                retint = arg1int - arg2int;
                outstr = retint.ToString();
                retTextBox.Text = outstr;
            }

           else if (charComboBox.Text == "*")
            {
                string arg1str = arg1TextBox1.Text;
                int arg1int = Int32.Parse(arg1str);

                string arg2str = arg2TextBox.Text;
                int arg2int = Int32.Parse(arg2str);

                retint = arg1int * arg2int;
                outstr = retint.ToString();
                retTextBox.Text = outstr;
            }

           else if (charComboBox.Text == "/")
            {
                string arg1str = arg1TextBox1.Text;
                int arg1int = Int32.Parse(arg1str);

                string arg2str = arg2TextBox.Text;
                int arg2int = Int32.Parse(arg2str);

                if (arg2int == 0)
                {
                    retTextBox.Text = "error";
                }
                else
                {
                    retint = arg1int / arg2int;
                    outstr = retint.ToString();
                    retTextBox.Text = outstr;
                }
            }

        }

        private void retTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void arg2TextBox_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
