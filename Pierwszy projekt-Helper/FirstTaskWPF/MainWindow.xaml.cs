using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
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

namespace FirstTaskWPF
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
            int number;
            if(string.IsNullOrWhiteSpace(textBoxUserName.Text) || textBoxUserName.Text == "")
            //if (textBoxUserName.Text == "")
            {
                textBlockResult.Text = "Nie podano imienia ";
            }
            
            if (textBoxAge.Text == "")
            {
                textBlockResult.Text = "Nie podano wieku";
            }

            if ((textBoxAge.Text == "" && textBoxUserName.Text == "") || (string.IsNullOrWhiteSpace(textBoxUserName.Text) && textBoxAge.Text == ""))
            {
                textBlockResult.Text = "Nie podano wieku i imienia";
            }

            if (!int.TryParse(textBoxAge.Text, out number) && textBoxAge.Text != "")
            {
                textBlockResult.Text = "Wiek podaj w liczbach";
            }

            if (int.TryParse(textBoxAge.Text, out number) && number >= 18 && textBoxUserName.Text != "" && !string.IsNullOrWhiteSpace(textBoxUserName.Text))
            {
              textBlockResult.Text = "Osoba " + textBoxUserName.Text + " osoba pełnoletnia";
            }
            if (int.TryParse(textBoxAge.Text, out number) && number < 18 && textBoxUserName.Text != "" && !string.IsNullOrWhiteSpace(textBoxUserName.Text))
                textBlockResult.Text = "Osoba " + textBoxUserName.Text + " nie jest pełnoletnia";
            
        }
    }
}
