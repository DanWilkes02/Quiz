using Quiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Quiz.Veiwmodels
{
    public class ApplicationViewModel : BaseViewModel
    {
        private BaseViewModel _currentView;
        public BaseViewModel CurrentView
        {
            get { return _currentView; }
            set { OnPropertyChanged(ref _currentView, value); }
        }
        
        public ICommand ChangeViewCommand { get; set; }

        public ApplicationViewModel()
        {
            ScoreModel = new ScoreModel();
            CurrentView = new QuestionViewModel(ScoreModel, this);
            ChangeViewCommand = new RelayCommand(ChangeView);
        }

        public void ChangeView(object view)
        {
            switch((string)view)
            {
                case "QuizView":
                    CurrentView = new QuestionViewModel(ScoreModel, this);
                    break;
                case "FinishedView":
                    CurrentView = new FinishedViewModel(ScoreModel, this);
                    break;
                case "AnalysisView":
                    CurrentView = new AnalysisViewModel(ScoreModel);
                    break;
            }

            Console.WriteLine($"ViewChanged to: {CurrentView}");
        }
    }
}
