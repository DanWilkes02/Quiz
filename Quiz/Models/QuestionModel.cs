using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Models
{
    public class QuestionModel : ObservableObject
    {
        private string _question;
        public string Question
        {
            get { return _question; }
            set { OnPropertyChanged(ref _question, value); }
        }

        //Which button the answer sits in          
        private int _answerPos; 
        public int AnswerPos
        {
            get { return _answerPos; }
            set { OnPropertyChanged(ref _answerPos, value); }
        }

        private ObservableCollection<string> _answerChoices;
        public ObservableCollection<string> AnswerChoices
        {
            get { return _answerChoices; }
            set { OnPropertyChanged(ref _answerChoices, value); }
        }

        //Holds whether the answer is correct for this question
        private bool? _isCorrect; 
        public bool? isCorrect
        {
            get { return _isCorrect; }
            set { _isCorrect = value; }
        }

        public QuestionModel(string question, int answerPos, 
            ObservableCollection<string> answerChoices)
        {
            _question = question;
            _answerPos = answerPos;
            _answerChoices = answerChoices;
            _isCorrect = null;
        }
    }
}
