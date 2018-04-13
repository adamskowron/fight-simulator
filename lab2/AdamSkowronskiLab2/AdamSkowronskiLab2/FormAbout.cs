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
    public partial class FormAbout : Form
    {
        /// <summary>
        /// nazwa do przekazania
        /// </summary>
        public string nameTransfer;

        public FormAbout()
        {
            InitializeComponent();
        }

        private void FormAbout_Load(object sender, EventArgs e)
        {
            textBox.Text = nameTransfer;
        }
    }
}
