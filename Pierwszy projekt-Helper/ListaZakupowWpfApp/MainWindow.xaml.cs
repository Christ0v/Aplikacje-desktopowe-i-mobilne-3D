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

namespace ListaZakupowWpfApp
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

        private void dodaj_Produkt (object sender, RoutedEventArgs e)
        {
           
            if (string.IsNullOrEmpty(produktTextBox.Text) || string.IsNullOrWhiteSpace(produktTextBox.Text))
            {

                komunikatTextBlock.Text = "Nie podano produktu!"; 
                komunikatTextBlock.Foreground = Brushes.Yellow;
                
            }
            else
            {
                
                listaZakupowListBox.Items.Add(produktTextBox.Text);
                komunikatTextBlock.Text = "Dodano produkt!";
                komunikatTextBlock.Foreground = Brushes.Green;
            }


        }
        private void usun_Produkt(object sender, RoutedEventArgs e)
        {

            if (listaZakupowListBox.SelectedItem == null)
            {
                komunikatTextBlock.Text = "Lista jest pusta lub nie wybrano produktu.";
                komunikatTextBlock.Foreground = Brushes.Yellow;

            }
            else
            {
                listaZakupowListBox.Items.Remove(listaZakupowListBox.SelectedItem);
                komunikatTextBlock.Text = "Usunięto produkt.";
                komunikatTextBlock.Foreground = Brushes.Red;
              
            }


        }

        private void wyczysc_Liste(object sender, RoutedEventArgs e)
        {
            if (listaZakupowListBox.HasItems == false)
            {
                komunikatTextBlock.Text = "Lista jest pusta.";
                komunikatTextBlock.Foreground = Brushes.Yellow;
            }
            else
            {
                listaZakupowListBox.Items.Clear();
                komunikatTextBlock.Text = "Wyczyszczono listę.";
                komunikatTextBlock.Foreground = Brushes.Red;
            }
        }
    }
}
