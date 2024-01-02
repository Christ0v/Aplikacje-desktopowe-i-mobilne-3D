using PersonalQuestionnaireWpfApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UtilsWpf;

namespace PersonalQuestionnaireWpfApp.ViewModels
{
    public class MainViewModel : ObserverVM
    {
        private PersonalDataModel personalDataModel = new PersonalDataModel();  
         
        public string Name
        {
            get { return personalDataModel.name; }
            set
            {
                personalDataModel.name = value;



                OnPropertyChanged(nameof(Name));
            }
        }

        public bool Pizza
        {
            get { return personalDataModel.isPizza; }
            set
            {
                personalDataModel.isPizza = value;
                OnPropertyChanged(nameof(Pizza));
            }
        }


        public bool isMale
        {
            get { return personalDataModel.isMale; }
            set
            {
                personalDataModel.isMale = value;
                OnPropertyChanged(nameof(isMale));
            }
        }

        public bool isFemale
        {
            get { return personalDataModel.isFemale; }
            set
            {
                personalDataModel.isFemale = value;
                OnPropertyChanged(nameof(isFemale));
            }
        }


        
        public List<string> ListOfDish
        {
            get { return personalDataModel.listOfDish; }
            set
            {
                 personalDataModel.listOfDish = value;
                OnPropertyChanged(nameof(ListOfDish));
            }
        }


        public string SelectedDish
        {
            get { return personalDataModel.selectedDish; }
            set
            {
                personalDataModel.selectedDish = value;
                OnPropertyChanged(nameof(SelectedDish));
            }
        }

        private string questionnaireResult;
        public string QuestionnaireResult
        {
            get { return questionnaireResult; }
            set
            {
                questionnaireResult = value;
                OnPropertyChanged(nameof(QuestionnaireResult));
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
                            result += "Imię: " + Name + "\n";
                            result += "Lubisz pizze? : " + (Pizza ? "Tak" : "Nie") + "\n";
                            result += "Płeć: " + (isMale ? "Meżczyzna" : "Kobieta") + "\n";
                            result += "Ulubione danie: " + SelectedDish + "\n";
                            QuestionnaireResult = result; 
                        }
                        );
                return downladDataComand;
            }
        }
    }
}

/*
    ⣿⢿⡻⢝⠙⠊⠋⠉⠉⠈⠊⠝⣿⡻⠫⠫⠊⠑⠉⠉⠑⠫⢕⡫⣕⡁⠁
    ⣼⡻⠕⠅⠁⣀⣤⣤⣄⣀⠈⠄⠁⠄⠁⣿⡮⠄⠁⠄⠄⡠⠶⠶⠦⡀⠈⣽⡢
    ⣿⣧⠄⠁⠄⠔⠒⠭⠭⠥⠥⠓⠄⢀⣴⣿⣿⡄⠁⠠⣤⠉⠉⣭⠝⠈⢐⣽⣕
    ⣿⣷⡢⢄⡰⡢⡙⠄⠠⠛⠁⢀⢔⣵⣿⣿⣿⣿⣧⣄⡈⠁⠈⠁⠉⡹⣽⣿⣷
    ⣿⣿⣿⣿⣿⣬⣭⡭⠔⣠⣪⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣵⡒⠫⠿⣿⣿⣿
    ⣿⣿⣿⣿⠿⣛⣥⣶⣿⠟⢁⣶⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⡙⣿⣿⣶⣿⣿⣿
    ⣿⣿⣿⣿⣿⣿⣿⡫⠁⢀⠑⠓⠫⢝⢟⣿⣿⣿⣿⡻⠊⢉⣄⠈⠪⡫⢿⣿⣿
    ⣿⣿⣿⣿⣿⣿⢟⠁⣰⣿⣿⣢⢤⣀⡀⠈⠉⠉⢀⠠⠪⢝⡻⣷⡀⠊⡪⡻⣿
    ⡫⢟⣿⣿⣿⣿⡊⢠⣿⣿⡫⠚⣊⣡⠶⢦⣤⣤⠶⠞⡛⠳⣌⠫⡻⡀⠈⡺⢿
    ⠪⡪⡫⢟⡿⣕⠁⡫⠝⠊⡴⠋⠁⠁⠐⠁⠂⠈⠐⠈⠈⠐⠐⠳⠄⠹⣇⠪⡻
    ⠄⠁⠊⠕⡪⢕⢀⠞⠁⠄⣁⢀⢀⣀⣤⣤⣠⣀⣤⣴⣶⣶⣶⡆⠄⠆⢷⠕⡪
    ⣄⠄⠁⠄⠁⠄⡎⠄⠁⢬⣮⣕⠻⢿⣿⣿⣿⣿⣿⣿⣿⣿⡫⡪⡵⠄⠁⠄⠈
    ⠁⠄⠁⠄⡣⠄⠁⣷⣯⣵⣢⠄⠄⠉⠉⠉⠉⠉⠉⣠⣬⣟⡕⠄⠁⢀⣿
        ⠁⠄⡎⠄⠁⠻⣿⣾⣯⣪⣔⢄⣀⣀⣀⡠⣶⣾⣽⣿⠃⠄
              _/:     :\____ ___
      .'   `.-===-\   /-===-.`   '.
     /      .-"""""-.-"""""-.      \
    /'             =:=             '\
  .'  ' .:    o   -=:=-   o    :. '  `.   
  (.'   /'. '-.....-'-.....-' .'\   '.)
  /' ._/   ".     --:--     ."   \_. '\
 |  .'|      ".  ---:---  ."      |'.  |
 |  : |       |  ---:---  |       | :  |
  \ : |       |_____._____|       | : /
  /   (       |----|------|       )   \ 
 /... .|      |    |      |      |. ...\
|::::/'' jgs /     |       \     ''\::::|      
'""""       /'    .L_      `\       """"'
           /'-.,__/` `\__..-'\
          ;      /     \      ;
          :     /       \     |
          |    /         \.   |
          |`../           |  ,/
          ( _ )           |  _)
          |   |           |   |
          |___|           \___|
          :===|            |==|
           \  /            |__|
           /\/\           /"""`8.__
           |oo|           \__.//___)
           \__/

I CAN BREATH
*/