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
                            result += "Pizza? : " + (Pizza ? "Tak" : "Nie") + "\n";
                            QuestionnaireResult = result; 
                        }
                        );
                return downladDataComand;
            }
        }
    }
}

/*
⣼⣿⣿⢿⡻⢝⠙⠊⠋⠉⠉⠈⠊⠝⣿⡻⠫⠫⠊⠑⠉⠉⠑⠫⢕⡫⣕⡁⠁
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
⣿⣄⠁⠄⠁⠄⡣⠄⠁⣷⣯⣵⣢⠄⠄⠉⠉⠉⠉⠉⠉⣠⣬⣟⡕⠄⠁⢀⣿
⣿⣿⣷⡀⠁⠄⡎⠄⠁⠻⣿⣾⣯⣪⣔⢄⣀⣀⣀⡠⣶⣾⣽⣿⠃⠄⢀⣼⣿ 
I CAN BREATH*/