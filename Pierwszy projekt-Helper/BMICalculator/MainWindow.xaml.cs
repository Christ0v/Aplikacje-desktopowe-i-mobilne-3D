using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BMICalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            float result;
            result = (float.Parse(textBoxBodyWeight.Text) / ((float.Parse(textBoxHeight.Text)/100) * (float.Parse(textBoxHeight.Text)/100)));

            if (textBoxBodyWeight.Text == "")
            {
                textBlockResult.Text = "Nie podano masy ciała";
            }
            if (textBoxHeight.Text == "")
            {
                textBlockResult.Text = "Nie podano wysokości";
            }

            if (textBoxHeight.Text == "" && textBoxBodyWeight.Text == "")
                textBlockResult.Text = "Nie podałeś ani wagi ani wzrostu";
            if (result < 16f )
                textBlockResult.Text = "Wygłodzenie. " + "Twoje BMI wynosi: " + Math.Round(result,2);
            if (result >= 16f && result <= 16.99f)
                textBlockResult.Text = "Wychudzenie. " + "Twoje BMI wynosi: " + Math.Round(result, 2);
            if (result >=17f && result <=18.49f)
                textBlockResult.Text = "Niedowaga. " + "Twoje BMI wynosi: " + Math.Round(result, 2);
            if (result >= 18.5f && result <= 29.9f)
                textBlockResult.Text = "Waga prawidłowa. " + "Twoje BMI wynosi: " + Math.Round(result, 2);
            if (result >= 25.0f && result <= 29.99f)
                textBlockResult.Text = "Nadwaga. " + "Twoje BMI wynosi: " + Math.Round(result, 2);
            if (result >= 30.0f && result <= 34.99f)
                textBlockResult.Text = "Nadwaga I stopnia. " + "Twoje BMI wynosi: " + Math.Round(result, 2);
            if (result >= 35.0f && result <= 39.99f)
                textBlockResult.Text = "Nadwaga II stopnia. " + "Twoje BMI wynosi: " + Math.Round(result, 2);
            if (result >= 40.0f)
                textBlockResult.Text = "Otyłość skrajna. " + "Twoje BMI wynosi: " + Math.Round(result,2);

        }
    }
}
