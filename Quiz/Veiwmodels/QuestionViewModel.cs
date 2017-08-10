using Quiz.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Quiz.Veiwmodels
{
    public class QuestionViewModel : BaseViewModel
    {

        public ICommand AnswerCommand { get; private set; }

        public ObservableCollection<QuestionModel> Questions;

        public ScoreModel ScoreModel { get; private set; }

        private int _currentQuestionIndex;

        private QuestionModel _currentQuestion;
        public QuestionModel CurrentQuestion {
            get { return _currentQuestion; }
            private set { OnPropertyChanged(ref _currentQuestion, value); }
        }



        private BaseViewModel _currentView;
        public BaseViewModel CurrentView
        {
            get { return _currentView; }
            set { OnPropertyChanged(ref _currentView, value); }
        }
     
        

        public QuestionViewModel()
        {

            //Initialises a new ObservableCollection of QuestionModels
            GenerateQuestions();
            
            //Initialise the question to the first in the collection
            _currentQuestionIndex = 0;
            CurrentQuestion = Questions[0];

            ScoreModel = new ScoreModel();
                        

            //Initialise commands
            AnswerCommand = new RelayCommand(CheckAnswer);

            CurrentView = this;

            
        }

        private void CheckAnswer(object sourcePos)
        {

            if (CurrentQuestion.AnswerPos == Convert.ToInt32(sourcePos))
                isCorrect(true);
            else
                isCorrect(false);

            Console.WriteLine(_currentQuestionIndex);

            if (_currentQuestionIndex <= (Questions.Count - 1))
                CurrentQuestion = Questions[_currentQuestionIndex];
            else
                //Start end veiw here
                CurrentView = new FinishedViewModel(ScoreModel);

        }

        private void isCorrect(bool isCorrect)
        {
            if (isCorrect)
            {
                ScoreModel.Score += ScoreModel.CorrectModifier;
            }
            else
            {
                ScoreModel.Score -= ScoreModel.IncorrectModifier;
            }


            ++_currentQuestionIndex;

        }

        private void GenerateQuestions()
        {
            Questions = new ObservableCollection<QuestionModel>
            {
                new QuestionModel(
                    "Which flourishing empire eventually fell in A.D. 476?",
                    2,
                    new ObservableCollection<string> {"Ancient Greece", "Roman", "USSR" }),

                new QuestionModel(
                    "Which waterfall, the highest in the world, is located in Venezuela?",
                    1,
                    new ObservableCollection<string> {"Angel", "Tugela", "Monge" }),
                new QuestionModel(
                    "Which literary character could not be put back together, despite the collective efforts of the king\'s horses and men?",
                    1,
                    new ObservableCollection<string>{"Humpty Dumpty", "Incy Wincy Spider", "Baa baa black sheep"}
                    ),
                new QuestionModel(
                     "In Christianity, which angel fell from the grace of the Lord?",
                     3,
                     new ObservableCollection<string>{"Micheal", "Gabriel", "Lucifer" }
                     ),
                new QuestionModel(
                    "Which country were the 1896 Olympic Games held in?",
                    2,
                    new ObservableCollection<string>{"India", "Greece", "USA" }
                    )
            };
        }

       
    }
}
