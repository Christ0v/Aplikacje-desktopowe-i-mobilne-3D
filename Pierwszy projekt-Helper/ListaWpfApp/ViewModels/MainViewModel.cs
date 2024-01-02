using ListaWpfApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Linq;
using UtilsWpf;

namespace ListaWpfApp.ViewModels
{
    public class MainViewModel : ObserverVM
    {
        private ListOfProduces listOfProduces = new ListOfProduces();

        public string ProductName
        {
            get { return listOfProduces.productName; }
            set
            {
                listOfProduces.productName = value;
                OnPropertyChanged(nameof(ProductName));
            }
        }

        private string listResult;
        public string ListResult
        {
            get { return listResult; }
            set
            {
                listResult = value;
                OnPropertyChanged(nameof(ListResult));
            }
        }
        private ICommand downladDataComand;
        public ICommand DownloadDataComand
        {
            get
            {
                if (downladDataComand == null)
                    downladDataComand = new RelayCommand<object>(
                        o =>
                        {
                            string result = "";
                            result += "Produkty: " + ProductName + "\n";
                            ListResult = result;
                        }
                        );
                return downladDataComand;
            }
        }
    }
}
