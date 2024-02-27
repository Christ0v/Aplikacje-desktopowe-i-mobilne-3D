using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FirstApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void buttonAccept_Clicked(object sender, EventArgs e)
        {
            if ((entryPassword.Text == entryPasswordAgain.Text) && entryEmail.Text.Contains('@'))
            {
                labelResult.Text = "Witaj " + entryEmail.Text;
            }
            if (entryPassword.Text != entryPasswordAgain.Text)
            {
                labelResult.Text = "Hasła są różne";
            }
            if(!entryEmail.Text.Contains('@'))
            {
                labelResult.Text = "Nie poprawny adres e-mail";
            }
                   
        }
    }
}
