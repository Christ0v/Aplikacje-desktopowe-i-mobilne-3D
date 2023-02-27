using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            int wynik = 0;

            if (radioButtonPytanie1C.Checked)
                 wynik++;

            if (radioButtonPytanie2C.Checked)
                wynik++;

            if (checkBoxPytanie3B.Checked && checkBoxPytanie3C.Checked && (checkBoxPytanie3A.Checked == false) && (checkBoxPytanie3D.Checked == false))
                wynik++;

            if(textBoxPytanie4Odp.Text == "Ziemia")
                wynik++;
            MessageBox.Show("Zdobyłeś " + wynik + " na 4 punkty");

        }
    }
    
}
