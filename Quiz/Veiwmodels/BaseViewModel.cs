using Quiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Quiz.Veiwmodels
{
    public class BaseViewModel :ObservableObject
    {
        public ICommand ExitCommand { get; private set; }
        

        public ScoreModel ScoreModel { get; set; }

        

        public BaseViewModel()
        {
            ExitCommand = new RelayCommand(ExitApp);
            
        }

        private void ExitApp(object param)
        {
            System.Windows.Application.Current.Shutdown();
        }

        

       
    }
}
