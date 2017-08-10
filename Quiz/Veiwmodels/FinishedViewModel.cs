using Quiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Veiwmodels
{
    public class FinishedViewModel : BaseViewModel
    {

        public ScoreModel ScoreModel { get; private set; }

        public FinishedViewModel(ScoreModel scoreModel)
        {
            ScoreModel =  scoreModel;
        }
    }
}
