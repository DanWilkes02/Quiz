using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Models
{
    public class ScoreModel : ObservableObject
    {
        private int _score;
        public int Score
        {
            get { return _score; }
            set { OnPropertyChanged(ref _score, value); }
        }

        //Modifies the score when correct answer
        private int _correctModifier; 
        public int CorrectModifier
        {
            get { return _correctModifier; }
            set { OnPropertyChanged(ref _correctModifier, value); }
        }

        //Modifies the score when incorrect answer
        private int _incorrectModifier;
        public int IncorrectModifier
        {
            get { return _incorrectModifier; }
            set { OnPropertyChanged(ref _incorrectModifier, value); }
        }

        public ScoreModel()
        {
            _score = 0;
            _correctModifier = 10;
            _incorrectModifier = 5;
        }
    }
}
