using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class PierwiastekRownaniaKwadratowego : Form
    {
        public PierwiastekRownaniaKwadratowego()
        {
            InitializeComponent();
        }

        private void buttonPolicz_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            int c;
            if (int.TryParse(textBoxA.Text, out a) && int.TryParse(textBoxB.Text, out b) && int.TryParse(textBoxA.Text, out c) )
            {
                double delta = (b * b) - (4 * a * c);
                if (delta == 0)
                {
                    int x0;
                    x0 = -b / (2 * a);
                    labelWynik.Text = "Miejsce zerowe to: " + x0;
                }
                else if (delta < 0)
                {
                    
                    labelWynik.Text = "Brak pierwiastków delta nie może być ujemna: ";

                }
                else if (delta > 0)
                {
                    double pierwiastekDelta = Math.Sqrt(delta);
                    double x1 , x2;
                    x1 = (-b + pierwiastekDelta) / 2 * a;
                    x2 = (-b - pierwiastekDelta) / 2 * a;
                    labelWynik.Text = "Pierwsze miejsce zerowe: " + x1 + "drugie miejsce zerowe" + x2;
                } 
            } 
        }
    }
}
