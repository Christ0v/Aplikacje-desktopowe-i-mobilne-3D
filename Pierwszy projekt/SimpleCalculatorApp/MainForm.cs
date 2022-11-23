﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculatorApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int firstNumber;
            int secondNumber;
            if (int.TryParse(textBoxFirstNumber.Text, out firstNumber)
                && int.TryParse(textBoxSecondNumber.Text, out secondNumber))
            {
                int result = firstNumber + secondNumber;
                labelResult.Text = "Wynik operacji dodawania: " + result;
            }
            else 
            {

                labelResult.Text = "Podano nieprawidłowe dane ";
            }
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            int firstNumber;
            int secondNumber;
            if (int.TryParse(textBoxFirstNumber.Text, out firstNumber)
                && int.TryParse(textBoxSecondNumber.Text, out secondNumber))
            {
                int result = firstNumber - secondNumber;
                labelResult.Text = "Wynik operacji dodawania: " + result;
            }
            else
            {

                labelResult.Text = "Podano nieprawidłowe dane ";
            }
        }
    }
}
