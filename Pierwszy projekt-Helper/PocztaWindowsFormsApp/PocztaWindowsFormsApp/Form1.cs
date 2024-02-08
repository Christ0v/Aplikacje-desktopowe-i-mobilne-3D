using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PocztaWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonCheck_Click(object sender, EventArgs e)
        {
            if (radioButtonPocztowka.Checked)
            {
                pictureBox.Image = Properties.Resources.pocztowka;
                labelWynik.Text = "Cena: 1zł";
            }
            else if (radioButtonList.Checked)
            {
                pictureBox.Image = Properties.Resources.list;
                labelWynik.Text = "Cena: 1,5zł";
            }
            else if (radioButtonPaczka.Checked)
            {
                pictureBox.Image = Properties.Resources.paczka;
                labelWynik.Text = "Cena: 10zł";
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            int test;
            bool parsujInt = int.TryParse(textBoxKodPocztowy.Text, out test);
            if (textBoxKodPocztowy.Text.Length != 5)
            {
                MessageBox.Show("Nieprawidłowa liczba cyfr w kodzie pocztowym");
            }
            else if (!parsujInt)
            {
                MessageBox.Show("Kod pocztowy powinien się składać z samych cyfr");
            }
            else
            {
                MessageBox.Show("Dane przesyłko zostały wprowadzone");
            }
        }
    }
}
